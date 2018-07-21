using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic
{
    internal class CLogic
    {
        #region fields
        private IData _data;
        #endregion

        #region ctor
        internal CLogic(IData data)
        {
            _data = data;
        }
        #endregion
    }
}
