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
            RegionLogic regionLogic = new RegionLogic();

            int entrada = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("*******CONSULTAS BD NORTWIND**********\n\n");
                Console.WriteLine("Seleccione una opción\n");
                Console.WriteLine("1. Registros de la tabla Region\n");
                Console.WriteLine("2. Region por Id\n");
                Console.WriteLine("3. Registros de la tabla Empleados\n");
                Console.WriteLine("4. Empleados por Id\n");
                Console.WriteLine("5. Registros de la tabla Productos\n");
                Console.WriteLine("6. Productos Por Id\n");
                Console.WriteLine("7. Territorios por Region\n");
                Console.WriteLine("8. Insertar Region\n");
                Console.WriteLine("Opción:");
                entrada = Convert.ToInt32(Console.ReadLine());                                           

            switch (entrada)
            {
                case 1:                    
                    Console.WriteLine("LISTADO DE LA TABLA REGION");
                    Console.WriteLine("--------------------------");

                    var regiones = regionLogic.Regions();
                    foreach (var r in regiones)
                    {
                        Console.WriteLine("ID:" + r.RegionID + "|" + " Descripcion: " + r.RegionDescription);
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese Id:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("LISTADO DE LA REGION:" + id);
                    Console.WriteLine("---------------------");
                    var region = regionLogic.Regions(id);
                    Console.WriteLine("Region: " + region.RegionID + " Descripcion: " + region.RegionDescription);                    
                    break;

                case 3:
                    Console.WriteLine("LISTADO DE LA TABLA EMPLEADOS");
                    Console.WriteLine("-----------------------------");

                    var empleados = regionLogic.Empleados();
                    foreach (var r in empleados)
                    {
                        Console.WriteLine("ID:" + r.EmployeeID + "|" + " Nombre Completo: " + r.FirstName +','+ r.LastName);
                    }
                    break;

                case 4:
                    Console.WriteLine("Ingrese Empleado Id:");
                    int emp_id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Datos del Empleado:" + emp_id);
                    Console.WriteLine("-------------------");
                    var empleado = regionLogic.Empleado(emp_id);
                    Console.WriteLine("Id: " + empleado.EmployeeID + " Nombre Completo: " + empleado.FirstName + ',' + empleado.LastName);
                    break;

                case 5:
                    Console.WriteLine("LISTADO DE LA TABLA PRODUCTOS");
                    Console.WriteLine("-----------------------------");

                    var productos = regionLogic.Productos();
                    foreach (var r in productos)
                    {
                        Console.WriteLine("ID:" + r.ProductID + "|" + " Descripcion: " + r.ProductName);
                    }
                    break;

                case 6:
                    Console.WriteLine("Ingrese Producto Id:");
                    int prod_id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Datos del Producto:" + prod_id);
                    Console.WriteLine("-------------------");
                    var producto = regionLogic.Productos(prod_id);
                    Console.WriteLine("Id: " + producto.ProductID + " Descripcion: " + producto.ProductName);
                    break;

                case 7:
                    Console.WriteLine("TERRITORIOS POR REGION");
                    Console.WriteLine("----------------------");
                    var territorioRg = regionLogic.TerrRg();
                    foreach (var r in territorioRg)
                    {
                        Console.WriteLine("Territorio:" + r.TerritoryDescription + "|" + " Region: " + r.RegionDescription);
                    }                    
                    break;

                case 8:
                    var Rg = new Region();                                       
                    Console.WriteLine("Ingrese Desc. de Region:");
                    string rgdesc = Console.ReadLine();
                    Rg.RegionDescription = rgdesc;

                    regionLogic.AgregarRegion(Rg);
                    break;

                case 9:
                Console.WriteLine("Saliendo !!!");                    
                break;

                default:
                Console.WriteLine("Digite una opcion valida !!!");
                break;

            }
            Console.ReadKey();           

            } while (entrada != 9);
        }
    }
}
 