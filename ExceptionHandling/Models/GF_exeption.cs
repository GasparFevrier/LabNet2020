using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceptionHandling.Models
{
    public class GF_exeption : Exception
    {
        public GF_exeption(string msg) : base(msg)
        {

        }

        public override string Message => "Este es el mensaje de GF_Exception: " + base.Message;        

    }
}