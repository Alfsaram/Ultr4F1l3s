using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Preparacion : Utensilios
    {
        public string productoPreparacion { get; set; }

        public int Preparar;

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
