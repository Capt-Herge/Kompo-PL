using PartsLogic;
using PartsLogic.Factories;

namespace PartsUI.Factories
{
    public class CFactoryCDialog : IFactoryIDialog
    {
        public IDialog Create(ILogic iLogic)
        {
            return new CDialog(iLogic);
        }
    }
}
