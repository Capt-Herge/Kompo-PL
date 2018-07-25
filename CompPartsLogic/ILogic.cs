﻿using System;
using System.Data;

using PartsLogic.Support;

namespace PartsLogic
{
    public interface ILogic
    {
        ILogicAdd Add { get; }
        ILogicModify Modify { get; }
        ILogicSearch Search { get; }

    }
}
