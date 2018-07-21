using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic
{
    internal class CLogicManage
    {
        #region fields
        private IDataManage _dataManage;
        #endregion

        #region ctor
        internal CLogicManage (IDataManage dataManage)
        {
            _dataManage = dataManage;
        }
        #endregion
    }
}
