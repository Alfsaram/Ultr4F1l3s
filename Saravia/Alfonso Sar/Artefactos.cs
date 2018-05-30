using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Artefactos
    {
        public string productoArtefactos { get; set; }

        public void ProdArtefactos()
        {
            Artefactos_de_Preparacion ArtPre = new Artefactos_de_Preparacion();
            ArtPre.ProdArtfacdePrepar();
        }

        public void Refri()
        {
            Preservadores Preser = new Preservadores();
            Preser.ProdPreservador();
        }
    }
}
