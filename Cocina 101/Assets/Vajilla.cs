using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Vajilla : Utensilios
    {
        public string productoVajilla { get; set; }

        public bool Contenido = false;

        public void ProdVajilla()
        {
            Debug.Log(productoVajilla);
        }

        public Vajilla()
        {
            Debug.Log("Plato Hondo");
            Debug.Log("Plato Llano");
        }
    }
}
