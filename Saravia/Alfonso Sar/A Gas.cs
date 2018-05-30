using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class A_Gas : Artefactos_de_Preparacion
    {
        public string producto_a_gas { get; set; }

        public void ProdA_Gas()
        {
            Console.WriteLine(producto_a_gas);
            
        }

        public A_Gas()
        {
            Console.WriteLine("Estufa");
            Console.WriteLine("Cocina");
            Console.WriteLine("");
        }
    }
}
