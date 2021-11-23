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
    public partial class FormClientes : Form
    {
        ClienteBL _clientes;

        public FormClientes()
        {
            InitializeComponent();


            _clientes = new ClienteBL();
            listaClientesBindingSource.DataSource = _clientes.ObtenerClientes();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea  eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var ObtenerClientes = Convert.ToInt32(nombreTextBox.Text);
                    Eliminar(ObtenerClientes);
                }
            }
        }

        private void Eliminar(int obtener)
        {

            var resultado = _clientes.EliminarCliente(obtener);

            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la pizza");
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _clientes.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClientesBindingSource.MoveLast();

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
            toolStripButton1.Visible = !valor;

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;


            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente Guardado con exito");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
