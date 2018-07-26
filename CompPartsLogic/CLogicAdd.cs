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

        #region ILogicAdd Methods
        public void AddPart(Part partAdd)
        {
            _dataAdd.AddPart(partAdd);
        }
        #endregion
    }
}
