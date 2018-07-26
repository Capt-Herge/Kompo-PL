using System;
using System.Data;

using PartsLogic.Support;

namespace PartsLogic
{
    public interface ILogicModify
    {
        void ModifyPart(Part partModify);
    }
}
