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
