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
        public double Preis { get; set; }
        public int Anzahl { get; set; }
        #endregion

        #region ctor
        public Part() { }

        public Part(DataRow dataRow )
        {
            PkID = Convert.ToInt32(dataRow.ItemArray[0]);
            Name = Convert.ToString(dataRow.ItemArray[1]);
            Hersteller = Convert.ToString(dataRow.ItemArray[2]);
            PN = Convert.ToString(dataRow.ItemArray[3]);
            Beschreibung = Convert.ToString(dataRow.ItemArray[4]);
            Preis = Convert.ToDouble(dataRow.ItemArray[5]);
            Anzahl = Convert.ToInt32(dataRow.ItemArray[6]);
        }
        #endregion

    }
}
