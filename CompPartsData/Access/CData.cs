namespace PartsData.Access
{
    internal class CData : AData
    {
        internal CData(string connection) : base(connection)
        {
            _provider = "System.Data.SqlClient";
            _dataAdd = new CDataAdd(this);
            _dataModify = new CDataModify(this);
            _dataSearch = new CDataSearch(this);
        }
    }
}
