using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Preparacion : Utensilios
    {
        public string productoPreparacion { get; set; }

        public int Preparar = 0;

        public void ProdPreparacion()
        {
            Console.WriteLine(productoPreparacion);

            Necesita_Cocina cocina = new Necesita_Cocina();
            Mismo_Prepara mismo = new Mismo_Prepara();

            cocina.ProdNecesitaCocina();
            mismo.ProdMismoPrepara();
        }
    }
}
