using PartsLogic;
using PartsUI.Search;

namespace PartsUI.Factories
{
    public abstract class AFactoryDialogSearch
    {
        public static void CreateSearch(ILogicSearch logicSearch, IDialog dialog)
        {
            if(dialog is CDialog)
            {
                (dialog as CDialog).DialogSearch = new CDialogSearch(logicSearch, dialog);
            }
        }
        public static void CreateSearchResult(IDialog dialog)
        {
            if(dialog is CDialog)
            {
                (dialog as CDialog).DialogSearchResult = new CDialogSearchResult(dialog);
            }
        }
    }
}
