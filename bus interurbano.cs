using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafico
{
    public class bus_interurbano:transporte
    {
        public string destino {  get; set; }
        public string compañia { get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"destino: {destino}");
            Console.WriteLine($"compañia: {compañia}");
        }
    }
}
