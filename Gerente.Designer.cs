namespace Inventario_de_farmacia
{
    partial class Gerente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caducacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEMPLEADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet2 = new Inventario_de_farmacia.FARMACIA1DataSet2();
            this.Label1Compra = new System.Windows.Forms.Label();
            this.cAJATableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet2TableAdapters.CAJATableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestiónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MenuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.caducacionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(119, 30);
            this.archivoToolStripMenuItem.Text = "producto";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.ArchivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.salirToolStripMenuItem.Text = "Suplidores";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.stockToolStripMenuItem.Text = "stock";
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.ofertasToolStripMenuItem.Text = "Ofertas";
            // 
            // caducacionToolStripMenuItem
            // 
            this.caducacionToolStripMenuItem.Name = "caducacionToolStripMenuItem";
            this.caducacionToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.caducacionToolStripMenuItem.Text = "Caducacion";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.suplidoresToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.cajasToolStripMenuItem,
            this.pagoToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(104, 30);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.GestiónToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.suplidoresToolStripMenuItem.Text = "Suplidores";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // cajasToolStripMenuItem
            // 
            this.cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            this.cajasToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.cajasToolStripMenuItem.Text = "Caja";
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.pagoToolStripMenuItem.Text = "Pagos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(91, 30);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AyudaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(0, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(218, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(436, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Button2";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVENTADataGridViewTextBoxColumn,
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.pRECIOUNITARIODataGridViewTextBoxColumn,
            this.fECHAVENTADataGridViewTextBoxColumn,
            this.iDEMPLEADODataGridViewTextBoxColumn,
            this.iDCLIENTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cAJABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(934, 249);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDVENTADataGridViewTextBoxColumn
            // 
            this.iDVENTADataGridViewTextBoxColumn.DataPropertyName = "ID_VENTA";
            this.iDVENTADataGridViewTextBoxColumn.HeaderText = "ID_VENTA";
            this.iDVENTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDVENTADataGridViewTextBoxColumn.Name = "iDVENTADataGridViewTextBoxColumn";
            this.iDVENTADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDVENTADataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPRODUCTODataGridViewTextBoxColumn
            // 
            this.iDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn.HeaderText = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPRODUCTODataGridViewTextBoxColumn.Name = "iDPRODUCTODataGridViewTextBoxColumn";
            this.iDPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUCTODataGridViewTextBoxColumn.Width = 125;
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            this.cANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            this.cANTIDADDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECIOUNITARIODataGridViewTextBoxColumn
            // 
            this.pRECIOUNITARIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO_UNITARIO";
            this.pRECIOUNITARIODataGridViewTextBoxColumn.HeaderText = "PRECIO_UNITARIO";
            this.pRECIOUNITARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECIOUNITARIODataGridViewTextBoxColumn.Name = "pRECIOUNITARIODataGridViewTextBoxColumn";
            this.pRECIOUNITARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIOUNITARIODataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHAVENTADataGridViewTextBoxColumn
            // 
            this.fECHAVENTADataGridViewTextBoxColumn.DataPropertyName = "FECHA_VENTA";
            this.fECHAVENTADataGridViewTextBoxColumn.HeaderText = "FECHA_VENTA";
            this.fECHAVENTADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAVENTADataGridViewTextBoxColumn.Name = "fECHAVENTADataGridViewTextBoxColumn";
            this.fECHAVENTADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAVENTADataGridViewTextBoxColumn.Width = 125;
            // 
            // iDEMPLEADODataGridViewTextBoxColumn
            // 
            this.iDEMPLEADODataGridViewTextBoxColumn.DataPropertyName = "ID_EMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.HeaderText = "ID_EMPLEADO";
            this.iDEMPLEADODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEMPLEADODataGridViewTextBoxColumn.Name = "iDEMPLEADODataGridViewTextBoxColumn";
            this.iDEMPLEADODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEMPLEADODataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            this.iDCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCLIENTEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cAJABindingSource
            // 
            this.cAJABindingSource.DataMember = "CAJA";
            this.cAJABindingSource.DataSource = this.fARMACIA1DataSet2;
            // 
            // fARMACIA1DataSet2
            // 
            this.fARMACIA1DataSet2.DataSetName = "FARMACIA1DataSet2";
            this.fARMACIA1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label1Compra
            // 
            this.Label1Compra.AutoSize = true;
            this.Label1Compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label1Compra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1Compra.Location = new System.Drawing.Point(37, 108);
            this.Label1Compra.Name = "Label1Compra";
            this.Label1Compra.Size = new System.Drawing.Size(145, 23);
            this.Label1Compra.TabIndex = 6;
            this.Label1Compra.Text = "Compras del dia";
            this.Label1Compra.Click += new System.EventHandler(this.Label1Compra_Click);
            // 
            // cAJATableAdapter
            // 
            this.cAJATableAdapter.ClearBeforeFill = true;
            // 
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(944, 402);
            this.Controls.Add(this.Label1Compra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gerente";
            this.Text = "Gerente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Gerente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caducacionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label1Compra;
        private FARMACIA1DataSet2 fARMACIA1DataSet2;
        private System.Windows.Forms.BindingSource cAJABindingSource;
        private FARMACIA1DataSet2TableAdapters.CAJATableAdapter cAJATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOUNITARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPLEADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
    }
}