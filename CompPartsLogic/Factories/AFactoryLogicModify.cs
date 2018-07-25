

namespace PartsLogic.Factories
{
    public abstract class AFactoryLogicModify
    {
        public static void Create(ILogic logic, IDataModify dataModify)
        {
            if (logic is CLogic)
                (logic as CLogic).Modify = new CLogicModify(dataModify);
        }
    }
}
