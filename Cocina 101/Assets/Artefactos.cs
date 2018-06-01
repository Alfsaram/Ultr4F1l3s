using UnityEngine;
using System;

namespace Alfonso_Sar
{
    class Artefactos
    {
        public string productoArtefactos { get; set; }

        string encendido;

        public bool Encendido = false;
        public float Cantidad = 0;
        public int Cant_Max = 6;

        public void ProdArtefactos()
        {
            Artefactos_de_Preparacion ArtPre = new Artefactos_de_Preparacion();
            ArtPre.ProdArtfacdePrepar();

            Console.ReadLine();
            Debug.ClearDeveloperConsole();

            Debug.Log("Usara encendida?? (Y/N)");
            encendido = Console.ReadLine();
            while (encendido != "Y" && encendido != "N")
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Disculpe??: Y/N");
                encendido = Console.ReadLine();
            }
            while (encendido == "N")
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Mejor no cocinemos.");
                Input.GetKey(KeyCode.Return);
                Environment.Exit(0);
            }
            if (encendido == "Y")
                Debug.Log("Genial, empezemos.");
                Encendido = true;
                Debug.ClearDeveloperConsole();

            Debug.Log("del 1 al 10, cuanto planea usar para cocinar??");
            Cant_Max = int.Parse(Console.ReadLine());
            if (Cant_Max < 10)
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Justo lo necesario");
                Input.GetKey(KeyCode.Return);
                Debug.ClearDeveloperConsole();
            }
            else
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("No, que va esto es demasiado, no se puede cocinar");
                Input.GetKey(KeyCode.Return);
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
