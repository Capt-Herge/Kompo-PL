using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using PartsLogic;
using PartsLogic.Exceptions;

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
            //ProviderFactory erstellen
            _dbProviderFactory = DbProviderFactories.GetFactory(_provider);
            if (_dbProviderFactory == null)
            {
                throw new CDataException("InitDb() konnte DbProviderFactory nicht erzeugen");
            }
            //erstelle dbConnection via ProviderFactory
            _dbConnection = _dbProviderFactory.CreateConnection();
            if(_dbConnection == null)
            {
                throw new CDataException("InitDb() konne DbConnection nicht erzeugen");
            }
            //Setze den Connectionstring
            _dbConnection.ConnectionString = _connection;
            //Befülle die DbCommand Objekte
            _dbCommand = _dbProviderFactory.CreateCommand();
            _dbCommand.Connection = _dbConnection;
            _dbCommand.CommandType = CommandType.Text;
            //Initialisiere die anderen PartsData Klassen
            _dataAdd.Init(_dbProviderFactory, _dbConnection, _dbCommand);
            _dataModify.Init(_dbProviderFactory, _dbConnection, _dbCommand);
            _dataSearch.Init(_dbProviderFactory, _dbConnection, _dbCommand);
        }
        public void GetHersteller(out IList<string> hersteller)
        {
            AData.Open(_dbConnection);
            hersteller = new List<string>();
            _dbCommand.CommandText = "SELECT DISTINCT Hersteller FROM PartsTable ORDER BY Hersteller;";
            _dbCommand.CommandType = CommandType.Text;
            DbDataReader dbDataReader = _dbCommand.ExecuteReader();
            if (dbDataReader != null)
            {
                while (dbDataReader.Read())
                    hersteller.Add(dbDataReader[0].ToString());
            }
            if (!dbDataReader.IsClosed) dbDataReader.Close();
            AData.Close(_dbConnection);
        }
        #endregion

        #region static methods
        public static void Open(DbConnection dbConnection)
        {
            if (dbConnection.State == ConnectionState.Open) return;
            dbConnection.Open();
            if (dbConnection.State != ConnectionState.Open)
            {
                var connection = dbConnection.ConnectionString;
                throw new CDataException($"Open() Datenbankverbindung konnte nicht geöffnet werden\n{connection}");
            }
        }
        public static void Close(DbConnection dbConnection)
        {
            if (dbConnection.State != ConnectionState.Open) return;
            dbConnection.Close();
            if (dbConnection.State != ConnectionState.Closed)
            {
                var connection = dbConnection.ConnectionString;
                throw new CDataException($"Close() Datenbankverbindung konnte nicht geschlossen werden\n{connection}");
            }
        }
        public static void AddParameter(DbCommand dbCommand, string name, object value)
        {
            DbParameter dbParameter = dbCommand.CreateParameter();
            dbParameter.ParameterName = name;
            dbParameter.Value = value;
            dbCommand.Parameters.Add(dbParameter);
        }
        #endregion

        #region protected virtual methods
        #endregion
    }
}
