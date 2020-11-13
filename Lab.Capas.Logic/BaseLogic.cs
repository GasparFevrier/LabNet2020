using Lab.Capas.RerourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Capas.Consola
{
    public abstract class BaseLogic
    {
        protected readonly NortwindContext context;

        public BaseLogic()
        {
            this.context = new NortwindContext();
        }
    }
}
