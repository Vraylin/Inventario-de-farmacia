namespace Inventario_de_farmacia
{
    partial class Productos
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
            this.fARMACIA1DataSet = new Inventario_de_farmacia.FARMACIA1DataSet();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSetTableAdapters.PRODUCTOSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADMEDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOMAYORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODETALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet1 = new Inventario_de_farmacia.FARMACIA1DataSet1();
            this.pRODUCTOSTableAdapter1 = new Inventario_de_farmacia.FARMACIA1DataSet1TableAdapters.PRODUCTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fARMACIA1DataSet
            // 
            this.fARMACIA1DataSet.DataSetName = "FARMACIA1DataSet";
            this.fARMACIA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.fARMACIA1DataSet;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.nOMBREPRODUCTODataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn,
            this.uNIDADMEDIDADataGridViewTextBoxColumn,
            this.pRECIOMAYORDataGridViewTextBoxColumn,
            this.pRECIODETALLEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTOSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 691);
            this.dataGridView1.TabIndex = 0;
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
            this.pRODUCTOSBindingSource1.DataSource = this.fARMACIA1DataSet1;
            // 
            // fARMACIA1DataSet1
            // 
            this.fARMACIA1DataSet1.DataSetName = "FARMACIA1DataSet1";
            this.fARMACIA1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSTableAdapter1
            // 
            this.pRODUCTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1062, 695);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        // Nuevas declaraciones de objetos para el FARMACIA1DataSet
        private FARMACIA1DataSet fARMACIA1DataSet; // Asegúrate de que esta línea esté declarada
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private FARMACIA1DataSetTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FARMACIA1DataSet1 fARMACIA1DataSet1;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource1;
        private FARMACIA1DataSet1TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVENCIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADMEDIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOMAYORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODETALLEDataGridViewTextBoxColumn;
    }
}
        #endregion
  