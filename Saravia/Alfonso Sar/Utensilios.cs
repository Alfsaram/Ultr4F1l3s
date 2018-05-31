using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Utensilios
    {
        public string productoUtensilios { get; set; }

        string calidad;

        public int Cant_Max = 10;
        public float Cantidad;
        public bool Calidad = false;

        public void Materiales()
        {
            Preparacion Prepar = new Preparacion();
            Prepar.ProdPreparacion();
        }

        public void Platos()
        {
            Vajilla vajilla = new Vajilla();
            vajilla.ProdVajilla();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Cuantos planea usar??");
            Cantidad = float.Parse(Console.ReadLine());
            if (Cantidad < 3)
            {
                Console.Clear();
                Console.WriteLine("Esperemos que lo disfrute");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No hay suficiente comida para todo esto");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void Tenedores()
        {
            Para_Consumir Consum = new Para_Consumir();
            Consum.ProdParaConsumir();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Y cuantos va a necesitar??");
            Cantidad = int.Parse(Console.ReadLine());
            if (Cantidad < 3)
            {
                Console.Clear();
                Console.WriteLine("Esperemos que lo disfrute");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No tenemos lo suficiente");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("Ambos son de Calidad?? (Y/N)");
            calidad = Console.ReadLine();
            while (calidad != "Y" && calidad != "N")
            {
                Console.Clear();
                Console.WriteLine("Disculpe??: Y/N");
                calidad = Console.ReadLine();
            }
            while (calidad == "N")
            {
                Console.Clear();
                Console.WriteLine("Mejor no los usemos.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (calidad == "Y")
                Console.WriteLine("Genial, a comer.");
            Calidad = true;
            Console.Clear();
        }
    }
}
