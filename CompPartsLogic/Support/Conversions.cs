using System;
using System.Collections.Generic;

namespace PartsLogic.Support
{
    class Conversions
    {
        public static object[] ListToArray(IList<string> list)
        {
            object[] arrayFromList = new object[list.Count];
            for (int i = 0; i < list.Count; i++)
                arrayFromList[i] = list[i] as object;
            return arrayFromList;
        }
    }
}
