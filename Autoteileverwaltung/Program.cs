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
    internal class Program
    {
        #region fields
        // State
        private IData _data;
        private ILogic _logic;
        private IDialog _dialog;
        #endregion

        #region methods
        internal void Run()
        {
            //Connection String zum MSSQL 2016 Server (Standartinstand, Standart-Auth)
            //Server bei Johannes: Server=plasma.selfhost.bz;Database=PartsData;User Id=sa;Password=AngewandteInformatik1337!;
            string connectionString = "Server=plasma.selfhost.bz;Database=PartsData;User Id=sa;Password=AngewandteInformatik1337!;";

            //Erstellung - PartsData
            IFactoryIData factoryData = new CFactoryCDataAccess();
            _data = factoryData.Create(connectionString);

            //Erstellung - PartsLogic
            IFactoryILogic factoryLogic = new CFactoryCLogic();
            _logic = factoryLogic.Create(_data);
            AFactoryLogicAdd.Create(_logic, _data.Add);
            AFactoryLogicModify.Create(_logic, _data.Modify);
            AFactoryLogicSearch.Create(_logic, _data.Search);

            //Erstelllung - PartsDialog
            IFactoryIDialog factoryDialog = new CFactoryCDialog();
            _dialog = factoryDialog.Create(_logic);
            AFactoryDialogAdd.CreateAdd(_logic.Add, _dialog);
            AFactoryDialogModify.CreateModify(_logic.Modify, _dialog);
            AFactoryDialogSearch.CreateSearch(_logic.Search, _dialog);
            AFactoryDialogSearch.CreateSearchResult(_dialog);

            //Initialisieren der Datenbankverbindung
            _data.Init();

            //Initialisierung fertig - Starten des Hauptdialogs
            Application.Run(_dialog as Form);
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
