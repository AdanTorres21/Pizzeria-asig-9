using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    
        public class NuestrasPizzasBL
        {
            Contexto _contexto;
            public BindingList<NuestrasPizzas> Orden { get; set; }

            public NuestrasPizzasBL()
            {
                _contexto = new Contexto();
                Orden = new BindingList<NuestrasPizzas>();
            }

            public BindingList<NuestrasPizzas> Pedido()
            {
                _contexto.Nuestrapizzas.Load();
                Orden = _contexto.Nuestrapizzas.Local.ToBindingList();

                return Orden;
            }

        public BindingList<NuestrasPizzas> Pedido(string buscar)
        {

            var resultado = _contexto.Nuestrapizzas.Where(r => r.Descripcion.Contains(buscar));

            return new BindingList<NuestrasPizzas> (resultado.ToList());
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }

        }

            public Resultado GuardarNuestrasPizzas(NuestrasPizzas nuestraspizzas)
        {
            var resultado = validar(nuestraspizzas);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarNuestrasPizzas()
        {
            var nuevaPizza = new NuestrasPizzas();
            Orden.Add(nuevaPizza);
        } 

        public bool EliminarNuestrasPizzas(int pedido)
        {
            foreach (var nuestraspizzas in Orden)
            {
                if (nuestraspizzas.pedido == pedido)
                {
                    Orden.Remove(nuestraspizzas);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado validar(NuestrasPizzas nuestraspizzas)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (nuestraspizzas == null)
            {
                resultado.Mensaje = "Agruegue una Pizza";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(nuestraspizzas.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una Descripcion";
                resultado.Exitoso = false;
            }


            if (nuestraspizzas.Precio < 0)
            {
                resultado.Mensaje = "El Precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (nuestraspizzas.TipopizzaId == 0 )
            {
                resultado.Mensaje = "Seleccione un tipo de pizza";
                resultado.Exitoso = false;
            }


            if (nuestraspizzas.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un tamaño de pizza";
                resultado.Exitoso = false;
            }

            if (nuestraspizzas.exitencia== 0)
            {
                resultado.Mensaje = "Seleccione la cantidad de pizza que hay en exitencia";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }


    public class NuestrasPizzas
    {

        public int Id { get; set; }
        public int pedido { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int TipopizzaId { get; set; }
        public Tipopizzas tipopizza { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public int exitencia { get; set; }
        public bool Disponible { get; set; }
        public byte[] Foto { get; set; }



        public NuestrasPizzas()
        {
            Disponible = true;
        }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
