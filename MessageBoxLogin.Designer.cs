namespace Win.Pizzeria
{
    partial class MessageBoxLogin
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
            this.Mensaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonError = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Font = new System.Drawing.Font("MarkPro-Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje.Location = new System.Drawing.Point(28, 169);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(270, 60);
            this.Mensaje.TabIndex = 1;
            this.Mensaje.Text = "Tus credeciales de inicio de sesion \r\nno coincide con ninguna cuenta \r\nen nustro " +
    "sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win.Pizzeria.Properties.Resources.ErrorLogin1;
            this.pictureBox1.Location = new System.Drawing.Point(-19, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonError
            // 
            this.ButtonError.BorderRadius = 20;
            this.ButtonError.CheckedState.Parent = this.ButtonError;
            this.ButtonError.CustomImages.Parent = this.ButtonError;
            this.ButtonError.Font = new System.Drawing.Font("Mark", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonError.ForeColor = System.Drawing.Color.White;
            this.ButtonError.HoverState.Parent = this.ButtonError;
            this.ButtonError.Location = new System.Drawing.Point(130, 243);
            this.ButtonError.Name = "ButtonError";
            this.ButtonError.ShadowDecoration.Parent = this.ButtonError;
            this.ButtonError.Size = new System.Drawing.Size(74, 52);
            this.ButtonError.TabIndex = 3;
            this.ButtonError.Text = "Aceptar";
            this.ButtonError.Click += new System.EventHandler(this.ButtonError_Click);
            // 
            // MessageBoxLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 316);
            this.Controls.Add(this.ButtonError);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button ButtonError;
    }
}