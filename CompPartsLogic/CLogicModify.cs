using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic
{
    internal class CLogicModify : ILogicModify
    {
        #region fields
        private IDataModify _dataModify;
        #endregion

        #region ctor
        internal CLogicModify(IDataModify dataModify)
        {
            _dataModify = dataModify;
        }
        #endregion
    }
}
