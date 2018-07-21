using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic
{
    internal class CLogicSearch
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
    }
}
