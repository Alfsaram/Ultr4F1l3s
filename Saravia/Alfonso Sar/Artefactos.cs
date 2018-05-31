using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Artefactos
    {
        public string productoArtefactos { get; set; }

        string encendido;

        public bool Encendido = false;
        public float Cantidad;
        public int Cant_Max = 6;

        public void ProdArtefactos()
        {
            Artefactos_de_Preparacion ArtPre = new Artefactos_de_Preparacion();
            ArtPre.ProdArtfacdePrepar();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Usara encendida?? (Y/N)");
            encendido = Console.ReadLine();
            while (encendido != "Y" && encendido != "N")
            {
                Console.Clear();
                Console.WriteLine("Disculpe??: Y/N");
                encendido = Console.ReadLine();
            }
            while (encendido == "N")
            {
                Console.Clear();
                Console.WriteLine("Mejor no cocinemos.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (encendido == "Y")
                Console.WriteLine("Genial, empezemos.");
                Encendido = true;
                Console.Clear();

            Console.WriteLine("del 1 al 10, cuanto planea usar para cocinar??");
            Cant_Max = int.Parse(Console.ReadLine());
            if (Cant_Max < 10)
            {
                Console.Clear();
                Console.WriteLine("Justo lo necesario");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No, que va esto es demasiado, no se puede cocinar");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        public void Refri()
        {
            Preservadores Preser = new Preservadores();
            Preser.ProdPreservador();
        }
    }
}
