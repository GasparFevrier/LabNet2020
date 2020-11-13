using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Capas.Logic.MisExceptions
{
    public class ErrorGeneral:Exception
    {
        public ErrorGeneral():base("Se produjo un error inesperado contactarse con el soporte")
        {

        }

    }
}
