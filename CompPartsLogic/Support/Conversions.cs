using System;
using System.Collections.Generic;

namespace PartsLogic.Support
{
    public class Conversions
    {
        public static object[] ListToArray(IList<string> list)
        {
            object[] arrayFromList = new object[list.Count];
            for (int i = 0; i < list.Count; i++)
                arrayFromList[i] = list[i] as object;
            return arrayFromList;
        }
        public static int ParseInt(string s)
        {
            int value;
            if (!int.TryParse(s, out value))
            {
                //Fehler werfen
            }
            return value;
        }
    }
}
