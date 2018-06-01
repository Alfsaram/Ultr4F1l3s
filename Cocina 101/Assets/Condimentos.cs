using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Condimentos : Consumibles
    {
        public string productoCondimentos { get; set; }

        public int Uso = 0;

        public void ProdCondimentos()
        {
            Debug.Log(productoCondimentos);
        }
        
        public Condimentos()
        {
            Debug.Log("Ajo");
            Debug.Log("Pimienta");
            Debug.Log("Sal");
        }
    }
}
