using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Alimentos : Consumibles
    {
        public string productoAlimentos { get; set; }

        public string Marca;

        public void ProdAlimentos()
        {
            Console.WriteLine(productoAlimentos);
        }

        public Alimentos()
        {
            Console.WriteLine("Arroz");
            Console.WriteLine("Huevo");
            Console.WriteLine("Limon");
            Console.WriteLine("Carne");
            Console.WriteLine("Queso");
            Console.WriteLine("");
        }



    }
}
