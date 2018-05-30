using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Para_Consumir : Utensilios
    {
        public string productoPara_Consumir { get; set; }

        public void ProdParaConsumir()
        {
            Console.WriteLine(productoPara_Consumir);
        }

        public Para_Consumir()
        {
            Console.WriteLine("Tenedor");
            Console.WriteLine("Cuchillo");
            Console.WriteLine("Cuchara");
        }

    }
}
