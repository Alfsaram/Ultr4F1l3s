using System;
using UnityEngine;

namespace Alfonso_Sar
{
    class Artefactos_de_Preparacion : Artefactos
    {
        public string productoArtefactos_de_Preparacion{ get; set; }

        public void ProdArtfacdePrepar()
        {
            Debug.Log(productoArtefactos_de_Preparacion);

            A_Gas agas = new A_Gas();
            Electricos electr = new Electricos();

            agas.ProdA_Gas();
            electr.ProdElectricos();
        }
    }
}
