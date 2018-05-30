using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Artefactos_de_Preparacion : Artefactos
    {
        public string productoArtefactos_de_Preparacion{ get; set; }

        public void ProdArtfacdePrepar()
        {
            Console.WriteLine(productoArtefactos_de_Preparacion);

            A_Gas agas = new A_Gas();
            Electricos electr = new Electricos();

            agas.ProdA_Gas();
            electr.ProdElectricos();
        }
    }
}
