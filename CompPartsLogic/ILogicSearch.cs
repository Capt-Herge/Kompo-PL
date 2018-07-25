using System;
using System.Data;

using PartsLogic.Support;

namespace PartsLogic
{
    public interface ILogicSearch
    {
        void ReadParts(Part partSearch, out DataTable dataTable);
    }
}
