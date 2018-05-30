using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Vajilla : Utensilios
    {
        public string productoVajilla { get; set; }

        public void ProdVajilla()
        {
            Console.WriteLine(productoVajilla);
        }

        public Vajilla()
        {
            Console.WriteLine("Plato Hondo");
            Console.WriteLine("Plato Llano");
        }
    }
}
