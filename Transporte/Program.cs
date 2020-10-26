using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Transporte.Models;

namespace Transporte
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Vehiculo> Lista_Vehiculos = new List<Vehiculo>();
            //List<DateTime> fechas          = new List<DateTime>();                       

            Lista_Vehiculos.Add(new Auto(4));
            Lista_Vehiculos.Add(new Auto(2));
            //Lista_Vehiculos.Add(new Auto(6));
            //Lista_Vehiculos.Add(new Auto(5));
            

            Lista_Vehiculos.Add(new Avion(100));
            Lista_Vehiculos.Add(new Avion(30));
            Lista_Vehiculos.Add(new Avion(10));
            //Lista_Vehiculos.Add(new Avion(60));
            //Lista_Vehiculos.Add(new Avion(300));

            /*fechas.Add(new DateTime(2020, 5, 5));
            fechas.Add(new DateTime());
            fechas.Add(new DateTime(2019,1,1,12,12,12)); 
            fechas.Add(new DateTime(2020, 3, 5));*/

            /*
            IEnumerable<Vehiculo> Lista_Vehiculos = new List<Vehiculo>()
            {
                new Auto(3),
                new Auto(13),
                new Auto(31),
                new Auto(34),
                new Auto(334),
                new Avion(133),
                new Avion(233),
                new Avion(343),
                new Avion(83),
                new Avion(99),
                new Auto(34),
                new Auto(34),
                new Auto(34),
           }; */

            foreach (var j in Lista_Vehiculos)
            {
                Console.WriteLine(j.Avanzar() + " - " + j.Detenerse() + " Cantidad de Pasajeros: " + j.getPasajeros());
            }

            /*foreach (var h in fechas)
            {
                Console.WriteLine(h);
            }*/

        }
    }
}
