using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PartsLogic;
using PartsLogic.Support;

namespace PartsData
{
    class ADataAdd : IDataAdd
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

        #region interface IDataModify methods
        public void Init(DbProviderFactory dbProviderFactory, DbConnection dbConnection, DbCommand dbCommand)
        {
            _dbProviderFactory = dbProviderFactory;
            _dbConnection = dbConnection;
            _dbCommand = dbCommand;
        }

        public void AddPart(Part partAdd)
        {

        }

        #endregion

        #region virtual methods
        protected void SqlAddPart(Part partAdd, DbCommand dbCommand)
        {

        }
        #endregion
    }
}
