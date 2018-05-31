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

        string cantidad;

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

            Console.WriteLine("Cuantos planea guardar??");
            Cantidad = float.Parse(Console.ReadLine());
            if (Cantidad < 3)
            {
                Console.Clear();
                Console.WriteLine("Entonces ya acabamos");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No hay suficiente espacio para todo esto");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
