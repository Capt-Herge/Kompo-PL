using System;
using System.Data;

using PartsLogic.Support;

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
