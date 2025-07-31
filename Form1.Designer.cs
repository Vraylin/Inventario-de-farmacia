namespace Inventario_de_farmacia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

            #region Código generado por el Diseñador de Windows Forms

         
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCaja = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnGerente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fARMACIA1DataSet10 = new Inventario_de_farmacia.FARMACIA1DataSet10();
            this.fARMACIA1DataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet12 = new Inventario_de_farmacia.FARMACIA1DataSet12();
            this.fARMACIA1DataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet16 = new Inventario_de_farmacia.FARMACIA1DataSet16();
            this.sPListarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ListarProductosTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet16TableAdapters.SP_ListarProductosTableAdapter();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADMEDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(679, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuStrip1";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.suplidoresToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.cajasToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(104, 30);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.suplidoresToolStripMenuItem.Text = "Suplidores";
            this.suplidoresToolStripMenuItem.Click += new System.EventHandler(this.SuplidoresToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // cajasToolStripMenuItem
            // 
            this.cajasToolStripMenuItem.Name = "cajasToolStripMenuItem";
            this.cajasToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.cajasToolStripMenuItem.Text = "Caja";
            this.cajasToolStripMenuItem.Click += new System.EventHandler(this.CajasToolStripMenuItem_Click);
            // 
            // BtnCaja
            // 
            this.BtnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCaja.Location = new System.Drawing.Point(46, 191);
            this.BtnCaja.Name = "BtnCaja";
            this.BtnCaja.Size = new System.Drawing.Size(167, 150);
            this.BtnCaja.TabIndex = 1;
            this.BtnCaja.Text = "Caja";
            this.BtnCaja.UseVisualStyleBackColor = false;
            this.BtnCaja.Click += new System.EventHandler(this.BtnCaja_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnProductos.Location = new System.Drawing.Point(234, 191);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(167, 150);
            this.BtnProductos.TabIndex = 2;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnGerente
            // 
            this.BtnGerente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGerente.Location = new System.Drawing.Point(428, 191);
            this.BtnGerente.Name = "BtnGerente";
            this.BtnGerente.Size = new System.Drawing.Size(167, 150);
            this.BtnGerente.TabIndex = 3;
            this.BtnGerente.Text = "Gerente";
            this.BtnGerente.UseVisualStyleBackColor = false;
            this.BtnGerente.Click += new System.EventHandler(this.BtnGerente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.nOMBREPRODUCTODataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn,
            this.uNIDADMEDIDADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPListarProductosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 277);
            this.dataGridView1.TabIndex = 4;
            // 
            // fARMACIA1DataSet10
            // 
            this.fARMACIA1DataSet10.DataSetName = "FARMACIA1DataSet10";
            this.fARMACIA1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fARMACIA1DataSet10BindingSource
            // 
            this.fARMACIA1DataSet10BindingSource.DataSource = this.fARMACIA1DataSet10;
            this.fARMACIA1DataSet10BindingSource.Position = 0;
            // 
            // fARMACIA1DataSet12
            // 
            this.fARMACIA1DataSet12.DataSetName = "FARMACIA1DataSet12";
            this.fARMACIA1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fARMACIA1DataSet12BindingSource
            // 
            this.fARMACIA1DataSet12BindingSource.DataSource = this.fARMACIA1DataSet12;
            this.fARMACIA1DataSet12BindingSource.Position = 0;
            // 
            // gerenteBindingSource
            // 
            this.gerenteBindingSource.DataSource = typeof(Inventario_de_farmacia.Gerente);
            // 
            // fARMACIA1DataSet16
            // 
            this.fARMACIA1DataSet16.DataSetName = "FARMACIA1DataSet16";
            this.fARMACIA1DataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPListarProductosBindingSource
            // 
            this.sPListarProductosBindingSource.DataMember = "SP_ListarProductos";
            this.sPListarProductosBindingSource.DataSource = this.fARMACIA1DataSet16;
            // 
            // sP_ListarProductosTableAdapter
            // 
            this.sP_ListarProductosTableAdapter.ClearBeforeFill = true;
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
            // nOMBREPRODUCTODataGridViewTextBoxColumn
            // 
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.HeaderText = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.Name = "nOMBREPRODUCTODataGridViewTextBoxColumn";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            this.pRECIODataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIODataGridViewTextBoxColumn.Width = 125;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOCKDataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHAVENCIMIENTODataGridViewTextBoxColumn
            // 
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_VENCIMIENTO";
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.HeaderText = "FECHA_VENCIMIENTO";
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.Name = "fECHAVENCIMIENTODataGridViewTextBoxColumn";
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.Width = 125;
            // 
            // uNIDADMEDIDADataGridViewTextBoxColumn
            // 
            this.uNIDADMEDIDADataGridViewTextBoxColumn.DataPropertyName = "UNIDAD_MEDIDA";
            this.uNIDADMEDIDADataGridViewTextBoxColumn.HeaderText = "UNIDAD_MEDIDA";
            this.uNIDADMEDIDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uNIDADMEDIDADataGridViewTextBoxColumn.Name = "uNIDADMEDIDADataGridViewTextBoxColumn";
            this.uNIDADMEDIDADataGridViewTextBoxColumn.ReadOnly = true;
            this.uNIDADMEDIDADataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(679, 658);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGerente);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.BtnCaja);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajasToolStripMenuItem;
        private System.Windows.Forms.Button BtnCaja;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnGerente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gerenteBindingSource;
        private FARMACIA1DataSet10 fARMACIA1DataSet10;
        private System.Windows.Forms.BindingSource fARMACIA1DataSet10BindingSource;
        private FARMACIA1DataSet12 fARMACIA1DataSet12;
        private System.Windows.Forms.BindingSource fARMACIA1DataSet12BindingSource;
        private FARMACIA1DataSet16 fARMACIA1DataSet16;
        private System.Windows.Forms.BindingSource sPListarProductosBindingSource;
        private FARMACIA1DataSet16TableAdapters.SP_ListarProductosTableAdapter sP_ListarProductosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVENCIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADMEDIDADataGridViewTextBoxColumn;
    }
}

