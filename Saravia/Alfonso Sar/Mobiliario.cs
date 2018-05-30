using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Mobiliario
    {
        public string productoMobiliario { get; set; }

        public int Cant_Max = 10;
        public float Cantidad;

        public void ProdMobiliario()
        {
            Console.WriteLine(productoMobiliario);
        }

        public Mobiliario()
        {
            Console.WriteLine("Lavadora");
            Console.WriteLine("Chimenea");
            Console.ReadLine();
        }
    }
}
