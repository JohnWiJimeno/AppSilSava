using System;
using System.Collections.Generic;
using System.Text;

namespace AppSilSava.DTO.Response.Generic
{
    public class RepuestaBase
    {
        public bool Exito { get; set; } = false;
        public string Mensaje { get; set; } = "";
    }
    public class RepuestaBase<T>: RepuestaBase
    {
        public T Data { get; set; }= default!;
    }
}

