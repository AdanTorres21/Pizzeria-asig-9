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
    public partial class FormFactura : Form
    {
        FacturaBL _facturaBL;
        ClienteBL _ClientesBL;
        NuestrasPizzasBL _nuestraspizzasBL;

        public FormFactura()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            listaFacturasBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _ClientesBL = new ClienteBL();
            listaClientesBindingSource.DataSource = _ClientesBL.ObtenerClientes();

            _nuestraspizzasBL = new NuestrasPizzasBL();
            ordenBindingSource.DataSource = _nuestraspizzasBL.Pedido();


        }

        private void impuestoLabel_Click(object sender, EventArgs e)
        {

        }

        private void impuestoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void subtotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaFacturasBindingSource.MoveLast();
        

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

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit();

            var factura = (Factura)listaFacturasBindingSource.Current;
            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturaBL.CancelarCambios();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Anular esta Factura?", "Anular", MessageBoxButtons.YesNo);
                if (resultado== DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }

        }

        private void Anular (int id)
        {
            var resultado = _facturaBL.AnularFactura(id);

            if (resultado == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la factura");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var factura = (Factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        

      

        private void facturaDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;

            if (factura != null && factura.Id !=0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void facturaDetalleDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facturaDetalleDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {

            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.CalcularFactura(factura);

            listaFacturasBindingSource.ResetBindings(false);
        }
    }
}
