using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte.Models
{
    class Auto : Vehiculo
    {

        public Auto(int Cant_pasajeros) : base(Cant_pasajeros) {
        }

        public override string Avanzar()
        {
            return "Auto en marcha";
        }

        public override string Detenerse()
        {
            return "Auto detenido";
        }
    }
}
