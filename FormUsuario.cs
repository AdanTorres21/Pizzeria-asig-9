using BL.Pizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Pizzeria
{
    public partial class FormUsuario : Form

    {
        SeguridadBL _usuario;

        public FormUsuario()
        {
            InitializeComponent();


            _usuario = new SeguridadBL();
            listaUsuariosBindingSource.DataSource = _usuario.ObtenerUsuario();
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea  eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }

        }

        private void Eliminar(int id)
        {

            var resultado = _usuario.EliminarUsuario(id);

            if (resultado == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Usuario");
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _usuario.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);

           
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripCancelar.Visible = !valor;

        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _usuario.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void listaUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaUsuariosBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            var resultado = _usuario.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

    }
}

