using PartsLogic;
using PartsUI.Modify;

namespace PartsUI.Factories
{
    public abstract class AFactoryDialogModify
    {
        public static void CreateModify(ILogicModify logicModify, IDialog dialog)
        {
            if (dialog is CDialog)
            {
                (dialog as CDialog).DialogModify = new CDialogModify(logicModify, dialog);
            }
        }
    }
}
