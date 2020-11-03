using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Capas.Entities;
using Lab.Capas.Logic;

namespace Lab.Capas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RegionLogic   regionLogic   = new RegionLogic();
            EmpleadoLogic empleadoLogic = new EmpleadoLogic();
            ProductLogic  productLogic  = new ProductLogic();

            void ShowRegions()
            {
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("LISTADO DE REGIONES\n");

                var regiones = regionLogic.Regions();
                foreach (var r in regiones)
                {
                    Console.WriteLine("ID:" + r.RegionID + "|" + " Descripcion: " + r.RegionDescription);
                }
                Console.WriteLine("\n--------------------------");
            }


            int entrada = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("****************************************");
                Console.WriteLine("*      CONSULTAS BD Northwind          *");
                Console.WriteLine("****************************************");
                Console.WriteLine("*  1. Registros de la tabla Region     *");
                Console.WriteLine("*  2. Buscar Region por Id             *");
                Console.WriteLine("*  3. Registros de la tabla Empleados  *");
                Console.WriteLine("*  4. Buscar Empleado por Id           *");
                Console.WriteLine("*  5. Registros de la tabla Productos  *");
                Console.WriteLine("*  6. Buscar Producto por Id           *");
                Console.WriteLine("*  7. Listar Territorios por Region    *");
                Console.WriteLine("*  8. Insertar una Region              *");
                Console.WriteLine("*  9. Actualizar una Region            *");
                Console.WriteLine("* 10. Eliminar una Region              *");
                Console.WriteLine("* 11. Salir                            *");
                Console.WriteLine("***************************************");
                Console.WriteLine("Seleccione Opción:");
                entrada = Convert.ToInt32(Console.ReadLine());                                           

            switch (entrada)
            {
                case 1:
                        try
                        {                                                  
                            ShowRegions();
                        }
                        catch (Exception ex) { 
                           Console.WriteLine(ex.Message);
                        }
                        break;

                case 2:
                        try
                        {
                            Console.WriteLine("Ingrese Id:");
                            int id = int.Parse(Console.ReadLine());

                            Console.WriteLine("LISTADO DE LA REGION:" + id);
                            Console.WriteLine("---------------------");
                            var region = regionLogic.Regions(id);
                            Console.WriteLine("Region: " + region.RegionID + " Descripcion: " + region.RegionDescription);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                case 3:
                        try
                        {
                            Console.WriteLine("LISTADO DE LA TABLA EMPLEADOS");
                            Console.WriteLine("-----------------------------");

                            var empleados = empleadoLogic.Empleados();
                            foreach (var r in empleados)
                            {
                                Console.WriteLine("ID:" + r.EmployeeID + "|" + " Nombre Completo: " + r.FirstName + ',' + r.LastName);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                case 4:
                        try
                        {
                            Console.WriteLine("Ingrese Empleado Id:");
                            int emp_id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Datos del Empleado:" + emp_id);
                            Console.WriteLine("-------------------");
                            var empleado = empleadoLogic.Empleado(emp_id);
                            Console.WriteLine("Id: " + empleado.EmployeeID + " Nombre Completo: " + empleado.FirstName + ',' + empleado.LastName);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                case 5:
                        try
                        {
                            Console.WriteLine("LISTADO DE LA TABLA PRODUCTOS");
                            Console.WriteLine("-----------------------------");

                            var productos = productLogic.Productos();
                            foreach (var r in productos)
                            {
                                Console.WriteLine("ID:" + r.ProductID + "|" + " Descripcion: " + r.ProductName);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                case 6:
                        try
                        {
                            Console.WriteLine("Ingrese Producto Id:");
                            int prod_id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Datos del Producto:" + prod_id);
                            Console.WriteLine("-------------------");
                            var producto = productLogic.Productos(prod_id);
                            Console.WriteLine("Id: " + producto.ProductID + " Descripcion: " + producto.ProductName);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                case 7:
                        try
                        {
                            Console.WriteLine("TERRITORIOS POR REGION");
                            Console.WriteLine("----------------------");

                            var territorioRg = regionLogic.TerrRg();
                            foreach (var r in territorioRg)
                            {
                                Console.WriteLine("Territorio:" + r.TerritoryDescription + "|" + " Region: " + r.RegionDescription);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                case 8:
                        try
                        {
                            Console.WriteLine("INSERTAR REGION");
                            var Rg = new Region();

                            Console.WriteLine("Ingrese Desc. de Region:");
                            string rgdesc = Console.ReadLine();

                            Rg.RegionDescription = rgdesc;
                            regionLogic.AgregarRegion(Rg);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;

                case 9:
                        try
                        {
                            Console.WriteLine("ACTUALIZAR REGION");
                            ShowRegions();

                            var rgNew = new Region();

                            Console.WriteLine("Ingrese Id a Actualizar:");
                            int Rgid = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese Nueva Desc. para la Region:");
                            string nuevadesc = Console.ReadLine();

                            rgNew.RegionID = Rgid;
                            rgNew.RegionDescription = nuevadesc;

                            regionLogic.UpdateRegion(rgNew);
                            ShowRegions();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;


                case 10:
                        try
                        {
                            Console.WriteLine("ELIMINAR REGION");
                            ShowRegions();

                            Console.WriteLine("Ingrese Id a para Eliminar:");
                            int RgidDelete = int.Parse(Console.ReadLine());

                            regionLogic.DeleteRegion(RgidDelete);

                            ShowRegions();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;


                case 11:
                        try
                        {
                            Console.WriteLine("Saliendo !!!");
                            Console.WriteLine("Gracias !!!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;


                default:
                        Console.WriteLine("Digite una opcion valida !!!");
                        break;

            } 
            Console.ReadKey();           

            } while (entrada != 11);
        }

    }
}
 