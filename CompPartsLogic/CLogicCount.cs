using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic
{
    internal class CLogicCount
    {
        #region fields
        private IDataCount _dataCount;
        #endregion

        #region ctor
        internal CLogicCount(IDataCount dataCount)
        {
            _dataCount = dataCount;
        }
        #endregion
    }
}
