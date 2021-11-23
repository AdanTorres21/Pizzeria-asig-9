using BL.Pizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Pizzeria
{
    public partial class FormNuestrasPizzas : Form
    {
        NuestrasPizzasBL _nuestraspizzas;
        TipopizzaBL _tipopizzas;
        TipoBL _tipo;
        

        public FormNuestrasPizzas()
        {
            InitializeComponent();

            _nuestraspizzas = new NuestrasPizzasBL();
            ordenBindingSource.DataSource = _nuestraspizzas.Pedido();

            _tipopizzas = new TipopizzaBL();
            listaTipospizzasBindingSource.DataSource = _tipopizzas.ObtenerTipospizzas();

            _tipo = new TipoBL();
            listaTiposBindingSource.DataSource = _tipo.ObtenerTipos();


        }

        private void ordenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ordenBindingSource.EndEdit();
            var nuestraspizzas = (NuestrasPizzas) ordenBindingSource.Current;

            if(fotoPictureBox.Image != null)
            {
                nuestraspizzas.Foto = Program.imageToByteArray(fotoPictureBox.Image);     
            }
            else
            {
                nuestraspizzas.Foto = null; 
            }

            

            var resultado = _nuestraspizzas.GuardarNuestrasPizzas(nuestraspizzas);

            if ( resultado.Exitoso == true)
            {
                ordenBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Pedido Guardado con exito");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _nuestraspizzas.AgregarNuestrasPizzas();
            ordenBindingSource.MoveLast();

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
            toolStripButtonCancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (pedidoTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea  eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var pedido = Convert.ToInt32(pedidoTextBox.Text);
                    Eliminar(pedido);
                }
            }
        }

        private void Eliminar(int pedido)
        {
            
            var resultado = _nuestraspizzas.EliminarNuestrasPizzas(pedido);

            if (resultado == true)
            {
                ordenBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la pizza");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _nuestraspizzas.CancelarCambios();
            DeshabilitarHabilitarBotones(true);

            
        }

        private void pedidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuestraspizzas = (NuestrasPizzas)ordenBindingSource.Current;

            if (nuestraspizzas != null)
             {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var Fileinfo = new FileInfo(archivo);
                    var FileStream = Fileinfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(FileStream);

                }
            }
            else
            {
                MessageBox.Show("Cree un producto antes de asignarle una imagen");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNuestrasPizzas_Load(object sender, EventArgs e)
        {

        }

        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscar = textBox1.Text;

            if (buscar != "")
            {
                ordenBindingSource.DataSource = _nuestraspizzas.Pedido(buscar);  
            }
            else
            {
                ordenBindingSource.ResetBindings(false);
            }
        }
    }
}
