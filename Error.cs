﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace sintaxis3
{
    class Error: Exception
    {
        public Error()
        {

        }

        public Error(StreamWriter bitacora, string error) : base(error)
        {            
            //string mensaje = error + " linea " + linea + " caracter " + caracter;
            
            bitacora.WriteLine(error);            
        }
        
    }
}
