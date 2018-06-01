using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Aderezos : Consumibles
    {
        public string productoAderezos { get; set; }

        public bool Uso = false;

        public void ProdAderezos()
        {
            Uso = false;
            Debug.Log(productoAderezos);
        }
        public Aderezos()
        {
            Debug.Log("Aceite");
            Debug.Log("Harina para cocinar");
            Debug.Log("Mayonesa");
            Debug.Log("");
        }


    }
}
