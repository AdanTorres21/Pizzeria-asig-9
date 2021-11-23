using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class TipopizzaBL
    {
        Contexto _contexto;

        public BindingList<Tipopizzas> ListaTipospizzas { get; set; }

        public TipopizzaBL()
        {
            _contexto = new Contexto();
            ListaTipospizzas = new BindingList<Tipopizzas>();
        }

        public BindingList<Tipopizzas> ObtenerTipospizzas()
        {
            _contexto.TiposPizzas.Load();
            ListaTipospizzas = _contexto.TiposPizzas.Local.ToBindingList();

            return ListaTipospizzas;
        }
    }

       public class Tipopizzas 
         {

                public int Id { get; set; }
                public string Descripcion { get; set; }

            }
        

    }


