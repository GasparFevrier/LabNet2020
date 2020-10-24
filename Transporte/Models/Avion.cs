using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte.Models
{
    class Avion : Vehiculo
    {

        public Avion(int Cant_pasajeros) : base(Cant_pasajeros) {
        }

        public override string Avanzar() 
        {
            return "Avion en marcha";
        }


        public override string Detenerse()
        {
            return "Avion detenido";
        }

    }
}
