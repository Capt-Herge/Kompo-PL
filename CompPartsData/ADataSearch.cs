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

        #region interface ISearch methods

        #endregion

        public void ReadParts(Part part, out DataTable dataTableParts)
        {
            dataTableParts = new DataTable("Parts");
            DbDataAdapter dbDataAdapter = _dbProviderFactory.CreateDataAdapter();
            this.SqlSelectPart(part, _dbCommand);
            dbDataAdapter.SelectCommand = _dbCommand;
            int records = dbDataAdapter.Fill(dataTableParts);
        }

        #region virtual methods
        protected virtual void SqlSelectPart(Part part, DbCommand dbCommand)
        {

        }
        #endregion
    }
}
