﻿using System;
using System.Data;

using PartsLogic.Support;

namespace PartsLogic
{
    public interface IDataModify
    {
        void ModifyPart(Part partModify);
    }
}
