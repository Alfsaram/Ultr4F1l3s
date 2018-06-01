using System;
using UnityEngine;

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
            Debug.ClearDeveloperConsole();

            Debug.Log("Que año vence su() producto??");
            Vencimiento = int.Parse(Console.ReadLine());
            if(Vencimiento > 2018)
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Felicidades, su comida no esta podrida");
                Input.GetKey(KeyCode.Return);
                Debug.ClearDeveloperConsole();
            }
            else
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("No, que va eso esta podrido");
                Input.GetKey(KeyCode.Return);
                Environment.Exit(0);
            }

            Debug.Log("Cuanto en kilos planea usar??");
            Peso = float.Parse(Console.ReadLine());
            if (Peso < 5)
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Sera suficiente");
                Input.GetKey(KeyCode.Return);
            }
            else
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("No, es demasiado para cocinar");
                Input.GetKey(KeyCode.Return);
                Environment.Exit(0);
            }

            Debug.Log("Son de Calidad?? (Y/N)");
            calidad = Console.ReadLine();
            while (calidad != "Y" && calidad != "N")
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Disculpe??: Y/N");
                calidad = Console.ReadLine();
            }
            while (calidad == "N")
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Mejor no los usemos.");
                Input.GetKey(KeyCode.Return);
                Environment.Exit(0);
            }
            if (calidad == "Y")
                Debug.Log("Genial, ahora a preparar.");
                Input.GetKey(KeyCode.Return);
                Calidad = true;
                Debug.ClearDeveloperConsole();
        }
    }
}
