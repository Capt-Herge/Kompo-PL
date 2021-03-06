﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PartsLogic;
using PartsLogic.Support;

namespace PartsData
{
    internal abstract class ADataAdd : IDataAdd
    {
        #region fields
        protected AData _data;
        protected DbProviderFactory _dbProviderFactory;
        protected DbConnection _dbConnection;
        protected DbCommand _dbCommand;
        #endregion

        #region ctor
        internal ADataAdd(AData data)
        {
            _data = data;
        }
        #endregion

        #region interface IDataAdd methods
        public void Init(DbProviderFactory dbProviderFactory, DbConnection dbConnection, DbCommand dbCommand)
        {
            //Ablegen des übergebenen Objekte in eigene Felder
            _dbProviderFactory = dbProviderFactory;
            _dbConnection = dbConnection;
            _dbCommand = dbCommand;
        }

        public void AddPart(Part partAdd)
        {
            //Zusammenbauen des SQL Commands
            this.SqlAddPart(partAdd, _dbCommand);
            //Öffnen der DB-Verbindung
            _dbConnection.Open();
            //Ausführen des SQL-Commands
            int rows = _dbCommand.ExecuteNonQuery();
            //Schließen der DB-Verbindung
            _dbConnection.Close();
        }

        #endregion

        #region protected virtual protected methods
        protected void SqlAddPart(Part partAdd, DbCommand dbCommand)
        {
            //Definieren des Command Types und vorsichtshalber Leeren des Parameter
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            // Einfügen der parametrisierten Struktur
            dbCommand.CommandText = $"INSERT dbo.PartsTable" +
               $" (Name, Hersteller, PN, Beschreibung, Preis, Anzahl )" +
               $" VALUES " +
               $" (@Name, @Hersteller, @PN, @Beschreibung, @Preis, @Anzahl);";
            //Eintragen der Parameterwerte
            AData.AddParameter(dbCommand, "@Name", partAdd.Name);
            AData.AddParameter(dbCommand, "@Hersteller", partAdd.Hersteller);
            AData.AddParameter(dbCommand, "@PN", partAdd.PN);
            AData.AddParameter(dbCommand, "@Beschreibung", partAdd.Beschreibung);
            AData.AddParameter(dbCommand, "@Preis", partAdd.Preis);
            AData.AddParameter(dbCommand, "@Anzahl", partAdd.Anzahl);

        }
        #endregion
    }
}
