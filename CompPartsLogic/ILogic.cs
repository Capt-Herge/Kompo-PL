using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic
{
    public interface ILogic
    {
        ILogicCount Count { get; }
        ILogicManage Manage { get; }
        ILogicModify Modify { get; }
        ILogicSearch Search { get; }

    }
}
