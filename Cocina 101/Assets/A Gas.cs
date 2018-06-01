using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class A_Gas : Artefactos_de_Preparacion
    {
        public string producto_a_gas { get; set; }

        public int Cocinar = 0;

        public void ProdA_Gas()
        {
            Debug.Log(producto_a_gas);
            
        }

        public A_Gas()
        {
            Debug.Log("Estufa");
            Debug.Log("Cocina");
            Debug.Log("");
        }
    }
}
