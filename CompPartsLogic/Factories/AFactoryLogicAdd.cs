

namespace PartsLogic.Factories
{
    public abstract class AFactoryLogicAdd
    {
        public static void Create(ILogic logic, IDataAdd dataAdd)
        {
            if (logic is CLogic)
               (logic as CLogic).Add = new CLogicAdd(dataAdd);
        }
    }
}
