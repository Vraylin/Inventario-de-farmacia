namespace Inventario_de_farmacia
{
    partial class Caja
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

   
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAREGISTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADMEDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOMAYORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODETALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet = new Inventario_de_farmacia.FARMACIA1DataSet();
            this.CompraCaja = new System.Windows.Forms.Button();
            this.textBoxComprar = new System.Windows.Forms.TextBox();
            this.Cantidad_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            // Por estas líneas (ajustando el nombre del DataSet y TableAdapter según el archivo .xsd generado, normalmente están en el espacio de nombres global o en el namespace del proyecto):
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet)).BeginInit();
            this.SuspendLayout();
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
            this.fECHAREGISTRODataGridViewTextBoxColumn,
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn,
            this.uNIDADMEDIDADataGridViewTextBoxColumn,
            this.pRECIOMAYORDataGridViewTextBoxColumn,
            this.pRECIODETALLEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTOSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1181, 642);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
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
            // fECHAREGISTRODataGridViewTextBoxColumn
            // 
            this.fECHAREGISTRODataGridViewTextBoxColumn.DataPropertyName = "FECHA_REGISTRO";
            this.fECHAREGISTRODataGridViewTextBoxColumn.HeaderText = "FECHA_REGISTRO";
            this.fECHAREGISTRODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAREGISTRODataGridViewTextBoxColumn.Name = "fECHAREGISTRODataGridViewTextBoxColumn";
            this.fECHAREGISTRODataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAREGISTRODataGridViewTextBoxColumn.Width = 125;
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
            // pRECIOMAYORDataGridViewTextBoxColumn
            // 
            this.pRECIOMAYORDataGridViewTextBoxColumn.DataPropertyName = "PRECIO_MAYOR";
            this.pRECIOMAYORDataGridViewTextBoxColumn.HeaderText = "PRECIO_MAYOR";
            this.pRECIOMAYORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECIOMAYORDataGridViewTextBoxColumn.Name = "pRECIOMAYORDataGridViewTextBoxColumn";
            this.pRECIOMAYORDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIOMAYORDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECIODETALLEDataGridViewTextBoxColumn
            // 
            this.pRECIODETALLEDataGridViewTextBoxColumn.DataPropertyName = "PRECIO_DETALLE";
            this.pRECIODETALLEDataGridViewTextBoxColumn.HeaderText = "PRECIO_DETALLE";
            this.pRECIODETALLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECIODETALLEDataGridViewTextBoxColumn.Name = "pRECIODETALLEDataGridViewTextBoxColumn";
            this.pRECIODETALLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIODETALLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRODUCTOSBindingSource1
            // 
            this.pRODUCTOSBindingSource1.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource1.DataSource = this.fARMACIA1DataSet;
            // 
            // fARMACIA1DataSet
            // 
            this.fARMACIA1DataSet.DataSetName = "FARMACIA1DataSet";
            this.fARMACIA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CompraCaja
            // 
            this.CompraCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CompraCaja.Location = new System.Drawing.Point(12, 168);
            this.CompraCaja.Name = "CompraCaja";
            this.CompraCaja.Size = new System.Drawing.Size(185, 57);
            this.CompraCaja.TabIndex = 3;
            this.CompraCaja.Text = "comprar";
            this.CompraCaja.UseVisualStyleBackColor = false;
            this.CompraCaja.Click += new System.EventHandler(this.CompraCaja_Click);
            // 
            // textBoxComprar
            // 
            this.textBoxComprar.Location = new System.Drawing.Point(12, 81);
            this.textBoxComprar.Name = "textBoxComprar";
            this.textBoxComprar.Size = new System.Drawing.Size(139, 22);
            this.textBoxComprar.TabIndex = 4;
            // 
            // Cantidad_producto
            // 
            this.Cantidad_producto.Location = new System.Drawing.Point(213, 81);
            this.Cantidad_producto.Name = "Cantidad_producto";
            this.Cantidad_producto.Size = new System.Drawing.Size(139, 22);
            this.Cantidad_producto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id_producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(214, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de producto";
            // 
            // pRODUCTOSTableAdapter1
            // 
            this.pRODUCTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1301, 711);
            this.Controls.Add(this.Cantidad_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComprar);
            this.Controls.Add(this.CompraCaja);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Caja";
            this.Text = "PagoCaja";
            this.Load += new System.EventHandler(this.Caja_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CompraCaja;
        private System.Windows.Forms.TextBox textBoxComprar;
        private System.Windows.Forms.TextBox Cantidad_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FARMACIA1DataSet fARMACIA1DataSet;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
        private FARMACIA1DataSetTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAREGISTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVENCIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADMEDIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOMAYORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODETALLEDataGridViewTextBoxColumn;
    }
}