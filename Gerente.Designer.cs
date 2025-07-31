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
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.G_Compra_Suplidores = new System.Windows.Forms.Button();
            this.DataGridViewVentaDia = new System.Windows.Forms.DataGridView();
            this.cAJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet2 = new Inventario_de_farmacia.FARMACIA1DataSet2();
            this.Label1Compra = new System.Windows.Forms.Label();
            this.cAJATableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet2TableAdapters.CAJATableAdapter();
            this.fARMACIA1DataSet17 = new Inventario_de_farmacia.FARMACIA1DataSet17();
            this.cAJABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cAJATableAdapter1 = new Inventario_de_farmacia.FARMACIA1DataSet17TableAdapters.CAJATableAdapter();
            this.iDVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEMPLEADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVentaDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAJABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MenuStrip1";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.suplidoresToolStripMenuItem,
            this.cajasToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(104, 30);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.GestiónToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.suplidoresToolStripMenuItem.Text = "Suplidores";
            this.suplidoresToolStripMenuItem.Click += new System.EventHandler(this.suplidoresToolStripMenuItem_Click);
            // 
            // cajasToolStripMenuItem
            // 
            this.cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            this.cajasToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.cajasToolStripMenuItem.Text = "Caja";
            // 
            // G_Compra_Suplidores
            // 
            this.G_Compra_Suplidores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.G_Compra_Suplidores.Location = new System.Drawing.Point(0, 37);
            this.G_Compra_Suplidores.Name = "G_Compra_Suplidores";
            this.G_Compra_Suplidores.Size = new System.Drawing.Size(212, 53);
            this.G_Compra_Suplidores.TabIndex = 2;
            this.G_Compra_Suplidores.Text = "Comprar Suplidores";
            this.G_Compra_Suplidores.UseVisualStyleBackColor = false;
            this.G_Compra_Suplidores.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridViewVentaDia
            // 
            this.DataGridViewVentaDia.AllowUserToAddRows = false;
            this.DataGridViewVentaDia.AllowUserToDeleteRows = false;
            this.DataGridViewVentaDia.AutoGenerateColumns = false;
            this.DataGridViewVentaDia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DataGridViewVentaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVentaDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVENTADataGridViewTextBoxColumn,
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.pRECIOUNITARIODataGridViewTextBoxColumn,
            this.fECHAVENTADataGridViewTextBoxColumn,
            this.iDEMPLEADODataGridViewTextBoxColumn,
            this.iDCLIENTEDataGridViewTextBoxColumn});
            this.DataGridViewVentaDia.DataSource = this.cAJABindingSource1;
            this.DataGridViewVentaDia.Location = new System.Drawing.Point(0, 146);
            this.DataGridViewVentaDia.Name = "DataGridViewVentaDia";
            this.DataGridViewVentaDia.ReadOnly = true;
            this.DataGridViewVentaDia.RowHeadersWidth = 51;
            this.DataGridViewVentaDia.RowTemplate.Height = 24;
            this.DataGridViewVentaDia.Size = new System.Drawing.Size(941, 249);
            this.DataGridViewVentaDia.TabIndex = 5;
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
            // fARMACIA1DataSet17
            // 
            this.fARMACIA1DataSet17.DataSetName = "FARMACIA1DataSet17";
            this.fARMACIA1DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAJABindingSource1
            // 
            this.cAJABindingSource1.DataMember = "CAJA";
            this.cAJABindingSource1.DataSource = this.fARMACIA1DataSet17;
            // 
            // cAJATableAdapter1
            // 
            this.cAJATableAdapter1.ClearBeforeFill = true;
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
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1043, 402);
            this.Controls.Add(this.Label1Compra);
            this.Controls.Add(this.DataGridViewVentaDia);
            this.Controls.Add(this.G_Compra_Suplidores);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gerente";
            this.Text = "Gerente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Gerente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVentaDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAJABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajasToolStripMenuItem;
        private System.Windows.Forms.Button G_Compra_Suplidores;
        private System.Windows.Forms.DataGridView DataGridViewVentaDia;
        private System.Windows.Forms.Label Label1Compra;
        private FARMACIA1DataSet2 fARMACIA1DataSet2;
        private System.Windows.Forms.BindingSource cAJABindingSource;
        private FARMACIA1DataSet2TableAdapters.CAJATableAdapter cAJATableAdapter;
        private FARMACIA1DataSet17 fARMACIA1DataSet17;
        private System.Windows.Forms.BindingSource cAJABindingSource1;
        private FARMACIA1DataSet17TableAdapters.CAJATableAdapter cAJATableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOUNITARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPLEADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
    }
}