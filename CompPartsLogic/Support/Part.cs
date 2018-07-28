using System;
using System.Data;


namespace PartsLogic.Support
{
    public class Part
    {
        #region fields
        public int PkID { get; set; }
        public string Name { get; set; }
        public string Hersteller { get; set; }
        public string PN { get; set; }
        public string Beschreibung { get; set; }
        public string Preis { get; set; }
        public int Anzahl { get; set; }
        #endregion

        #region ctor
        public Part() { }
        #endregion

    }
}
