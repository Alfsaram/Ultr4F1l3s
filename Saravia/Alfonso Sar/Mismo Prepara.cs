using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Mismo_Prepara : Preparacion
    {
        public string productoMismo_Prepara { get; set; }

        public int Preparar;

        public void ProdMismoPrepara()
        {
            Console.WriteLine(productoMismo_Prepara);
        }

        public Mismo_Prepara()
        {
            Console.WriteLine("Colera");
            Console.WriteLine("Exprimidor de Naranjas");
            Console.WriteLine("Rayador de Queso");
            Console.WriteLine("Mortero");
            Console.WriteLine("Tabla para cortar");
        }
    }
}
