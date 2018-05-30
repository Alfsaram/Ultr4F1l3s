using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Electricos : Artefactos_de_Preparacion
    {
        public string productoElectricos { get; set; }

        public int Calentar;

        public void ProdElectricos()
        {
            Console.WriteLine(productoElectricos);
        }

        public Electricos()
        {
            Console.WriteLine("Arrocera");
            Console.WriteLine("Hornomicroondas");
            Console.WriteLine("Licuadora");
        }
    }
}
