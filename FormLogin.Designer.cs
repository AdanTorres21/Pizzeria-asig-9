namespace Win.Pizzeria
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CerrarBoton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizarBoton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.TextBoxUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxContra = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonAcceder = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBoton
            // 
            this.CerrarBoton.Animated = true;
            this.CerrarBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CerrarBoton.CheckedState.Parent = this.CerrarBoton;
            this.CerrarBoton.CustomImages.Parent = this.CerrarBoton;
            this.CerrarBoton.FillColor = System.Drawing.Color.PapayaWhip;
            this.CerrarBoton.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarBoton.ForeColor = System.Drawing.Color.Black;
            this.CerrarBoton.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.CerrarBoton.HoverState.ForeColor = System.Drawing.Color.White;
            this.CerrarBoton.HoverState.Parent = this.CerrarBoton;
            this.CerrarBoton.Location = new System.Drawing.Point(1123, -2);
            this.CerrarBoton.Name = "CerrarBoton";
            this.CerrarBoton.ShadowDecoration.Parent = this.CerrarBoton;
            this.CerrarBoton.Size = new System.Drawing.Size(48, 43);
            this.CerrarBoton.TabIndex = 1;
            this.CerrarBoton.Text = "×";
            this.CerrarBoton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.CerrarBoton.Click += new System.EventHandler(this.CerrarBoton_Click);
            // 
            // MinimizarBoton
            // 
            this.MinimizarBoton.Animated = true;
            this.MinimizarBoton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizarBoton.CheckedState.Parent = this.MinimizarBoton;
            this.MinimizarBoton.CustomImages.Parent = this.MinimizarBoton;
            this.MinimizarBoton.FillColor = System.Drawing.Color.PapayaWhip;
            this.MinimizarBoton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizarBoton.ForeColor = System.Drawing.Color.Black;
            this.MinimizarBoton.HoverState.FillColor = System.Drawing.Color.Gray;
            this.MinimizarBoton.HoverState.ForeColor = System.Drawing.Color.White;
            this.MinimizarBoton.HoverState.Parent = this.MinimizarBoton;
            this.MinimizarBoton.Location = new System.Drawing.Point(1085, -1);
            this.MinimizarBoton.Name = "MinimizarBoton";
            this.MinimizarBoton.ShadowDecoration.Parent = this.MinimizarBoton;
            this.MinimizarBoton.Size = new System.Drawing.Size(44, 43);
            this.MinimizarBoton.TabIndex = 2;
            this.MinimizarBoton.Text = "─";
            this.MinimizarBoton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.MinimizarBoton.Click += new System.EventHandler(this.MinimizarBoton_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::Win.Pizzeria.Properties.Resources.Logo;
            this.pictureLogo.Location = new System.Drawing.Point(144, 108);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(123, 123);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 3;
            this.pictureLogo.TabStop = false;
            // 
            // pictureLogin
            // 
            this.pictureLogin.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureLogin.Image = global::Win.Pizzeria.Properties.Resources.Login;
            this.pictureLogin.Location = new System.Drawing.Point(389, -1);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(782, 667);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 0;
            this.pictureLogin.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(143, 251);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(109, 29);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Ingresar";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.TextBoxUsuario.BorderRadius = 10;
            this.TextBoxUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsuario.DefaultText = "";
            this.TextBoxUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsuario.DisabledState.Parent = this.TextBoxUsuario;
            this.TextBoxUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUsuario.FocusedState.Parent = this.TextBoxUsuario;
            this.TextBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUsuario.HoverState.Parent = this.TextBoxUsuario;
            this.TextBoxUsuario.Location = new System.Drawing.Point(73, 313);
            this.TextBoxUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.PasswordChar = '\0';
            this.TextBoxUsuario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBoxUsuario.PlaceholderText = "USUARIO";
            this.TextBoxUsuario.SelectedText = "";
            this.TextBoxUsuario.ShadowDecoration.Parent = this.TextBoxUsuario;
            this.TextBoxUsuario.Size = new System.Drawing.Size(245, 36);
            this.TextBoxUsuario.TabIndex = 5;
            this.TextBoxUsuario.TextChanged += new System.EventHandler(this.TextBoxUsuario_TextChanged);
            this.TextBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsuario_KeyPress);
            // 
            // TextBoxContra
            // 
            this.TextBoxContra.BorderColor = System.Drawing.Color.DimGray;
            this.TextBoxContra.BorderRadius = 10;
            this.TextBoxContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxContra.DefaultText = "";
            this.TextBoxContra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxContra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxContra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxContra.DisabledState.Parent = this.TextBoxContra;
            this.TextBoxContra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxContra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxContra.FocusedState.Parent = this.TextBoxContra;
            this.TextBoxContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxContra.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxContra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxContra.HoverState.Parent = this.TextBoxContra;
            this.TextBoxContra.Location = new System.Drawing.Point(73, 369);
            this.TextBoxContra.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxContra.Name = "TextBoxContra";
            this.TextBoxContra.PasswordChar = '*';
            this.TextBoxContra.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TextBoxContra.PlaceholderText = "CONTRASEÑA";
            this.TextBoxContra.SelectedText = "";
            this.TextBoxContra.ShadowDecoration.Parent = this.TextBoxContra;
            this.TextBoxContra.Size = new System.Drawing.Size(245, 36);
            this.TextBoxContra.TabIndex = 6;
            this.TextBoxContra.TextChanged += new System.EventHandler(this.TextBoxContra_TextChanged);
            this.TextBoxContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxContra_KeyPress);
            // 
            // ButtonAcceder
            // 
            this.ButtonAcceder.Animated = true;
            this.ButtonAcceder.BorderRadius = 20;
            this.ButtonAcceder.CheckedState.Parent = this.ButtonAcceder;
            this.ButtonAcceder.CustomImages.Parent = this.ButtonAcceder;
            this.ButtonAcceder.Enabled = false;
            this.ButtonAcceder.FillColor = System.Drawing.Color.Red;
            this.ButtonAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAcceder.ForeColor = System.Drawing.Color.White;
            this.ButtonAcceder.HoverState.Parent = this.ButtonAcceder;
            this.ButtonAcceder.Location = new System.Drawing.Point(156, 456);
            this.ButtonAcceder.Name = "ButtonAcceder";
            this.ButtonAcceder.ShadowDecoration.Parent = this.ButtonAcceder;
            this.ButtonAcceder.Size = new System.Drawing.Size(80, 64);
            this.ButtonAcceder.TabIndex = 7;
            this.ButtonAcceder.Text = "→";
            this.ButtonAcceder.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.ButtonAcceder.Click += new System.EventHandler(this.ButtonAcceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pizzeria el buen gusto";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAcceder);
            this.Controls.Add(this.TextBoxContra);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.MinimizarBoton);
            this.Controls.Add(this.CerrarBoton);
            this.Controls.Add(this.pictureLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogin;
        private Guna.UI2.WinForms.Guna2Button CerrarBoton;
        private Guna.UI2.WinForms.Guna2Button MinimizarBoton;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelLogin;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsuario;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxContra;
        private Guna.UI2.WinForms.Guna2Button ButtonAcceder;
        private System.Windows.Forms.Label label1;
    }
}

