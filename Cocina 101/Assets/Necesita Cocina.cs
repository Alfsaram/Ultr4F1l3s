using System;
using UnityEngine;
namespace Alfonso_Sar
{
    class Necesita_Cocina : Preparacion
    {
        public string productoNecesita_Cocina { get; set; }

        public int Cocinar = 0;

        public void ProdNecesitaCocina()
        {
            Debug.Log(productoNecesita_Cocina);
        }

        public Necesita_Cocina()
        {
            Debug.Log("Sarten");
            Debug.Log("Estufas");
            Debug.Log("Olla");
            Debug.Log("");
        }
    }
}
