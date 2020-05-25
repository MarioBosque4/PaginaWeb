using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaWeb
{
    public class Medidas
    {
        String id;
        int milimetro;
        DateTime fecha;

        public string Id { get => id; set => id = value; }
        public int Milimetro { get => milimetro; set => milimetro = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}