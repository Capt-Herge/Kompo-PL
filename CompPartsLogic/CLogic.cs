using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic
{
    internal class CLogic : ILogic
    {
        #region fields
        private IData _data;
        #endregion

        #region interface props
        public ILogicCount Count { get; internal set; }
        public ILogicManage Manage { get; internal set; }
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
