using System;
using UnityEngine;

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
            Debug.ClearDeveloperConsole();
            Debug.Log("Cuantos planea usar??");
            Cantidad = float.Parse(Console.ReadLine());
            if (Cantidad < 3)
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Esperemos que lo disfrute");
                Input.GetKey(KeyCode.Return);
            }
            else
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("No hay suficiente comida para todo esto");
                Input.GetKey(KeyCode.Return);
                Environment.Exit(0);
            }
        }

        public void Tenedores()
        {
            Para_Consumir Consum = new Para_Consumir();
            Consum.ProdParaConsumir();
            Console.ReadLine();
            Debug.ClearDeveloperConsole();

            Debug.Log("Y cuantos va a necesitar??");
            Cantidad = int.Parse(Console.ReadLine());
            if (Cantidad < 3)
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Esperemos que lo disfrute");
                Input.GetKey(KeyCode.Return);
            }
            else
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("No tenemos lo suficiente");
                Input.GetKey(KeyCode.Return);
                Environment.Exit(0);
            }

            Debug.Log("Ambos son de Calidad?? (Y/N)");
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
                Debug.Log("Genial, a comer.");
            Calidad = true;
            Debug.ClearDeveloperConsole();
        }
    }
}
