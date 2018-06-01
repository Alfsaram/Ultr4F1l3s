using System;
using UnityEngine;

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
            Debug.Log(productoMobiliario);
        }

        public Mobiliario()
        {
            Debug.Log("Lavadora");
            Debug.Log("Chimenea");
            Console.ReadLine();

            Debug.Log("Cuantos planea guardar??");
            Cantidad = float.Parse(Console.ReadLine());
            if (Cantidad < 3)
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("Entonces ya acabamos");
                Input.GetKey(KeyCode.Return);
            }
            else
            {
                Debug.ClearDeveloperConsole();
                Debug.Log("No hay suficiente espacio para todo esto");
                Input.GetKey(KeyCode.Return);
                Environment.Exit(0);
            }
        }
    }
}
