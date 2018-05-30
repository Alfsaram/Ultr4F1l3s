using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Utensilios
    {
        public string productoUtensilios { get; set; }

        public void Materiales()
        {
            Preparacion Prepar = new Preparacion();
            Prepar.ProdPreparacion();
        }

        public void Platos()
        {
            Vajilla vajilla = new Vajilla();
            vajilla.ProdVajilla();
        }

        public void Tenedores()
        {
            Para_Consumir Consum = new Para_Consumir();
            Consum.ProdParaConsumir();
        }
    }
}
