namespace Login1
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btlGuardar = new System.Windows.Forms.Button();
            this.btlFacturar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.fKFacturaIDMeto30F848EDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFacturaIDMeto30F848EDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Login1.DataSet1();
            this.metodoPagoTableAdapter = new Login1.DataSet1TableAdapters.MetodoPagoTableAdapter();
            this.facturaTableAdapter = new Login1.DataSet1TableAdapters.FacturaTableAdapter();
            this.metodoPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metodoPagoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaIDMeto30F848EDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaIDMeto30F848EDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 130);
            this.panel2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioDiaToolStripMenuItem,
            this.cierreDiaToolStripMenuItem,
            this.cuadreToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // inicioDiaToolStripMenuItem
            // 
            this.inicioDiaToolStripMenuItem.Name = "inicioDiaToolStripMenuItem";
            this.inicioDiaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.inicioDiaToolStripMenuItem.Text = "Inicio dia";
            this.inicioDiaToolStripMenuItem.Click += new System.EventHandler(this.inicioDiaToolStripMenuItem_Click);
            // 
            // cierreDiaToolStripMenuItem
            // 
            this.cierreDiaToolStripMenuItem.Name = "cierreDiaToolStripMenuItem";
            this.cierreDiaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cierreDiaToolStripMenuItem.Text = "Cierre dia";
            this.cierreDiaToolStripMenuItem.Click += new System.EventHandler(this.cierreDiaToolStripMenuItem_Click);
            // 
            // cuadreToolStripMenuItem
            // 
            this.cuadreToolStripMenuItem.Name = "cuadreToolStripMenuItem";
            this.cuadreToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cuadreToolStripMenuItem.Text = "Cuadres";
            this.cuadreToolStripMenuItem.Click += new System.EventHandler(this.cuadreToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTax);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btlGuardar);
            this.panel1.Controls.Add(this.btlFacturar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtServicio);
            this.panel1.Location = new System.Drawing.Point(28, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 438);
            this.panel1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.comboBox1.Location = new System.Drawing.Point(309, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Tag = "Efectivo";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tax";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(309, 187);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(166, 20);
            this.txtTax.TabIndex = 12;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Metodo de Pago";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Facturacion";
            // 
            // btlGuardar
            // 
            this.btlGuardar.Location = new System.Drawing.Point(566, 337);
            this.btlGuardar.Name = "btlGuardar";
            this.btlGuardar.Size = new System.Drawing.Size(177, 55);
            this.btlGuardar.TabIndex = 8;
            this.btlGuardar.Text = "Guardar";
            this.btlGuardar.UseVisualStyleBackColor = true;
            this.btlGuardar.Click += new System.EventHandler(this.btlGuardar_Click);
            // 
            // btlFacturar
            // 
            this.btlFacturar.Location = new System.Drawing.Point(566, 260);
            this.btlFacturar.Name = "btlFacturar";
            this.btlFacturar.Size = new System.Drawing.Size(177, 55);
            this.btlFacturar.TabIndex = 7;
            this.btlFacturar.Text = "Facturar";
            this.btlFacturar.UseVisualStyleBackColor = true;
            this.btlFacturar.Click += new System.EventHandler(this.btlFacturar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(25, 251);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(479, 156);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(25, 187);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(166, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicio";
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(25, 135);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(166, 20);
            this.txtServicio.TabIndex = 0;
            this.txtServicio.TextChanged += new System.EventHandler(this.txtServicio_TextChanged);
            // 
            // fKFacturaIDMeto30F848EDBindingSource
            // 
            this.fKFacturaIDMeto30F848EDBindingSource.DataMember = "FK__Factura__ID_Meto__30F848ED";
            this.fKFacturaIDMeto30F848EDBindingSource.DataSource = this.metodoPagoBindingSource;
            // 
            // fKFacturaIDMeto30F848EDBindingSource1
            // 
            this.fKFacturaIDMeto30F848EDBindingSource1.DataMember = "FK__Factura__ID_Meto__30F848ED";
            this.fKFacturaIDMeto30F848EDBindingSource1.DataSource = this.metodoPagoBindingSource;
            // 
            // metodoPagoBindingSource
            // 
            this.metodoPagoBindingSource.DataMember = "MetodoPago";
            this.metodoPagoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoPagoTableAdapter
            // 
            this.metodoPagoTableAdapter.ClearBeforeFill = true;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // metodoPagoBindingSource1
            // 
            this.metodoPagoBindingSource1.DataMember = "MetodoPago";
            this.metodoPagoBindingSource1.DataSource = this.dataSet1;
            // 
            // metodoPagoBindingSource2
            // 
            this.metodoPagoBindingSource2.DataMember = "MetodoPago";
            this.metodoPagoBindingSource2.DataSource = this.dataSet1;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(861, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Facturacion";
            this.Text = "DatosFactura";
            this.Load += new System.EventHandler(this.DatosFactura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaIDMeto30F848EDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFacturaIDMeto30F848EDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoPagoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btlGuardar;
        private System.Windows.Forms.Button btlFacturar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadreToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTax;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource metodoPagoBindingSource;
        private DataSet1TableAdapters.MetodoPagoTableAdapter metodoPagoTableAdapter;
        private System.Windows.Forms.BindingSource fKFacturaIDMeto30F848EDBindingSource;
        private DataSet1TableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.BindingSource metodoPagoBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource metodoPagoBindingSource2;
        private System.Windows.Forms.BindingSource fKFacturaIDMeto30F848EDBindingSource1;
    }
}