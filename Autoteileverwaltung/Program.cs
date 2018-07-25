using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PartsData.Factories;
using PartsLogic;
using PartsLogic.Factories;
using PartsUI.Factories;

namespace Autoteileverwaltung
{
    class Program
    {
        #region fields
        // State
        private IData _data;
        private ILogic _logic;
        private IDialog _dialogMain;
        #endregion

        #region methods
        void Run()
        {

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Program().Run();
        }
        #endregion
    }
}
