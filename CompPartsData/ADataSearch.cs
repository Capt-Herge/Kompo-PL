using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PartsLogic;
using PartsLogic.Support;

namespace PartsData
{
    internal abstract class ADataSearch : IDataSearch
    {
        #region fields
        protected AData _data;
        protected DbProviderFactory _dbProviderFactory;
        protected DbConnection _dbConnection;
        protected DbCommand _dbCommand;
        #endregion

        #region ctor
        internal ADataSearch(AData data)
        {
            _data = data;
        }
        #endregion

        #region interface IDataSearch methods
        public void Init(DbProviderFactory dbProviderFactory, DbConnection dbConnection, DbCommand dbCommand)
        {
            //Ablegen des übergebenen Objekte in eigene Felder
            _dbProviderFactory = dbProviderFactory;
            _dbConnection = dbConnection;
            _dbCommand = dbCommand;
        }
        public void ReadParts(Part partSearch, out DataTable dataTableParts)
        {
            //Anlegen der Output-DataTable
            dataTableParts = new DataTable("Parts");
            //Erstellen des Data Adapters
            DbDataAdapter dbDataAdapter = _dbProviderFactory.CreateDataAdapter();
            //Zusammenbauen des SQL Commands
            this.SqlSelectPart(partSearch, _dbCommand);
            //Ausführen des Kommandos
            dbDataAdapter.SelectCommand = _dbCommand;
            int records = dbDataAdapter.Fill(dataTableParts);
        }
        #endregion

        #region protected virtual methods
        protected virtual void SqlSelectPart(Part partSearch, DbCommand dbCommand)
        {
            //Command Type setzen und einfügen des Anfangs des SQL Kommandos
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = @"SELECT * FROM PartsTable ";

            //Entscheidungsbaum für die weiteren Where-Clauses
            if(partSearch.Hersteller == null)
            {
                //partSearch.Hersteller = "*";
                dbCommand.CommandText += "";
            }
            else
            {
                dbCommand.CommandText += "WHERE Hersteller = '@Hersteller'";
                AData.AddParameter(dbCommand, "@Hersteller", partSearch.Hersteller);
            }
            
            if(partSearch.Name != null)
            {
                dbCommand.CommandText += " AND Name LIKE '%@Name%'";
                AData.AddParameter(dbCommand, "@Name", partSearch.Name);
            }
            if (partSearch.PN != null)
            {
                dbCommand.CommandText += " AND PN LIKE '%@PN%'";
                AData.AddParameter(dbCommand, "@PN", partSearch.PN);
            }
            if (partSearch.Beschreibung != null)
            {
                dbCommand.CommandText += " AND Beschreibung LIKE '%@Beschreibung%'";
                AData.AddParameter(dbCommand, "@Beschreibung", partSearch.Beschreibung);
            }
        }
        #endregion
    }
}
