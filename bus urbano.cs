using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafico
{
    public class bus_urbano:transporte
    {
        public string corredor {  get; set; }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine($"corredor: {corredor}");
      
        }
    }
}
