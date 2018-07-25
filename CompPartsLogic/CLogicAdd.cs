using System;
using System.Data;

using PartsLogic.Support;

namespace PartsLogic
{
    internal class CLogicAdd : ILogicAdd
    {
        #region fields
        private IDataAdd _dataAdd;
        #endregion

        #region ctor
        internal CLogicAdd(IDataAdd dataAdd)
        {
            _dataAdd = dataAdd;
        }
        #endregion
    }
}
