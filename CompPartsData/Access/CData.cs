using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartsLogic;

namespace PartsData.Access
{
    class CData : AData
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
