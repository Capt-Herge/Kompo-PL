using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PartsLogic;
using PartsLogic.Support;

namespace PartsData
{
    class ADataModify : IDataModify
    {
        #region fields
        protected AData _data;
        protected DbProviderFactory _dbProviderFactory;
        protected DbConnection _dbConnection;
        protected DbCommand _dbCommand;
        #endregion

        #region ctor
        internal ADataModify(AData data)
        {
            _data = data;
        }
        #endregion

        #region interface IDataModify methods
        public void Init(DbProviderFactory dbProviderFactory, DbConnection dbConnection, DbCommand dbCommand)
        {
            //Ablegen des übergebenen Objekte in eigene Felder
            _dbProviderFactory = dbProviderFactory;
            _dbConnection = dbConnection;
            _dbCommand = dbCommand;
        }
        public void ModifyPart(Part partModify)
        {
            //Zusammenbauen des SQL Commands
            this.SqlModifyPart(partModify, _dbCommand);
            //Öffnen der DB-Verbindung
            _dbConnection.Open();
            //Ausführen des Kommandos
            int rows = _dbCommand.ExecuteNonQuery();
            //Schließen der DB-Verbindung
            _dbConnection.Close();
        }
        public void DeletePart(Part partDelete)
        {
            //Zusammenbauen des SQL Commands
            this.SqlDeletePart(partDelete, _dbCommand);
            //Öffnen der DB-Verbindung
            _dbConnection.Open();
            //Ausführen des Kommandos
            int rows = _dbCommand.ExecuteNonQuery();
            //Schließen der DB-Verbindung
            _dbConnection.Close();
        }
        #endregion

        #region protected virtual methods
        protected void SqlModifyPart(Part partModify, DbCommand dbCommand)
        {
            //Definieren des Command Types und vorsichtshalber Leeren des Parameter
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            //Einfügen der parametrisierten Struktur
            dbCommand.CommandText = $"UPDATE PartsTable " +
               $"SET " +
               $"Name = @Name, Hersteller = @Hersteller, PN = @PN, Beschreibung = @Beschreibung, Preis = @Preis, Anzahl = @Anzahl " +
               $"WHERE ID = @ID;";
            //Befüllen der Parameter mit Werten des partModify Objekts
            AData.AddParameter(dbCommand, "@ID", partModify.PkID);
            AData.AddParameter(dbCommand, "@Name", partModify.Name);
            AData.AddParameter(dbCommand, "@Hersteller", partModify.Hersteller);
            AData.AddParameter(dbCommand, "@PN", partModify.PN);
            AData.AddParameter(dbCommand, "@Beschreibung", partModify.Beschreibung);
            AData.AddParameter(dbCommand, "@Preis", partModify.Preis);
            AData.AddParameter(dbCommand, "@Anzahl", partModify.Anzahl);
        }
        protected void SqlDeletePart(Part partDelete, DbCommand dbCommand)
        {
            //Definieren des Command Types und vorsichtshalber Leeren des Parameter
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            //Einfügen der parametrisierten Struktur
            dbCommand.CommandText = $"DELETE FROM PartsTable WHERE ID = @ID;";
            //Befüllen des ID Parameters mit Wert aus dem partdelete Objekts
            AData.AddParameter(dbCommand, "@ID", partDelete.PkID);
        }
        #endregion
    }
}
