using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartsLogic.Factories
{
    public interface IFactoryIDialog
    {
        IDialog Create(string version, ILogic logic);
    }
}
