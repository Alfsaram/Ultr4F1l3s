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
            Console.WriteLine("Hola, Bienvenido a la Cocina");
            Console.WriteLine("Listo para cocinar?? (Y/N)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Que planea usar como ingredientes??");
            Console.WriteLine("");
            Consumibles Consum = new Consumibles();
            Consum.Ingredientes();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Genial, Que materiales de cocina planea usar??");
            Console.WriteLine("");
            Utensilios Utens = new Utensilios();
            Utens.Materiales();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Muy bien, Donde planea preparar su plato??");
            Console.WriteLine("");
            Artefactos Artfac = new Artefactos();
            Artfac.ProdArtefactos();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Genial, usted a preparado su plato, donde desea servirlo??");
            Console.WriteLine("");
            Utensilios platos = new Utensilios();
            platos.Platos();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Que planea usar para comer??");
            Console.WriteLine("");
            Utensilios tenedores = new Utensilios();
            platos.Tenedores();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Felicidades, donde desea dejar los restos??");
            Console.WriteLine("");
            Mobiliario Mobil = new Mobiliario();
            Mobil.ProdMobiliario();
            Artefactos refri = new Artefactos();
            refri.Refri();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hecho, presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
