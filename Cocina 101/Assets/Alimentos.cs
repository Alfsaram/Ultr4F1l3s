using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Alimentos : Consumibles
    {
        public string productoAlimentos { get; set; }

        public string Marca = null;

        public void ProdAlimentos()
        {
            Debug.Log(productoAlimentos);
        }

        public Alimentos()
        {
            Debug.Log("Arroz");
            Debug.Log("Huevo");
            Debug.Log("Limon");
            Debug.Log("Carne");
            Debug.Log("Queso");
            Debug.Log("");
        }



    }
}
