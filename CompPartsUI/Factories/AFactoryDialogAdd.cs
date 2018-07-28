
using PartsLogic;
using PartsUI.Add;

namespace PartsUI.Factories
{
    public abstract class AFactoryDialogAdd
    {
        public static void CreateAdd(ILogicAdd logicAdd, IDialog dialog)
        {
            if (dialog is CDialog)
            {
                (dialog as CDialog).DialogAdd = new CDialogAdd(logicAdd, dialog);
            }
        }
    }
}
