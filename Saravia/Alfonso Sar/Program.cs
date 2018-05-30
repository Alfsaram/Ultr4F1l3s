using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Program
    {
        static void Main(string[] args)
        {
            string confirm;

            Consumibles Consum = new Consumibles();
            Utensilios Utens = new Utensilios();
            Artefactos Artfac = new Artefactos();
            Utensilios platos = new Utensilios();
            Utensilios tenedores = new Utensilios();
            Mobiliario mobil = new Mobiliario();

            bool phase1 = false;
            bool phase2 = false;
            bool phase3 = false;
            bool phase4 = false;
            bool phase5 = false;

            Console.WriteLine("Hola, Bienvenido a la Cocina");
            Console.WriteLine("");
            while (phase1 == false)
            {
                Console.WriteLine("Listo para cocinar?? (Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Console.Clear();
                    Console.WriteLine("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                phase1 = true;
                Console.Clear();
            }
            
            Console.WriteLine("Que planea usar como ingredientes??");
            Console.WriteLine("");
            Consum.Ingredientes();
            Console.Clear();
            Console.WriteLine("Estos serian sus ingredientes, listo para Preparar??");
            Console.WriteLine("");
            while (phase2 == false)
            {
                Console.WriteLine("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Console.Clear();
                    Console.WriteLine("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase2 = true;
                Console.Clear();
            }

            Console.WriteLine("Genial, Que materiales de cocina planea usar??");
            Console.WriteLine("");
            Utens.Materiales();
            Console.Clear();
            Console.WriteLine("Muy bien, Donde planea preparar su plato??");
            Console.WriteLine("");
            Artfac.ProdArtefactos();
            Console.Clear();
            Console.WriteLine("Seguro con lo que usara para prepara su plato??");
            Console.WriteLine("");
            while (phase3 == false)
            {
                Console.WriteLine("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Console.Clear();
                    Console.WriteLine("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase3 = true;
                Console.Clear();
            }

            Console.WriteLine("Genial, usted a preparado su plato, donde desea servirlo??");
            Console.WriteLine("");
            platos.Platos();
            Console.Clear();
            Console.WriteLine("Que planea usar para comer??");
            Console.WriteLine("");
            platos.Tenedores();
            Console.Clear();
            Console.WriteLine("Se siente conforme con lo que va a usar para comer??");
            Console.WriteLine("");
            while (phase4 == false)
            {
                Console.WriteLine("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Console.Clear();
                    Console.WriteLine("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase4 = true;
                Console.Clear();
            }

            Console.WriteLine("Felicidades, donde desea dejar los restos??");
            Console.WriteLine("");
            mobil.ProdMobiliario();
            Console.Clear();
            Console.WriteLine("Desea dejarlos ahí??");
            Console.WriteLine("");
            while (phase5 == false)
            {
                Console.WriteLine("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Console.Clear();
                    Console.WriteLine("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase5 = true;
                Console.Clear();
            }

            if (phase1 == true && phase2 == true && phase3 == true && phase4 == true && phase5 == true)
            {
                Console.WriteLine("Hecho, presione cualquier tecla para salir");
                Console.ReadKey();
            }
           
        }
    }
}
