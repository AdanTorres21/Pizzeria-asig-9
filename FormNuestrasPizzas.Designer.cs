namespace Win.Pizzeria
{
    partial class FormNuestrasPizzas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label disponibleLabel;
            System.Windows.Forms.Label pedidoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label tipopizzaIdLabel;
            System.Windows.Forms.Label tipoIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label exitenciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuestrasPizzas));
            this.ordenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ordenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.pedidoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTipospizzasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipopizzaIdComboBox = new System.Windows.Forms.ComboBox();
            this.tipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.exitenciaTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            disponibleLabel = new System.Windows.Forms.Label();
            pedidoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            tipopizzaIdLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            exitenciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingNavigator)).BeginInit();
            this.ordenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipospizzasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // disponibleLabel
            // 
            disponibleLabel.AutoSize = true;
            disponibleLabel.Location = new System.Drawing.Point(93, 288);
            disponibleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            disponibleLabel.Name = "disponibleLabel";
            disponibleLabel.Size = new System.Drawing.Size(59, 13);
            disponibleLabel.TabIndex = 2;
            disponibleLabel.Text = "Disponible:";
            // 
            // pedidoLabel
            // 
            pedidoLabel.AutoSize = true;
            pedidoLabel.Location = new System.Drawing.Point(93, 103);
            pedidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pedidoLabel.Name = "pedidoLabel";
            pedidoLabel.Size = new System.Drawing.Size(43, 13);
            pedidoLabel.TabIndex = 4;
            pedidoLabel.Text = "Pedido:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(93, 210);
            precioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 6;
            precioLabel.Text = "Precio:";
            // 
            // tipopizzaIdLabel
            // 
            tipopizzaIdLabel.AutoSize = true;
            tipopizzaIdLabel.Location = new System.Drawing.Point(93, 171);
            tipopizzaIdLabel.Name = "tipopizzaIdLabel";
            tipopizzaIdLabel.Size = new System.Drawing.Size(31, 13);
            tipopizzaIdLabel.TabIndex = 13;
            tipopizzaIdLabel.Text = "Tipo:";
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(93, 139);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(49, 13);
            tipoIdLabel.TabIndex = 14;
            tipoIdLabel.Text = "Tamaño:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(93, 235);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 15;
            descripcionLabel.Text = "Descripcion:";
            descripcionLabel.Click += new System.EventHandler(this.descripcionLabel_Click);
            // 
            // exitenciaLabel
            // 
            exitenciaLabel.AutoSize = true;
            exitenciaLabel.Location = new System.Drawing.Point(98, 263);
            exitenciaLabel.Name = "exitenciaLabel";
            exitenciaLabel.Size = new System.Drawing.Size(53, 13);
            exitenciaLabel.TabIndex = 16;
            exitenciaLabel.Text = "Exitencia:";
            // 
            // ordenBindingNavigator
            // 
            this.ordenBindingNavigator.AddNewItem = null;
            this.ordenBindingNavigator.BindingSource = this.ordenBindingSource;
            this.ordenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordenBindingNavigator.DeleteItem = null;
            this.ordenBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ordenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordenBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.ordenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordenBindingNavigator.Name = "ordenBindingNavigator";
            this.ordenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordenBindingNavigator.Size = new System.Drawing.Size(802, 27);
            this.ordenBindingNavigator.TabIndex = 1;
            this.ordenBindingNavigator.Text = "bindingNavigator1";
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataSource = typeof(BL.Pizzeria.NuestrasPizzas);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // ordenBindingNavigatorSaveItem
            // 
            this.ordenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordenBindingNavigatorSaveItem.Image")));
            this.ordenBindingNavigatorSaveItem.Name = "ordenBindingNavigatorSaveItem";
            this.ordenBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.ordenBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ordenBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordenBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // disponibleCheckBox
            // 
            this.disponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ordenBindingSource, "Disponible", true));
            this.disponibleCheckBox.Location = new System.Drawing.Point(156, 285);
            this.disponibleCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disponibleCheckBox.Name = "disponibleCheckBox";
            this.disponibleCheckBox.Size = new System.Drawing.Size(78, 20);
            this.disponibleCheckBox.TabIndex = 3;
            this.disponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // pedidoTextBox
            // 
            this.pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenBindingSource, "Id", true));
            this.pedidoTextBox.Location = new System.Drawing.Point(166, 100);
            this.pedidoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pedidoTextBox.Name = "pedidoTextBox";
            this.pedidoTextBox.ReadOnly = true;
            this.pedidoTextBox.Size = new System.Drawing.Size(212, 20);
            this.pedidoTextBox.TabIndex = 5;
            this.pedidoTextBox.TextChanged += new System.EventHandler(this.pedidoTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(166, 203);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(212, 20);
            this.precioTextBox.TabIndex = 7;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.ordenBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(403, 54);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(293, 206);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 10;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Remover Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png";
            // 
            // listaTiposBindingSource
            // 
            this.listaTiposBindingSource.DataSource = typeof(BL.Pizzeria.Tipo);
            // 
            // listaTipospizzasBindingSource
            // 
            this.listaTipospizzasBindingSource.DataSource = typeof(BL.Pizzeria.Tipopizzas);
            // 
            // tipopizzaIdComboBox
            // 
            this.tipopizzaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenBindingSource, "TipopizzaId", true));
            this.tipopizzaIdComboBox.DataSource = this.listaTipospizzasBindingSource;
            this.tipopizzaIdComboBox.DisplayMember = "Descripcion";
            this.tipopizzaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipopizzaIdComboBox.FormattingEnabled = true;
            this.tipopizzaIdComboBox.Location = new System.Drawing.Point(166, 163);
            this.tipopizzaIdComboBox.Name = "tipopizzaIdComboBox";
            this.tipopizzaIdComboBox.Size = new System.Drawing.Size(212, 21);
            this.tipopizzaIdComboBox.TabIndex = 14;
            this.tipopizzaIdComboBox.ValueMember = "Id";
            // 
            // tipoIdComboBox
            // 
            this.tipoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenBindingSource, "TipoId", true));
            this.tipoIdComboBox.DataSource = this.listaTiposBindingSource;
            this.tipoIdComboBox.DisplayMember = "Descripcion";
            this.tipoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoIdComboBox.FormattingEnabled = true;
            this.tipoIdComboBox.Location = new System.Drawing.Point(166, 136);
            this.tipoIdComboBox.Name = "tipoIdComboBox";
            this.tipoIdComboBox.Size = new System.Drawing.Size(212, 21);
            this.tipoIdComboBox.TabIndex = 15;
            this.tipoIdComboBox.ValueMember = "Id";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(166, 232);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(212, 20);
            this.descripcionTextBox.TabIndex = 16;
            // 
            // exitenciaTextBox
            // 
            this.exitenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenBindingSource, "exitencia", true));
            this.exitenciaTextBox.Location = new System.Drawing.Point(166, 260);
            this.exitenciaTextBox.Name = "exitenciaTextBox";
            this.exitenciaTextBox.Size = new System.Drawing.Size(212, 20);
            this.exitenciaTextBox.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(638, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 19;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormNuestrasPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 376);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(exitenciaLabel);
            this.Controls.Add(this.exitenciaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(tipoIdLabel);
            this.Controls.Add(this.tipoIdComboBox);
            this.Controls.Add(tipopizzaIdLabel);
            this.Controls.Add(this.tipopizzaIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(disponibleLabel);
            this.Controls.Add(this.disponibleCheckBox);
            this.Controls.Add(pedidoLabel);
            this.Controls.Add(this.pedidoTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.ordenBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNuestrasPizzas";
            this.Text = "NuestrasPizzas";
            this.Load += new System.EventHandler(this.FormNuestrasPizzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingNavigator)).EndInit();
            this.ordenBindingNavigator.ResumeLayout(false);
            this.ordenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTipospizzasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private System.Windows.Forms.BindingNavigator ordenBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordenBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox disponibleCheckBox;
        private System.Windows.Forms.TextBox pedidoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaTiposBindingSource;
        private System.Windows.Forms.BindingSource listaTipospizzasBindingSource;
        private System.Windows.Forms.ComboBox tipopizzaIdComboBox;
        private System.Windows.Forms.ComboBox tipoIdComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox exitenciaTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}