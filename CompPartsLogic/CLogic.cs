using System;
using System.Data;

using PartsLogic.Support;

namespace PartsLogic
{
    internal class CLogic : ILogic
    {
        #region fields
        private IData _data;
        #endregion

        #region interface props
        public ILogicAdd Add { get; internal set; }
        public ILogicModify Modify { get; internal set; }
        public ILogicSearch Search { get; internal set; }
        #endregion

        #region ctor
        internal CLogic(IData data)
        {
            _data = data;
        }
        #endregion
    }
}
