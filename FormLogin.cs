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
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;
        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();

            // CODIGO PARA  MOVER EL FORMULARIO DE LOGIN

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private const int cGrip = 16;      
        private const int cCaption = 32;   

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.White, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; 
                    return;
                }
            }
            base.WndProc(ref m);
        }

        // CODIGO DEL BOTON CERRAR
        private void CerrarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CODIGO DEL BOTON MINIMIZAR 
        private void MinimizarBoton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //CODIGO PARA EL INICIO DE SESION
        private void ButtonAcceder_Click(object sender, EventArgs e)
        {

            Login();

        }

        private void Login()
        {
            string usuario;
            string contraseña;

            usuario = TextBoxUsuario.Text;
            contraseña = TextBoxContra.Text;

            Application.DoEvents();
            var usuarioDB = _seguridad.Autorizar(usuario, contraseña);

            if (usuarioDB != null)
            {
                Program.UsuarioLogueado = usuarioDB;

                FormMenu llamar = new FormMenu();
                llamar.Show();
                this.Hide();



            }

            else
            {
                DialogResult error = new DialogResult();
                Form errormensaje = new MessageBoxLogin();

                error = errormensaje.ShowDialog();
            }
        }

        // CODIGO PARA DESBLOQUEAR BOTON
        private void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if ((TextBoxUsuario.Text != "") && (TextBoxContra.Text != ""))
            {
                ButtonAcceder.Enabled = true;
            }
            else
                ButtonAcceder.Enabled = false;

        }

        private void TextBoxContra_TextChanged(object sender, EventArgs e)
        {
            if ((TextBoxUsuario.Text != "") && (TextBoxContra.Text != ""))
            {
                ButtonAcceder.Enabled = true;
            }
            else
                ButtonAcceder.Enabled = false;

        }

        private void TextBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxUsuario.Text != "" && e.KeyChar == (char)Keys.Enter)
            {
                TextBoxContra.Focus();
            }
        }

        private void TextBoxContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxUsuario.Text != "" && TextBoxContra.Text
                != "" && e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
