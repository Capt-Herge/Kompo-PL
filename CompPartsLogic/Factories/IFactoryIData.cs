using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic.Factories
{
    interface IFactoryIData
    {
        IData Create(string connection);
    }
}
