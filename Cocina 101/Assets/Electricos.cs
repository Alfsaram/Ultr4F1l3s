using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Electricos : Artefactos_de_Preparacion
    {
        public string productoElectricos { get; set; }

        public int Calentar = 0;

        public void ProdElectricos()
        {
            Debug.Log(productoElectricos);
        }

        public Electricos()
        {
            Debug.Log("Arrocera");
            Debug.Log("Hornomicroondas");
            Debug.Log("Licuadora");
        }
    }
}
