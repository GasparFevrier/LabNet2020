using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ExceptionHandling.Models
{
    public class Logic
    {

        public void method()
        {
            throw new FormatException();
            //throw new ArgumentException();
        }

        public void ThrowMyExcepcion()
        {
            throw new GF_exeption("!!!! BOOMMMMM !!!!");
        }

    }
}