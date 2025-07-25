namespace Inventario_de_farmacia
{
    partial class datos_para_gurdar
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
            this.DataGridViewComprasRealizadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComprasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewComprasRealizadas
            // 
            this.DataGridViewComprasRealizadas.AllowUserToAddRows = false;
            this.DataGridViewComprasRealizadas.AllowUserToDeleteRows = false;
            this.DataGridViewComprasRealizadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DataGridViewComprasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewComprasRealizadas.Location = new System.Drawing.Point(-38, 112);
            this.DataGridViewComprasRealizadas.Name = "DataGridViewComprasRealizadas";
            this.DataGridViewComprasRealizadas.ReadOnly = true;
            this.DataGridViewComprasRealizadas.RowHeadersWidth = 51;
            this.DataGridViewComprasRealizadas.RowTemplate.Height = 24;
            this.DataGridViewComprasRealizadas.Size = new System.Drawing.Size(644, 181);
            this.DataGridViewComprasRealizadas.TabIndex = 20;
            // 
            // datos_para_gurdar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewComprasRealizadas);
            this.Name = "datos_para_gurdar";
            this.Text = "datos_para_gurdar";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComprasRealizadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewComprasRealizadas;
    }
}