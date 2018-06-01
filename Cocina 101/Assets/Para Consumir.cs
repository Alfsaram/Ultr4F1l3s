using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Para_Consumir : Utensilios
    {
        public string productoPara_Consumir { get; set; }

        public bool Uso_de_Mano = false;

        public void ProdParaConsumir()
        {
            Debug.Log(productoPara_Consumir);
        }

        public Para_Consumir()
        {
            Debug.Log("Tenedor");
            Debug.Log("Cuchillo");
            Debug.Log("Cuchara");
        }

    }
}
