using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
   public  class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var UsarioAdmin = new Usuario();
            UsarioAdmin.nombre = "admin";
            UsarioAdmin.Contrasena = "123";
            UsarioAdmin.TipoUsuario = "Administradores";

            contexto.Usuarios.Add(UsarioAdmin);

            var tipopizza1 = new Tipopizzas();
            tipopizza1.Descripcion = "Prosciutto";
            contexto.TiposPizzas.Add(tipopizza1);

            var tipopizza2 = new Tipopizzas();
            tipopizza2.Descripcion = "Setas";
            contexto.TiposPizzas.Add(tipopizza2);

            var tipopizza3 = new Tipopizzas();
            tipopizza3.Descripcion = "4 Quesos";
            contexto.TiposPizzas.Add(tipopizza3);

            var tipopizza4 = new Tipopizzas();
            tipopizza4.Descripcion = "Calabresa";
            contexto.TiposPizzas.Add(tipopizza4);

            var tipo5 = new Tipopizzas();
            tipo5.Descripcion = "4 Estaciones";
            contexto.TiposPizzas.Add(tipo5);

            var tipopizza6 = new Tipopizzas();
            tipopizza6.Descripcion = "Napolitana";
            contexto.TiposPizzas.Add(tipopizza6);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Pequeña";
            contexto.Tipos.Add(tipo1);

            var tipo2= new Tipo();
            tipo2.Descripcion = "Normal";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Familiar";
            contexto.Tipos.Add(tipo3);

            base.Seed(contexto);


        }

    }
}
