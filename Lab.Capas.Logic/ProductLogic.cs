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
    public class ProductLogic : BaseLogic
    {
        public List<Products> Productos()
        {
            try
            {
                return context.Products.ToList();
            }
            catch
            {
                throw new ErrorGeneral();
            }
        }

        public Products Productos(int id)
        {
            try
            {
                return context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
            }
            catch
            {
                throw new ErrorGeneral();
            }

        }
    }
}
