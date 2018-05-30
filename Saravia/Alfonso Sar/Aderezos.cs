using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Aderezos : Consumibles
    {
        public string productoAderezos { get; set; }

        public bool Uso;

        public void ProdAderezos()
        {
            Uso = false;
            Console.WriteLine(productoAderezos);
        }
        public Aderezos()
        {
            Console.WriteLine("Aceite");
            Console.WriteLine("Harina para cocinar");
            Console.WriteLine("Mayonesa");
            Console.WriteLine("");
        }


    }
}
