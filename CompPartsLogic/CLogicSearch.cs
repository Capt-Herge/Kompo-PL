using System;
using System.Data;

using PartsLogic.Support;

namespace PartsLogic
{
    internal class CLogicSearch : ILogicSearch
    {
        #region fields
        private IDataSearch _dataSearch;
        #endregion

        #region ctor
        internal CLogicSearch(IDataSearch dataSearch)
        {
            _dataSearch = dataSearch;
        }
        #endregion

        #region ILogicSearch Methoden
        public void ReadParts(Part partSearch, out DataTable dataTable)
        {
            _dataSearch.ReadParts(partSearch, out dataTable);
        }
        #endregion
    }
}
