using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte.Models
{
    public abstract class Vehiculo
    {
        private int Cant_pasajeros;

        public  Vehiculo(int pasajeros) {

            this.Cant_pasajeros = pasajeros;           
        }
                
        public int getPasajeros()
        {
            return Cant_pasajeros;
        }

        public virtual string Avanzar()
        {
            return "Transporte en marcha";
        }


        public virtual string Detenerse()
        {
            return "Transporte detenido";
        }

    }
}
