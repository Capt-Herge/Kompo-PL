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
        internal AData(string connection)
        {
            _connection = connection;
        }
        #endregion

        #region interface IData methods
        public void Init()
        {
            _dbProviderFactory = DbProviderFactories.GetFactory(_provider);
            if (_dbProviderFactory == null)
            {
                throw new CDataException("InitDb() konnte DbProviderFactory nicht erzeugen");
            }

            _dbConnection = _dbProviderFactory.CreateConnection();
            if(_dbConnection == null)
            {
                throw new CDataException("InitDb() konne DbConnection nicht erzeugen");
            }
            _dbConnection.ConnectionString = _connection;

            _dbCommand = _dbProviderFactory.CreateCommand();
            _dbCommand.Connection = _dbConnection;
            _dbCommand.CommandType = CommandType.Text;

            _dataAdd.Init(_dbProviderFactory, _dbConnection, _dbCommand);
            _dataModify.Init(_dbProviderFactory, _dbConnection, _dbCommand);
            _dataSearch.Init(_dbProviderFactory, _dbConnection, _dbCommand);
        }
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
