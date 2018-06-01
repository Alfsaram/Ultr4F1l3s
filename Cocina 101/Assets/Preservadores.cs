using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Preservadores : Artefactos
    {
        public string productoPreservadores{ get; set; }

        public int Preservardor = 0;

        public void ProdPreservador()
        {
            Debug.Log(productoPreservadores);
        }

        public Preservadores()
        {
            Debug.Log("Refrigeradora");
        }
    }
}
