using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trafico
{
    public class taxi : transporte
    { public string destino { get; set; }
        public double distancia { get; set; }
        public double tiempo { get; set; }





        public double costo_total { get; set; }

        
        public double operar()
        {
            costo_total = distancia * tiempo;
            return costo_total; }

    } }
