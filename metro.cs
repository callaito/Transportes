using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafico
{
    public class metro:transporte
    {
        public string compañia { get; set; }
        public string linea { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"compañia: {compañia}");
            Console.WriteLine($"linea: {linea}");
        }
    }
}
