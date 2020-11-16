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
        public List<Products> Productos(string inpBuscar)
        {
            try
            {
                var prod = from c in context.Products
                               select c;

                if (!string.IsNullOrEmpty(inpBuscar))
                {
                    prod = prod.Where(c => c.ProductName.Contains(inpBuscar));
                }

                return prod.ToList();
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

        public void AgregarProducto(Products products)
        {
            try
            {
                int intIdt = context.Products.Max(u => u.ProductID);
                products.ProductID = intIdt + 1;

                context.Products.Add(products);
                context.SaveChanges();
            }
            catch
            {
                throw new ErrorGeneral();
            }
        }

        public void DeleteProducto(int id)
        {
            try
            {
                Products productoAeliminar = Productos(id);
                context.Products.Remove(productoAeliminar);
                context.SaveChanges();
            }
            catch
            {
                throw new ErrorGeneral();
            }

        }

        public void UpdateProducto(Products products)
        {
            try
            {
                Products prodAEditar = Productos(products.ProductID);

                prodAEditar.ProductName = products.ProductName;
                prodAEditar.UnitPrice   = products.UnitPrice;
                context.SaveChanges();
            }
            catch
            {
                throw new ErrorGeneral();
            }
        }
    }
}
