using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartsLogic;
using PartsLogic.Factories;
using PartsData.Access;

namespace PartsData.Factories
{
    public class CFactoryCDataAccess : IFactoryIData
    {
        public IData Create(string connection)
        {
            return new CData(connection);
        }
    }
}
