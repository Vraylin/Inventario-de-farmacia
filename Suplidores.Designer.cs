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
            this.Cantidad_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.DataGridViewComprasRealizadas = new System.Windows.Forms.DataGridView();
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSUPLIDORDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUCTODataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOUNITARIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACOMPRADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.iDPRODUCTODataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSUPLIDORDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAREGISTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADMEDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOMAYORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODETALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPListarProductosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet10 = new Inventario_de_farmacia.FARMACIA1DataSet10();
            this.fARMACIA1DataSet9 = new Inventario_de_farmacia.FARMACIA1DataSet9();
            this.sPListarProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ListarProductosTableAdapter1 = new Inventario_de_farmacia.FARMACIA1DataSet9TableAdapters.SP_ListarProductosTableAdapter();
            this.sP_ListarProductosTableAdapter2 = new Inventario_de_farmacia.FARMACIA1DataSet10TableAdapters.SP_ListarProductosTableAdapter();
            this.DataGridViewSaldoAdtual = new System.Windows.Forms.DataGridView();
            this.saldoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPObtenerSaldoFarmaciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet11 = new Inventario_de_farmacia.FARMACIA1DataSet11();
            this.sP_ObtenerSaldoFarmaciaTableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet11TableAdapters.SP_ObtenerSaldoFarmaciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gERENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciA1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciA1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComprasRealizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerMovimientoDineroBalanceNetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListodeProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaldoAdtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerSaldoFarmaciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Cantidad_producto
            // 
            this.Cantidad_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cantidad_producto.Location = new System.Drawing.Point(163, 46);
            this.Cantidad_producto.Name = "Cantidad_producto";
            this.Cantidad_producto.Size = new System.Drawing.Size(100, 22);
            this.Cantidad_producto.TabIndex = 24;
            this.Cantidad_producto.TextChanged += new System.EventHandler(this.Cantidad_producto_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad de producto";
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
            // DataGridViewComprasRealizadas
            // 
            this.DataGridViewComprasRealizadas.AllowUserToAddRows = false;
            this.DataGridViewComprasRealizadas.AllowUserToDeleteRows = false;
            this.DataGridViewComprasRealizadas.AutoGenerateColumns = false;
            this.DataGridViewComprasRealizadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DataGridViewComprasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewComprasRealizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCOMPRASUPLIDORDataGridViewTextBoxColumn,
            this.iDSUPLIDORDataGridViewTextBoxColumn1,
            this.iDPRODUCTODataGridViewTextBoxColumn2,
            this.cANTIDADDataGridViewTextBoxColumn1,
            this.pRECIOUNITARIODataGridViewTextBoxColumn1,
            this.fECHACOMPRADataGridViewTextBoxColumn1});
            this.DataGridViewComprasRealizadas.DataSource = this.cOMPRASSUPLIDORESBindingSource1;
            this.DataGridViewComprasRealizadas.Location = new System.Drawing.Point(345, 12);
            this.DataGridViewComprasRealizadas.Name = "DataGridViewComprasRealizadas";
            this.DataGridViewComprasRealizadas.ReadOnly = true;
            this.DataGridViewComprasRealizadas.RowHeadersWidth = 51;
            this.DataGridViewComprasRealizadas.RowTemplate.Height = 24;
            this.DataGridViewComprasRealizadas.Size = new System.Drawing.Size(816, 181);
            this.DataGridViewComprasRealizadas.TabIndex = 19;
            this.DataGridViewComprasRealizadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            // iDSUPLIDORDataGridViewTextBoxColumn1
            // 
            this.iDSUPLIDORDataGridViewTextBoxColumn1.DataPropertyName = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn1.HeaderText = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDSUPLIDORDataGridViewTextBoxColumn1.Name = "iDSUPLIDORDataGridViewTextBoxColumn1";
            this.iDSUPLIDORDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDSUPLIDORDataGridViewTextBoxColumn1.Width = 125;
            // 
            // iDPRODUCTODataGridViewTextBoxColumn2
            // 
            this.iDPRODUCTODataGridViewTextBoxColumn2.DataPropertyName = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn2.HeaderText = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDPRODUCTODataGridViewTextBoxColumn2.Name = "iDPRODUCTODataGridViewTextBoxColumn2";
            this.iDPRODUCTODataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDPRODUCTODataGridViewTextBoxColumn2.Width = 125;
            // 
            // cANTIDADDataGridViewTextBoxColumn1
            // 
            this.cANTIDADDataGridViewTextBoxColumn1.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn1.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cANTIDADDataGridViewTextBoxColumn1.Name = "cANTIDADDataGridViewTextBoxColumn1";
            this.cANTIDADDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cANTIDADDataGridViewTextBoxColumn1.Width = 125;
            // 
            // pRECIOUNITARIODataGridViewTextBoxColumn1
            // 
            this.pRECIOUNITARIODataGridViewTextBoxColumn1.DataPropertyName = "PRECIO_UNITARIO";
            this.pRECIOUNITARIODataGridViewTextBoxColumn1.HeaderText = "PRECIO_UNITARIO";
            this.pRECIOUNITARIODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.pRECIOUNITARIODataGridViewTextBoxColumn1.Name = "pRECIOUNITARIODataGridViewTextBoxColumn1";
            this.pRECIOUNITARIODataGridViewTextBoxColumn1.ReadOnly = true;
            this.pRECIOUNITARIODataGridViewTextBoxColumn1.Width = 125;
            // 
            // fECHACOMPRADataGridViewTextBoxColumn1
            // 
            this.fECHACOMPRADataGridViewTextBoxColumn1.DataPropertyName = "FECHA_COMPRA";
            this.fECHACOMPRADataGridViewTextBoxColumn1.HeaderText = "FECHA_COMPRA";
            this.fECHACOMPRADataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fECHACOMPRADataGridViewTextBoxColumn1.Name = "fECHACOMPRADataGridViewTextBoxColumn1";
            this.fECHACOMPRADataGridViewTextBoxColumn1.ReadOnly = true;
            this.fECHACOMPRADataGridViewTextBoxColumn1.Width = 125;
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
            this.iDPRODUCTODataGridViewTextBoxColumn3,
            this.iDSUPLIDORDataGridViewTextBoxColumn2,
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1,
            this.pRECIODataGridViewTextBoxColumn,
            this.sTOCKDataGridViewTextBoxColumn,
            this.fECHAREGISTRODataGridViewTextBoxColumn,
            this.fECHAVENCIMIENTODataGridViewTextBoxColumn,
            this.uNIDADMEDIDADataGridViewTextBoxColumn,
            this.pRECIOMAYORDataGridViewTextBoxColumn,
            this.pRECIODETALLEDataGridViewTextBoxColumn,
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn,
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn});
            this.ListodeProductos.DataSource = this.sPListarProductosBindingSource2;
            this.ListodeProductos.Location = new System.Drawing.Point(3, 214);
            this.ListodeProductos.Name = "ListodeProductos";
            this.ListodeProductos.ReadOnly = true;
            this.ListodeProductos.RowHeadersWidth = 51;
            this.ListodeProductos.RowTemplate.Height = 24;
            this.ListodeProductos.Size = new System.Drawing.Size(878, 390);
            this.ListodeProductos.TabIndex = 23;
            this.ListodeProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListodeProductos_CellContentClick);
            // 
            // iDPRODUCTODataGridViewTextBoxColumn3
            // 
            this.iDPRODUCTODataGridViewTextBoxColumn3.DataPropertyName = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn3.HeaderText = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.iDPRODUCTODataGridViewTextBoxColumn3.Name = "iDPRODUCTODataGridViewTextBoxColumn3";
            this.iDPRODUCTODataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDPRODUCTODataGridViewTextBoxColumn3.Width = 125;
            // 
            // iDSUPLIDORDataGridViewTextBoxColumn2
            // 
            this.iDSUPLIDORDataGridViewTextBoxColumn2.DataPropertyName = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn2.HeaderText = "ID_SUPLIDOR";
            this.iDSUPLIDORDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDSUPLIDORDataGridViewTextBoxColumn2.Name = "iDSUPLIDORDataGridViewTextBoxColumn2";
            this.iDSUPLIDORDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDSUPLIDORDataGridViewTextBoxColumn2.Width = 125;
            // 
            // nOMBREPRODUCTODataGridViewTextBoxColumn1
            // 
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1.HeaderText = "NOMBRE_PRODUCTO";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1.Name = "nOMBREPRODUCTODataGridViewTextBoxColumn1";
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1.ReadOnly = true;
            this.nOMBREPRODUCTODataGridViewTextBoxColumn1.Width = 125;
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
            // fECHACREACIONPRODUCTODataGridViewTextBoxColumn
            // 
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREACION_PRODUCTO";
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.HeaderText = "FECHA_CREACION_PRODUCTO";
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.Name = "fECHACREACIONPRODUCTODataGridViewTextBoxColumn";
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHACREACIONPRODUCTODataGridViewTextBoxColumn.Width = 125;
            // 
            // uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn
            // 
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "USUARIO_CREACION_PRODUCTO";
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn.HeaderText = "USUARIO_CREACION_PRODUCTO";
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn.Name = "uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn";
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn.ReadOnly = true;
            this.uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn.Width = 125;
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
            // fARMACIA1DataSet9
            // 
            this.fARMACIA1DataSet9.DataSetName = "FARMACIA1DataSet9";
            this.fARMACIA1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPListarProductosBindingSource1
            // 
            this.sPListarProductosBindingSource1.DataMember = "SP_ListarProductos";
            this.sPListarProductosBindingSource1.DataSource = this.fARMACIA1DataSet9;
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
            this.DataGridViewSaldoAdtual.Location = new System.Drawing.Point(887, 214);
            this.DataGridViewSaldoAdtual.Name = "DataGridViewSaldoAdtual";
            this.DataGridViewSaldoAdtual.ReadOnly = true;
            this.DataGridViewSaldoAdtual.RowHeadersWidth = 51;
            this.DataGridViewSaldoAdtual.RowTemplate.Height = 24;
            this.DataGridViewSaldoAdtual.Size = new System.Drawing.Size(264, 390);
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
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1173, 616);
            this.Controls.Add(this.DataGridViewSaldoAdtual);
            this.Controls.Add(this.ListodeProductos);
            this.Controls.Add(this.DataGridViewComprasRealizadas);
            this.Controls.Add(this.TextBoxIdSuplidor);
            this.Controls.Add(this.NombreIdSuplidor);
            this.Controls.Add(this.Cantidad_producto);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComprasRealizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPRASSUPLIDORESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVerMovimientoDineroBalanceNetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListodeProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPListarProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSaldoAdtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerSaldoFarmaciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        private void Cantidad_producto_TextChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox Cantidad_producto;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridView DataGridViewComprasRealizadas;
        private System.Windows.Forms.BindingSource sPVerMovimientoDineroBalanceNetoBindingSource;
        private FARMACIA1DataSet5 fARMACIA1DataSet5;
        private FARMACIA1DataSet5TableAdapters.SP_VerMovimientoDinero_BalanceNetoTableAdapter sP_VerMovimientoDinero_BalanceNetoTableAdapter;
        private FARMACIA1DataSet6 fARMACIA1DataSet6;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private FARMACIA1DataSet6TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private FARMACIA1DataSet7 fARMACIA1DataSet7;
        private System.Windows.Forms.BindingSource cOMPRASSUPLIDORESBindingSource1;
        private FARMACIA1DataSet7TableAdapters.COMPRAS_SUPLIDORESTableAdapter cOMPRAS_SUPLIDORESTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOMPRASUPLIDORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSUPLIDORDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOUNITARIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACOMPRADataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSUPLIDORDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREPRODUCTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAREGISTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVENCIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDADMEDIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOMAYORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODETALLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSUARIOCREACIONPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DataGridViewSaldoAdtual;
        private FARMACIA1DataSet11 fARMACIA1DataSet11;
        private System.Windows.Forms.BindingSource sPObtenerSaldoFarmaciaBindingSource;
        private FARMACIA1DataSet11TableAdapters.SP_ObtenerSaldoFarmaciaTableAdapter sP_ObtenerSaldoFarmaciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoActualDataGridViewTextBoxColumn;
    }
}