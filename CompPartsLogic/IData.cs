using System;
using System.Collections.Generic;


namespace PartsLogic
{
    public interface IData
    {
        IDataSearch Search { get; }
        IDataAdd Add { get; }
        IDataModify Modify { get; }

        void Init();
        void GetHersteller(out IList<string> hersteller);
    }
}
