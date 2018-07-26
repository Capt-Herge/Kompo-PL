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
            _dbProviderFactory = dbProviderFactory;
            _dbConnection = dbConnection;
            _dbCommand = dbCommand;
        }
        public void ReadParts(Part part, out DataTable dataTableParts)
        {
            dataTableParts = new DataTable("Parts");
            DbDataAdapter dbDataAdapter = _dbProviderFactory.CreateDataAdapter();
            this.SqlSelectPart(part, _dbCommand);
            dbDataAdapter.SelectCommand = _dbCommand;
            int records = dbDataAdapter.Fill(dataTableParts);
        }
        #endregion

        #region virtual methods
        protected virtual void SqlSelectPart(Part partSearch, DbCommand dbCommand)
        {
            // todo
            // Vielleicht Substringsuche einbauen bei Name und Beschreibung
            dbCommand.CommandType = CommandType.Text;
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = @"SELECT * FROM PartsTable";

            if(partSearch.Hersteller == "")
            {
                partSearch.Hersteller = "*";
                dbCommand.CommandText = @"WHERE ";
            }
            else
            {
                dbCommand.CommandText += "WHERE Hersteller = @Hersteller";
                AData.AddParameter(dbCommand, "@Hersteller", partSearch.Hersteller);
            }
            
            if(partSearch.Name != "")
            {
                dbCommand.CommandText += " AND Name = @Name";
                AData.AddParameter(dbCommand, "@Name", partSearch.Name);
            }
            if (partSearch.PN != "")
            {
                dbCommand.CommandText += " AND PN = @PN";
                AData.AddParameter(dbCommand, "@PN", partSearch.PN);
            }
            if (partSearch.Beschreibung != "")
            {
                dbCommand.CommandText += " AND Beschreibung = @Beschreibung";
                AData.AddParameter(dbCommand, "@Beschreibung", partSearch.Beschreibung);
            }
        }
        #endregion
    }
}
