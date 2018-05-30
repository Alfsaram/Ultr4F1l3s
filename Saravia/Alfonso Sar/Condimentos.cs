using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Condimentos : Consumibles
    {
        public string productoCondimentos { get; set; }

        public int Uso;

        public void ProdCondimentos()
        {
            Console.WriteLine(productoCondimentos);
        }
        
        public Condimentos()
        {
            Console.WriteLine("Ajo");
            Console.WriteLine("Pimienta");
            Console.WriteLine("Sal");
        }
    }
}
