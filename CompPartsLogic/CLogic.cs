using System;
using System.Data;
using System.Collections.Generic;

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

        #region Interface Methods
        public void GetHersteller(out object[] arrayHersteller)
        {
            _data.GetHersteller(out IList<string> hersteller);
            if(hersteller == null)
            {
                //Exception werfen
            }
            arrayHersteller = Conversions.ListToArray(hersteller);
        }
        #endregion
    }
}
