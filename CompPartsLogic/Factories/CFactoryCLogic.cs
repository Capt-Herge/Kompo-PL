using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic.Factories
{
    class CFactoryCLogic
    {
        public ILogic Create(IData data)
        {
            return new CLogic(data);
        }
    }
}
