using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafico
{
    public class transporte

    {
        public double costo { get; set; }

        public virtual void ImprimirDatos()
        {
            Console.WriteLine($"costo: {costo}");
        }
    }
}
