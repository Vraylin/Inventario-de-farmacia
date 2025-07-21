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
            this.farmacia2DataSet = new Inventario_de_farmacia.Farmacia2DataSet();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTOSTableAdapter = new Inventario_de_farmacia.Farmacia2DataSetTableAdapters.PRODUCTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.farmacia2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // farmacia2DataSet
            // 
            this.farmacia2DataSet.DataSetName = "Farmacia2DataSet";
            this.farmacia2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.farmacia2DataSet;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 695);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmacia2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Farmacia2DataSet farmacia2DataSet;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private Farmacia2DataSetTableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
    }
}