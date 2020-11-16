using Lab.Capas.Consola;
using Lab.Capas.Entities;
using Lab.Capas.Logic.MisExceptions;
using Lab.Capas.RerourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Capas.Logic
{
    public class EmpleadoLogic : BaseLogic
    {
        public List<Employees> Empleados()
        {
            try 
            { 
                return context.Employees.ToList();
            }
            catch
            {
                throw new ErrorGeneral();
            }

        }

        public Employees Empleado(int id)
        {
            try
            {
                return context.Employees.FirstOrDefault(r => r.EmployeeID.Equals(id));
            }
            catch
            {
                throw new ErrorGeneral();
            }

        }

    }
}
