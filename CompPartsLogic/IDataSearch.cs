using System;
using System.Data;
using PartsLogic.Support;

namespace PartsLogic
{
    public interface IDataSearch
    {
        void ReadParts(Part partSearch, out DataTable DTParts);
    }
}
