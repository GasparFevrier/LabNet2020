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
    public class RegionLogic : BaseLogic
    {

        public List<Region> Regions(string inpBuscar)
        {
            try
            {
                var regiones = from c in context.Region
                               select c;

                if (!string.IsNullOrEmpty(inpBuscar))
                {
                    regiones = regiones.Where(c => c.RegionDescription.Contains(inpBuscar));
                }

                return regiones.ToList();
            }
            catch
            {
                throw new ErrorGeneral();
            }

        }

        public Region Regions(int id)
        {
            try
            {
                return context.Region.FirstOrDefault(r => r.RegionID.Equals(id));
            }
            catch
            {
                throw new ErrorGeneral();
            }
        }


        public void AgregarRegion(Region region)
        {
            try
            {
                int intIdt = context.Region.Max(u => u.RegionID);
                region.RegionID = intIdt + 1;

                context.Region.Add(region);
                context.SaveChanges();
            }
            catch
            {
                throw new ErrorGeneral();
            }
        }

        public void UpdateRegion(Region region)
        {
            try
            {
                Region regionAEditar = Regions(region.RegionID);
                regionAEditar.RegionDescription = region.RegionDescription;
                context.SaveChanges();
            }
            catch
            {
                throw new ErrorGeneral();
            }
        }

        public void DeleteRegion(int id)
        {
            try
            {
                Region regionAeliminar = Regions(id);
                context.Region.Remove(regionAeliminar);
                context.SaveChanges();
            }
            catch
            {
                throw new ErrorGeneral();
            }

        }

        public List<TerritorioRegion> TerrRg()
        {
            try
            {
                return (from C in context.Territories
                        join O in context.Region on C.RegionID equals O.RegionID
                        orderby O.RegionID
                        select new TerritorioRegion
                        {
                            TerritoryDescription = C.TerritoryDescription,
                            RegionDescription = O.RegionDescription
                        }).ToList();
            }
            catch
            {
                throw new ErrorGeneral();
            }
        }

    }
}
