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
            this.G_Compra_Suplidores = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DataGridViewVentaDia = new System.Windows.Forms.DataGridView();
            this.cAJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fARMACIA1DataSet2 = new Inventario_de_farmacia.FARMACIA1DataSet2();
            this.Label1Compra = new System.Windows.Forms.Label();
            this.cAJATableAdapter = new Inventario_de_farmacia.FARMACIA1DataSet2TableAdapters.CAJATableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVentaDia)).BeginInit();
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
            this.gestiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MenuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.ofertasToolStripMenuItem,
            this.caducacionToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(119, 30);
            this.archivoToolStripMenuItem.Text = "producto";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.ArchivoToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.stockToolStripMenuItem.Text = "stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // ofertasToolStripMenuItem
            // 
            this.ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            this.ofertasToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.ofertasToolStripMenuItem.Text = "Ofertas";
            // 
            // caducacionToolStripMenuItem
            // 
            this.caducacionToolStripMenuItem.Name = "caducacionToolStripMenuItem";
            this.caducacionToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
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
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.suplidoresToolStripMenuItem.Text = "Suplidores";
            this.suplidoresToolStripMenuItem.Click += new System.EventHandler(this.suplidoresToolStripMenuItem_Click);
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
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.pagoToolStripMenuItem.Text = "Pagos";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
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
            // DataGridViewVentaDia
            // 
            this.DataGridViewVentaDia.AllowUserToAddRows = false;
            this.DataGridViewVentaDia.AllowUserToDeleteRows = false;
            this.DataGridViewVentaDia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DataGridViewVentaDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1043, 402);
            this.Controls.Add(this.Label1Compra);
            this.Controls.Add(this.DataGridViewVentaDia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.G_Compra_Suplidores);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);

            this.ClientSize = new System.Drawing.Size(608, 330);

            this.Name = "Gerente";
            this.Text = "Gerente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Gerente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVentaDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARMACIA1DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caducacionToolStripMenuItem;
        private System.Windows.Forms.Button G_Compra_Suplidores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DataGridViewVentaDia;
        private System.Windows.Forms.Label Label1Compra;
        private FARMACIA1DataSet2 fARMACIA1DataSet2;
        private System.Windows.Forms.BindingSource cAJABindingSource;
        private FARMACIA1DataSet2TableAdapters.CAJATableAdapter cAJATableAdapter;
    }
}