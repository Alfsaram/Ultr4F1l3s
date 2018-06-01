using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Mismo_Prepara : Preparacion
    {
        public string productoMismo_Prepara { get; set; }

        public void ProdMismoPrepara()
        {
            Debug.Log(productoMismo_Prepara);
        }

        public Mismo_Prepara()
        {
            Debug.Log("Colera");
            Debug.Log("Exprimidor de Naranjas");
            Debug.Log("Rayador de Queso");
            Debug.Log("Mortero");
            Debug.Log("Tabla para cortar");
        }
    }
}
