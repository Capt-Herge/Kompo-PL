using System;


namespace PartsLogic
{
    public interface IData
    {
        IDataSearch Search { get; }
        IDataAdd Add { get; }
        IDataModify Modify { get; }

        void Init();
    }
}
