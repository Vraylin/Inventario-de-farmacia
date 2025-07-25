using System;
using System.Windows.Forms;

namespace Inventario_de_farmacia
{
    partial class Suplidores
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
            this.Cantidad_producto1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.NombreIdProducto = new System.Windows.Forms.Label();
            this.TextBoxIdProducto = new System.Windows.Forms.TextBox();
            this.CompraSuplido = new System.Windows.Forms.Button();
            this.cOMPRASSUPLIDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet3 = new Inventario_de_farmacia.FARMACIA1DataSet3();
            this.cOMPRAS_SUPLIDORESTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet3TableAdapters.COMPRAS_SUPLIDORESTableAdapter();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet6 = new Inventario_de_farmacia.FARMACIA1DataSet6();
            this.gERENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet4 = new Inventario_de_farmacia.FARMACIA1DataSet4();
            this.gERENTETableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet4TableAdapters.GERENTETableAdapter();
            this.TextBoxIdSuplidor = new System.Windows.Forms.TextBox();
            this.NombreIdSuplidor = new System.Windows.Forms.Label();
            this.farmaciA1DataSet1 = new Inventario_de_farmacia.FARMACIA1DataSet1();
            this.farmaciA1DataSet2 = new Inventario_de_farmacia.FARMACIA1DataSet1();
            this.dataSet1 = new System.Data.DataSet();
            this.cOMPRASSUPLIDORESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet7 = new Inventario_de_farmacia.FARMACIA1DataSet7();
            this.sPVerMovimientoDineroBalanceNetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet5 = new Inventario_de_farmacia.FARMACIA1DataSet5();
            this.sP_VerMovimientoDinero_BalanceNetoTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet5TableAdapters.SP_VerMovimientoDinero_BalanceNetoTableAdapter();
            this.pRODUCTOSTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet6TableAdapters.PRODUCTOSTableAdapter();
            this.cOMPRAS_SUPLIDORESTableAdapter1 = new Inventario_de_farmacia.FARMACIA1DataSet7TableAdapters.COMPRAS_SUPLIDORESTableAdapter();
            this.fARMACIA1DataSet8 = new Inventario_de_farmacia.FARMACIA1DataSet8();
            this.sPListarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ListarProductosTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet8TableAdapters.SP_ListarProductosTableAdapter();
            this.ListodeProductos = new System.Windows.Forms.DataGridView();
            this.iDSUPLIDORDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUCTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAREGISTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADMEDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODETALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPListarProductosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet15 = new Inventario_de_farmacia.FARMACIA1DataSet15();
            this.sPListarProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet9 = new Inventario_de_farmacia.FARMACIA1DataSet9();
            this.sPListarProductosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet10 = new Inventario_de_farmacia.FARMACIA1DataSet10();
            this.sP_ListarProductosTableAdapter1 = new Inventario_de_farmacia.FARMACIA1DataSet9TableAdapters.SP_ListarProductosTableAdapter();
            this.sP_ListarProductosTableAdapter2 = new Inventario_de_farmacia.FARMACIA1DataSet10TableAdapters.SP_ListarProductosTableAdapter();
            this.DataGridViewSaldoAdtual = new System.Windows.Forms.DataGridView();
            this.saldoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPObtenerSaldoFarmaciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet11 = new Inventario_de_farmacia.FARMACIA1DataSet11();
            this.sP_ObtenerSaldoFarmaciaTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet11TableAdapters.SP_ObtenerSaldoFarmaciaTableAdapter();
            this.cOMPRASSUPLIDORESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet14 = new Inventario_de_farmacia.FARMACIA1DataSet14();
            this.sPListarProductosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ListarProductosTableAdapter3 = new Inventario_de_farmacia.FARMACIA1DataSet14TableAdapters.SP_ListarProductosTableAdapter();
            this.fARMACIA1DataSet13 = new Inventario_de_farmacia.FARMACIA1DataSet13();
            this.fARMACIA1DataSet13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet14BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet13BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ListarProductosTableAdapter4 = new Inventario_de_farmacia.FARMACIA1DataSet15TableAdapters.SP_ListarProductosTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSUPLIDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gERENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciA1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciA1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerMovimientoDineroBalanceNetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListodeProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaldoAdtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerSaldoFarmaciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet13BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet14BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet13BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cantidad_producto1
            // 
            this.Cantidad_producto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cantidad_producto1.Location = new System.Drawing.Point(163, 46);
            this.Cantidad_producto1.Name = "Cantidad_producto1";
            this.Cantidad_producto1.Size = new System.Drawing.Size(100, 22);
            this.Cantidad_producto1.TabIndex = 24;
            this.Cantidad_producto1.TextChanged += new System.EventHandler(this.Cantidad_producto_TextChanged_1);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label2.Location = new System.Drawing.Point(160, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 16);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Cantidad de producto";
            // 
            // NombreIdProducto
            // 
            this.NombreIdProducto.AutoSize = true;
            this.NombreIdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NombreIdProducto.Location = new System.Drawing.Point(12, 9);
            this.NombreIdProducto.Name = "NombreIdProducto";
            this.NombreIdProducto.Size = new System.Drawing.Size(78, 16);
            this.NombreIdProducto.TabIndex = 12;
            this.NombreIdProducto.Text = "Id_producto";
            // 
            // TextBoxIdProducto
            // 
            this.TextBoxIdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBoxIdProducto.Location = new System.Drawing.Point(3, 46);
            this.TextBoxIdProducto.Name = "TextBoxIdProducto";
            this.TextBoxIdProducto.Size = new System.Drawing.Size(100, 22);
            this.TextBoxIdProducto.TabIndex = 22;
            this.TextBoxIdProducto.TextChanged += new System.EventHandler(this.TextBoxIdProducto_TextChanged);
            // 
            // CompraSuplido
            // 
            this.CompraSuplido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CompraSuplido.Location = new System.Drawing.Point(140, 97);
            this.CompraSuplido.Name = "CompraSuplido";
            this.CompraSuplido.Size = new System.Drawing.Size(185, 57);
            this.CompraSuplido.TabIndex = 10;
            this.CompraSuplido.Text = "comprar";
            this.CompraSuplido.UseVisualStyleBackColor = false;
            this.CompraSuplido.Click += new System.EventHandler(this.CompraSuplido_Click);
            // 
            // cOMPRASSUPLIDORESBindingSource
            // 
            this.cOMPRASSUPLIDORESBindingSource.DataMember = "COMPRAS_SUPLIDORES";
            this.cOMPRASSUPLIDORESBindingSource.DataSource = this.fARMACIA1DataSet3;
            // 
            // fARMACIA1DataSet3
            // 
            this.fARMACIA1DataSet3.DataSetName = "FARMACIA1DataSet3";
            this.fARMACIA1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPRAS_SUPLIDORESTableAdapter
            // 
            this.cOMPRAS_SUPLIDORESTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.fARMACIA1DataSet6;
            // 
            // fARMACIA1DataSet6
            // 
            this.fARMACIA1DataSet6.DataSetName = "FARMACIA1DataSet6";
            this.fARMACIA1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gERENTEBindingSource
            // 
            this.gERENTEBindingSource.DataMember = "GERENTE";
            this.gERENTEBindingSource.DataSource = this.fARMACIA1DataSet4;
            // 
            // fARMACIA1DataSet4
            // 
            this.fARMACIA1DataSet4.DataSetName = "FARMACIA1DataSet4";
            this.fARMACIA1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gERENTETableAdapter
            // 
            this.gERENTETableAdapter.ClearBeforeFill = true;
            // 
            // TextBoxIdSuplidor
            // 
            this.TextBoxIdSuplidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBoxIdSuplidor.Location = new System.Drawing.Point(15, 131);
            this.TextBoxIdSuplidor.Name = "TextBoxIdSuplidor";
            this.TextBoxIdSuplidor.Size = new System.Drawing.Size(100, 22);
            this.TextBoxIdSuplidor.TabIndex = 20;
            this.TextBoxIdSuplidor.TextChanged += new System.EventHandler(this.TextBoxIdSuplidor_TextChanged);
            // 
            // NombreIdSuplidor
            // 
            this.NombreIdSuplidor.AutoSize = true;
            this.NombreIdSuplidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NombreIdSuplidor.Location = new System.Drawing.Point(12, 97);
            this.NombreIdSuplidor.Name = "NombreIdSuplidor";
            this.NombreIdSuplidor.Size = new System.Drawing.Size(69, 16);
            this.NombreIdSuplidor.TabIndex = 17;
            this.NombreIdSuplidor.Text = "Id suplidor";
            // 
            // farmaciA1DataSet1
            // 
            this.farmaciA1DataSet1.DataSetName = "FARMACIA1DataSet";
            this.farmaciA1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // farmaciA1DataSet2
            // 
            this.farmaciA1DataSet2.DataSetName = "FARMACIA1DataSet";
            this.farmaciA1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // cOMPRASSUPLIDORESBindingSource1
            // 
            this.cOMPRASSUPLIDORESBindingSource1.DataMember = "COMPRAS_SUPLIDORES";
            this.cOMPRASSUPLIDORESBindingSource1.DataSource = this.fARMACIA1DataSet7;
            // 
            // fARMACIA1DataSet7
            // 
            this.fARMACIA1DataSet7.DataSetName = "FARMACIA1DataSet7";
            this.fARMACIA1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPVerMovimientoDineroBalanceNetoBindingSource
            // 
            this.sPVerMovimientoDineroBalanceNetoBindingSource.DataMember = "SP_VerMovimientoDinero_BalanceNeto";
            this.sPVerMovimientoDineroBalanceNetoBindingSource.DataSource = this.fARMACIA1DataSet5;
            // 
            // fARMACIA1DataSet5
            // 
            this.fARMACIA1DataSet5.DataSetName = "FARMACIA1DataSet5";
            this.fARMACIA1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_VerMovimientoDinero_BalanceNetoTableAdapter
            // 
            this.sP_VerMovimientoDinero_BalanceNetoTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPRAS_SUPLIDORESTableAdapter1
            // 
            this.cOMPRAS_SUPLIDORESTableAdapter1.ClearBeforeFill = true;
            // 
            // fARMACIA1DataSet8
            // 
            this.fARMACIA1DataSet8.DataSetName = "FARMACIA1DataSet8";
            this.fARMACIA1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPListarProductosBindingSource
            // 
            this.sPListarProductosBindingSource.DataMember = "SP_ListarProductos";
            this.sPListarProductosBindingSource.DataSource = this.fARMACIA1DataSet8;
            // 
            // sP_ListarProductosTableAdapter
            // 
            this.sP_ListarProductosTableAdapter.ClearBeforeFill = true;
            // 
            // ListodeProductos
            // 
            this.ListodeProductos.AllowUserToAddRows = false;
            this.ListodeProductos.AllowUserToDeleteRows = false;
            this.ListodeProductos.AutoGenerateColumns = false;
            this.ListodeProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ListodeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListodeProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSUPLIDORDataGridViewTextBoxColumn1,
            this.iDPRODUCTODataGridViewTextBoxColumn1,
            this.nOMBREPRODUCTODataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.fECHAREGISTRODataGridViewTextBoxColumn,
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn,
            this.uNIDADMEDIDADataGridViewTextBoxColumn,
            this.pRECIODETALLEDataGridViewTextBoxColumn,
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn});
            this.ListodeProductos.DataSource = this.sPListarProductosBindingSource4;
            this.ListodeProductos.Location = new System.Drawing.Point(3, 243);
            this.ListodeProductos.Name = "ListodeProductos";
            this.ListodeProductos.RowHeadersWidth = 51;
            this.ListodeProductos.RowTemplate.Height = 24;
            this.ListodeProductos.Size = new System.Drawing.Size(888, 329);
            this.ListodeProductos.TabIndex = 23;
            this.ListodeProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListodeProductos1_CellContentClick);
            // 
            // iDSUPLIDORDataGridViewTextBoxColumn1
            // 
            this.iDSUPLIDORDataGridViewTextBoxColumn1.DataPropertyName = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn1.HeaderText = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDSUPLIDORDataGridViewTextBoxColumn1.Name = "iDSUPLIDORDataGridViewTextBoxColumn1";
            this.iDSUPLIDORDataGridViewTextBoxColumn1.Width = 125;
            // 
            // iDPRODUCTODataGridViewTextBoxColumn1
            // 
            this.iDPRODUCTODataGridViewTextBoxColumn1.DataPropertyName = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn1.HeaderText = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDPRODUCTODataGridViewTextBoxColumn1.Name = "iDPRODUCTODataGridViewTextBoxColumn1";
            this.iDPRODUCTODataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDPRODUCTODataGridViewTextBoxColumn1.Width = 125;
            // 
            // nOMBREPRODUCTODataGridViewTextBoxColumn
            // 
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.HeaderText = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.Name = "nOMBREPRODUCTODataGridViewTextBoxColumn";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            this.pRECIODataGridViewTextBoxColumn.Width = 125;
            // 
            // sTOCKDataGridViewTextBoxColumn
            // 
            this.sTOCKDataGridViewTextBoxColumn.DataPropertyName = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.HeaderText = "STOCK";
            this.sTOCKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTOCKDataGridViewTextBoxColumn.Name = "sTOCKDataGridViewTextBoxColumn";
            this.sTOCKDataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHAREGISTRODataGridViewTextBoxColumn
            // 
            this.fECHAREGISTRODataGridViewTextBoxColumn.DataPropertyName = "FECHA_REGISTRO";
            this.fECHAREGISTRODataGridViewTextBoxColumn.HeaderText = "FECHA_REGISTRO";
            this.fECHAREGISTRODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAREGISTRODataGridViewTextBoxColumn.Name = "fECHAREGISTRODataGridViewTextBoxColumn";
            this.fECHAREGISTRODataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHAVENCIMIENTODataGridViewTextBoxColumn
            // 
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_VENCIMIENTO";
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.HeaderText = "FECHA_VENCIMIENTO";
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.Name = "fECHAVENCIMIENTODataGridViewTextBoxColumn";
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn.Width = 125;
            // 
            // uNIDADMEDIDADataGridViewTextBoxColumn
            // 
            this.uNIDADMEDIDADataGridViewTextBoxColumn.DataPropertyName = "UNIDAD_MEDIDA";
            this.uNIDADMEDIDADataGridViewTextBoxColumn.HeaderText = "UNIDAD_MEDIDA";
            this.uNIDADMEDIDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uNIDADMEDIDADataGridViewTextBoxColumn.Name = "uNIDADMEDIDADataGridViewTextBoxColumn";
            this.uNIDADMEDIDADataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECIODETALLEDataGridViewTextBoxColumn
            // 
            this.pRECIODETALLEDataGridViewTextBoxColumn.DataPropertyName = "PRECIO_DETALLE";
            this.pRECIODETALLEDataGridViewTextBoxColumn.HeaderText = "PRECIO_DETALLE";
            this.pRECIODETALLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECIODETALLEDataGridViewTextBoxColumn.Name = "pRECIODETALLEDataGridViewTextBoxColumn";
            this.pRECIODETALLEDataGridViewTextBoxColumn.Width = 125;
            // 
            // fECHACREACIONPRODUCTODataGridViewTextBoxColumn
            // 
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREACION_PRODUCTO";
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.HeaderText = "FECHA_CREACION_PRODUCTO";
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.Name = "fECHACREACIONPRODUCTODataGridViewTextBoxColumn";
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.Width = 125;
            // 
            // sPListarProductosBindingSource4
            // 
            this.sPListarProductosBindingSource4.DataMember = "SP_ListarProductos";
            this.sPListarProductosBindingSource4.DataSource = this.fARMACIA1DataSet15;
            // 
            // fARMACIA1DataSet15
            // 
            this.fARMACIA1DataSet15.DataSetName = "FARMACIA1DataSet15";
            this.fARMACIA1DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPListarProductosBindingSource1
            // 
            this.sPListarProductosBindingSource1.DataMember = "SP_ListarProductos";
            this.sPListarProductosBindingSource1.DataSource = this.fARMACIA1DataSet9;
            // 
            // fARMACIA1DataSet9
            // 
            this.fARMACIA1DataSet9.DataSetName = "FARMACIA1DataSet9";
            this.fARMACIA1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPListarProductosBindingSource2
            // 
            this.sPListarProductosBindingSource2.DataMember = "SP_ListarProductos";
            this.sPListarProductosBindingSource2.DataSource = this.fARMACIA1DataSet10;
            // 
            // fARMACIA1DataSet10
            // 
            this.fARMACIA1DataSet10.DataSetName = "FARMACIA1DataSet10";
            this.fARMACIA1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_ListarProductosTableAdapter1
            // 
            this.sP_ListarProductosTableAdapter1.ClearBeforeFill = true;
            // 
            // sP_ListarProductosTableAdapter2
            // 
            this.sP_ListarProductosTableAdapter2.ClearBeforeFill = true;
            // 
            // DataGridViewSaldoAdtual
            // 
            this.DataGridViewSaldoAdtual.AllowUserToAddRows = false;
            this.DataGridViewSaldoAdtual.AllowUserToDeleteRows = false;
            this.DataGridViewSaldoAdtual.AutoGenerateColumns = false;
            this.DataGridViewSaldoAdtual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DataGridViewSaldoAdtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSaldoAdtual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saldoActualDataGridViewTextBoxColumn});
            this.DataGridViewSaldoAdtual.DataSource = this.sPObtenerSaldoFarmaciaBindingSource;
            this.DataGridViewSaldoAdtual.Location = new System.Drawing.Point(897, 243);
            this.DataGridViewSaldoAdtual.Name = "DataGridViewSaldoAdtual";
            this.DataGridViewSaldoAdtual.ReadOnly = true;
            this.DataGridViewSaldoAdtual.RowHeadersWidth = 51;
            this.DataGridViewSaldoAdtual.RowTemplate.Height = 24;
            this.DataGridViewSaldoAdtual.Size = new System.Drawing.Size(264, 343);
            this.DataGridViewSaldoAdtual.TabIndex = 25;
            this.DataGridViewSaldoAdtual.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSaldoAdtual_CellContentClick);
            // 
            // saldoActualDataGridViewTextBoxColumn
            // 
            this.saldoActualDataGridViewTextBoxColumn.DataPropertyName = "SaldoActual";
            this.saldoActualDataGridViewTextBoxColumn.HeaderText = "SaldoActual";
            this.saldoActualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saldoActualDataGridViewTextBoxColumn.Name = "saldoActualDataGridViewTextBoxColumn";
            this.saldoActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoActualDataGridViewTextBoxColumn.Width = 125;
            // 
            // sPObtenerSaldoFarmaciaBindingSource
            // 
            this.sPObtenerSaldoFarmaciaBindingSource.DataMember = "SP_ObtenerSaldoFarmacia";
            this.sPObtenerSaldoFarmaciaBindingSource.DataSource = this.fARMACIA1DataSet11;
            // 
            // fARMACIA1DataSet11
            // 
            this.fARMACIA1DataSet11.DataSetName = "FARMACIA1DataSet11";
            this.fARMACIA1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_ObtenerSaldoFarmaciaTableAdapter
            // 
            this.sP_ObtenerSaldoFarmaciaTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPRASSUPLIDORESBindingSource2
            // 
            this.cOMPRASSUPLIDORESBindingSource2.DataMember = "COMPRAS_SUPLIDORES";
            this.cOMPRASSUPLIDORESBindingSource2.DataSource = this.fARMACIA1DataSet3BindingSource;
            // 
            // fARMACIA1DataSet3BindingSource
            // 
            this.fARMACIA1DataSet3BindingSource.DataSource = this.fARMACIA1DataSet3;
            this.fARMACIA1DataSet3BindingSource.Position = 0;
            // 
            // fARMACIA1DataSet14
            // 
            this.fARMACIA1DataSet14.DataSetName = "FARMACIA1DataSet14";
            this.fARMACIA1DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPListarProductosBindingSource3
            // 
            this.sPListarProductosBindingSource3.DataMember = "SP_ListarProductos";
            this.sPListarProductosBindingSource3.DataSource = this.fARMACIA1DataSet14;
            // 
            // sP_ListarProductosTableAdapter3
            // 
            this.sP_ListarProductosTableAdapter3.ClearBeforeFill = true;
            // 
            // fARMACIA1DataSet13
            // 
            this.fARMACIA1DataSet13.DataSetName = "FARMACIA1DataSet13";
            this.fARMACIA1DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fARMACIA1DataSet13BindingSource
            // 
            this.fARMACIA1DataSet13BindingSource.DataSource = this.fARMACIA1DataSet13;
            this.fARMACIA1DataSet13BindingSource.Position = 0;
            // 
            // fARMACIA1DataSet14BindingSource
            // 
            this.fARMACIA1DataSet14BindingSource.DataSource = this.fARMACIA1DataSet14;
            this.fARMACIA1DataSet14BindingSource.Position = 0;
            // 
            // fARMACIA1DataSet13BindingSource1
            // 
            this.fARMACIA1DataSet13BindingSource1.DataSource = this.fARMACIA1DataSet13;
            this.fARMACIA1DataSet13BindingSource1.Position = 0;
            // 
            // sP_ListarProductosTableAdapter4
            // 
            this.sP_ListarProductosTableAdapter4.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "SP_ListarProductos";
            this.bindingSource1.DataSource = this.fARMACIA1DataSet14;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label1.Location = new System.Drawing.Point(43, 201);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 16);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Cantidad de producto";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn,
            this.iDSUPLIDORDataGridViewTextBoxColumn,
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.pRECIOUNITARIODataGridViewTextBoxColumn,
            this.fECHACOMPRADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOMPRASSUPLIDORESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(629, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 225);
            this.dataGridView1.TabIndex = 28;
            // 
            // iDCOMPRASUPLIDORDataGridViewTextBoxColumn
            // 
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn.DataPropertyName = "ID_COMPRA_SUPLIDOR";
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn.HeaderText = "ID_COMPRA_SUPLIDOR";
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn.Name = "iDCOMPRASUPLIDORDataGridViewTextBoxColumn";
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDSUPLIDORDataGridViewTextBoxColumn
            // 
            this.iDSUPLIDORDataGridViewTextBoxColumn.DataPropertyName = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn.HeaderText = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSUPLIDORDataGridViewTextBoxColumn.Name = "iDSUPLIDORDataGridViewTextBoxColumn";
            this.iDSUPLIDORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSUPLIDORDataGridViewTextBoxColumn.Width = 125;
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
            // fECHACOMPRADataGridViewTextBoxColumn
            // 
            this.fECHACOMPRADataGridViewTextBoxColumn.DataPropertyName = "FECHA_COMPRA";
            this.fECHACOMPRADataGridViewTextBoxColumn.HeaderText = "FECHA_COMPRA";
            this.fECHACOMPRADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHACOMPRADataGridViewTextBoxColumn.Name = "fECHACOMPRADataGridViewTextBoxColumn";
            this.fECHACOMPRADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHACOMPRADataGridViewTextBoxColumn.Width = 125;
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1167, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataGridViewSaldoAdtual);
            this.Controls.Add(this.ListodeProductos);
            this.Controls.Add(this.TextBoxIdSuplidor);
            this.Controls.Add(this.NombreIdSuplidor);
            this.Controls.Add(this.Cantidad_producto1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.NombreIdProducto);
            this.Controls.Add(this.TextBoxIdProducto);
            this.Controls.Add(this.CompraSuplido);
            this.Name = "Suplidores";
            this.Text = "Suplidores";
            this.Load += new System.EventHandler(this.Suplidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gERENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciA1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciA1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerMovimientoDineroBalanceNetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListodeProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaldoAdtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerSaldoFarmaciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet13BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet14BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet13BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }
     
       

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox Cantidad_producto1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label NombreIdProducto;
        private System.Windows.Forms.TextBox TextBoxIdProducto;
        private System.Windows.Forms.Button CompraSuplido;
        private FARMACIA1DataSet3 fARMACIA1DataSet3;
        private System.Windows.Forms.BindingSource cOMPRASSUPLIDORESBindingSource;
        private FARMACIA1DataSet3TableAdapters.COMPRAS_SUPLIDORESTableAdapter cOMPRAS_SUPLIDORESTableAdapter;
        private FARMACIA1DataSet4 fARMACIA1DataSet4;
        private System.Windows.Forms.BindingSource gERENTEBindingSource;
        private FARMACIA1DataSet4TableAdapters.GERENTETableAdapter gERENTETableAdapter;
        private System.Windows.Forms.TextBox TextBoxIdSuplidor;
        private System.Windows.Forms.Label NombreIdSuplidor;
        private FARMACIA1DataSet1 farmaciA1DataSet1;
        private FARMACIA1DataSet1 farmaciA1DataSet2;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource sPVerMovimientoDineroBalanceNetoBindingSource;
        private FARMACIA1DataSet5 fARMACIA1DataSet5;
        private FARMACIA1DataSet5TableAdapters.SP_VerMovimientoDinero_BalanceNetoTableAdapter sP_VerMovimientoDinero_BalanceNetoTableAdapter;
        private FARMACIA1DataSet6 fARMACIA1DataSet6;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private FARMACIA1DataSet6TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private FARMACIA1DataSet7 fARMACIA1DataSet7;
        private System.Windows.Forms.BindingSource cOMPRASSUPLIDORESBindingSource1;
        private FARMACIA1DataSet7TableAdapters.COMPRAS_SUPLIDORESTableAdapter cOMPRAS_SUPLIDORESTableAdapter1;
        private FARMACIA1DataSet8 fARMACIA1DataSet8;
        private System.Windows.Forms.BindingSource sPListarProductosBindingSource;
        private FARMACIA1DataSet8TableAdapters.SP_ListarProductosTableAdapter sP_ListarProductosTableAdapter;
        private System.Windows.Forms.DataGridView ListodeProductos;
        private FARMACIA1DataSet9 fARMACIA1DataSet9;
        private System.Windows.Forms.BindingSource sPListarProductosBindingSource1;
        private FARMACIA1DataSet9TableAdapters.SP_ListarProductosTableAdapter sP_ListarProductosTableAdapter1;
        private FARMACIA1DataSet10 fARMACIA1DataSet10;
        private System.Windows.Forms.BindingSource sPListarProductosBindingSource2;
        private FARMACIA1DataSet10TableAdapters.SP_ListarProductosTableAdapter sP_ListarProductosTableAdapter2;
        private System.Windows.Forms.DataGridView DataGridViewSaldoAdtual;
        private FARMACIA1DataSet11 fARMACIA1DataSet11;
        private System.Windows.Forms.BindingSource sPObtenerSaldoFarmaciaBindingSource;
        private FARMACIA1DataSet11TableAdapters.SP_ObtenerSaldoFarmaciaTableAdapter sP_ObtenerSaldoFarmaciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoActualDataGridViewTextBoxColumn;
        private BindingSource cOMPRASSUPLIDORESBindingSource2;
        private BindingSource fARMACIA1DataSet3BindingSource;
        private FARMACIA1DataSet14 fARMACIA1DataSet14;
        private BindingSource sPListarProductosBindingSource3;
        private FARMACIA1DataSet14TableAdapters.SP_ListarProductosTableAdapter sP_ListarProductosTableAdapter3;
        private FARMACIA1DataSet13 fARMACIA1DataSet13;
        private BindingSource fARMACIA1DataSet13BindingSource;
        private BindingSource fARMACIA1DataSet14BindingSource;
        private BindingSource fARMACIA1DataSet13BindingSource1;
        private FARMACIA1DataSet15 fARMACIA1DataSet15;
        private BindingSource sPListarProductosBindingSource4;
        private FARMACIA1DataSet15TableAdapters.SP_ListarProductosTableAdapter sP_ListarProductosTableAdapter4;
        private BindingSource bindingSource1;
        private Label Label1;
        private DataGridViewTextBoxColumn iDSUPLIDORDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nOMBREPRODUCTODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fECHAREGISTRODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fECHAVENCIMIENTODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uNIDADMEDIDADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRECIODETALLEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fECHACREACIONPRODUCTODataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDCOMPRASUPLIDORDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDSUPLIDORDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pRECIOUNITARIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fECHACOMPRADataGridViewTextBoxColumn;
    }
}
