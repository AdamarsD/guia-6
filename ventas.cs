using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static guia_6.Medicina;

namespace guia_6
{
    internal class ventas
    {
            public Cliente Cliente { get; set; }
            public List<Medicina> Medicamentos { get; set; }
            public decimal TotalVenta { get; set; }
        

    }
}
