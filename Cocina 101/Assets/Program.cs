using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Program : MonoBehaviour
    {
        void Start ()
        {
            string confirm;

            Consumibles Consum = new Consumibles();
            Utensilios Utens = new Utensilios();
            Artefactos Artfac = new Artefactos();
            Utensilios platos = new Utensilios();
            Utensilios tenedores = new Utensilios();

            bool phase1 = false;
            bool phase2 = false;
            bool phase3 = false;
            bool phase4 = false;
            bool phase5 = false;

            Debug.Log("Hola, Bienvenido a la Cocina");
            Debug.Log("");
            while (phase1 == false)
            {
                Debug.Log("Listo para cocinar?? (Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Input.GetKey(KeyCode.Return);
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                phase1 = true;
                Debug.ClearDeveloperConsole();
            }
            
            Debug.Log("Que planea usar como ingredientes??");
            Debug.Log("");
            Consum.Ingredientes();
            Debug.ClearDeveloperConsole();
            Debug.Log("Eso serian sus ingredientes, listo para Preparar??");
            Debug.Log("");
            while (phase2 == false)
            {
                Debug.Log("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Input.GetKey(KeyCode.Return);
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase2 = true;
                    Debug.ClearDeveloperConsole();
            }

            Debug.Log("Genial, Que materiales de cocina planea usar??");
            Debug.Log("");
            Utens.Materiales();
            Debug.ClearDeveloperConsole();
            Debug.Log("Muy bien, Donde planea preparar su plato??");
            Debug.Log("");
            Artfac.ProdArtefactos();
            Debug.ClearDeveloperConsole();
            Debug.Log("Seguro con lo que usara para prepara su plato??");
            Debug.Log("");
            while (phase3 == false)
            {
                Debug.Log("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Input.GetKey(KeyCode.Return);
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase3 = true;
                    Debug.ClearDeveloperConsole();
            }

            Debug.Log("Genial, usted a preparado su plato, donde desea servirlo??");
            Debug.Log("");
            platos.Platos();
            Debug.ClearDeveloperConsole();
            Debug.Log("Que planea usar para comer??");
            Debug.Log("");
            tenedores.Tenedores();
            Debug.ClearDeveloperConsole();
            Debug.Log("Se siente conforme con lo que va a usar para comer??");
            Debug.Log("");
            while (phase4 == false)
            {
                Debug.Log("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Input.GetKey(KeyCode.Return);
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase4 = true;
                Debug.ClearDeveloperConsole();
            }

            Debug.Log("Felicidades, donde desea dejar los restos??");
            Debug.Log("");
            Mobiliario mobil = new Mobiliario();
            mobil.ProdMobiliario();
            Debug.ClearDeveloperConsole();
            Debug.Log("Desea dejarlos ahí??");
            Debug.Log("");
            while (phase5 == false)
            {
                Debug.Log("(Y/N)");
                confirm = Console.ReadLine();
                while (confirm != "Y" && confirm != "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Disculpe??: Y/N");
                    confirm = Console.ReadLine();
                }
                while (confirm == "N")
                {
                    Debug.ClearDeveloperConsole();
                    Debug.Log("Entendido; que tenga buen día, presione cualquier tecla para salir.");
                    Input.GetKey(KeyCode.Return);
                    Environment.Exit(0);
                }
                if (confirm == "Y")
                    phase5 = true;
                Debug.ClearDeveloperConsole();
            }

            if (phase1 == true && phase2 == true && phase3 == true && phase4 == true && phase5 == true)
            {
                Debug.Log("Hecho, presione cualquier tecla para salir");
                Input.GetKey(KeyCode.Return);
            }
           
        }
    }
}
