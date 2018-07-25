using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
