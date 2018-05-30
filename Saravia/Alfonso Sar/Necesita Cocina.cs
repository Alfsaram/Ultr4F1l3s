using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Necesita_Cocina : Preparacion
    {
        public string productoNecesita_Cocina { get; set; }

        public int Cocinar;

        public void ProdNecesitaCocina()
        {
            Console.WriteLine(productoNecesita_Cocina);
        }

        public Necesita_Cocina()
        {
            Console.WriteLine("Sarten");
            Console.WriteLine("Estufas");
            Console.WriteLine("Olla");
            Console.WriteLine("");
        }
    }
}
