using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Consumibles
    {
        public string productoConsumibles { get; set; }

        string calidad;

        public int Vencimiento;
        public float Peso;
        public bool Calidad = false;

        public void Ingredientes()
        {

            Alimentos Alimen = new Alimentos();
            Aderezos Aderez = new Aderezos();
            Condimentos Condim = new Condimentos();
            
            Alimen.ProdAlimentos();
            Aderez.ProdAderezos();
            Condim.ProdCondimentos();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Que año vence su() producto??");
            Vencimiento = int.Parse(Console.ReadLine());
            if(Vencimiento > 2018)
            {
                Console.Clear();
                Console.WriteLine("Felicidades, su comida no esta podrida");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No, que va eso esta podrido");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("Cuanto en kilos planea usar??");
            Peso = float.Parse(Console.ReadLine());
            if (Peso < 5)
            {
                Console.Clear();
                Console.WriteLine("Sera suficiente");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No, es demasiado para cocinar");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.WriteLine("Son de Calidad?? (Y/N)");
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
                Console.WriteLine("Genial, ahora a preparar.");
            Calidad = true;
            Console.Clear();
        }
    }
}
