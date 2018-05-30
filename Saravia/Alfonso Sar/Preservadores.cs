using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Preservadores : Artefactos
    {
        public string productoPreservadores{ get; set; }

        public void ProdPreservador()
        {
            Console.WriteLine(productoPreservadores);
        }

        public Preservadores()
        {
            Console.WriteLine("Refrigeradora");
        }
    }
}
