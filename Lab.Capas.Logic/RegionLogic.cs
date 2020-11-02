using Lab.Capas.Entities;
using Lab.Capas.RerourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Capas.Logic
{
    public class RegionLogic
    {
        private readonly NortwindContext context;

        public RegionLogic()
        {
            this.context = new NortwindContext();
        }

        public List<Region> Regions()
        {
            return context.Region.ToList();         
        }

        public Region Regions(int id)
        {
            return context.Region.FirstOrDefault(r => r.RegionID.Equals(id));          
        }

        public void AgregarRegion(Region region)
        {

            int intIdt = context.Region.Max(u => u.RegionID);
            region.RegionID = intIdt + 1;

            context.Region.Add(region);
            context.SaveChanges();
        }


        public List<Employees> Empleados()
        {
            return context.Employees.ToList();
        }

        public Employees Empleado(int id)
        {
            return context.Employees.FirstOrDefault(r => r.EmployeeID.Equals(id));
        }

        public List<Products> Productos()
        {
            return context.Products.ToList();
        }

        public Products Productos(int id)
        {
            return context.Products.FirstOrDefault(r => r.ProductID.Equals(id));
        }


        public List<TerritorioRegion> TerrRg()
        { 

           return  (from C in context.Territories
             join O in context.Region on C.RegionID equals O.RegionID
             orderby O.RegionID
             select new TerritorioRegion             
             {TerritoryDescription = C.TerritoryDescription, 
              RegionDescription    = O.RegionDescription}).ToList();

        }


    }
}
