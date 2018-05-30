using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfonso_Sar
{
    class Consumibles
    {
        public string productoConsumibles { get; set; }


        public void Ingredientes()
        {
            Alimentos Alimen = new Alimentos();
            Aderezos Aderez = new Aderezos();
            Condimentos Condim = new Condimentos();
            
            Alimen.ProdAlimentos();
            Aderez.ProdAderezos();
            Condim.ProdCondimentos();
       
        }
    }
}
