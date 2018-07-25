using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PartsLogic;

namespace PartsData
{
    internal abstract class AData : IData
    {
        #region fields
        protected string _connection;
        protected string _provider;
        protected ADataAdd _dataAdd;
        protected ADataModify _dataModify;
        protected ADataSearch _dataSearch;
        protected DbProviderFactory _dbProviderFactory;
        protected DbConnection _dbConnection;
        protected DbCommand _dbCommand;
        #endregion

        #region interface IData properties
        public IDataAdd Add { get { return _dataAdd; } }
        public IDataModify Modify { get { return _dataModify; } }
        public IDataSearch Search { get { return _dataSearch; } }
        #endregion

        #region ctor
        #endregion

        #region interface IData methods
        public void GetHersteller(out IList<string> hersteller)
        {

        }
        #endregion

        #region static methods
        #endregion

        #region protected virtual methods
        #endregion
    }
}
