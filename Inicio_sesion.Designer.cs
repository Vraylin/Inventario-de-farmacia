namespace Inventario_de_farmacia
{
    partial class Inicio_sesion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_contraseña = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.Btn_Iniciar_Sessión = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de sessión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(217, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(205, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // text_contraseña
            // 
            this.text_contraseña.Location = new System.Drawing.Point(193, 165);
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.Size = new System.Drawing.Size(138, 26);
            this.text_contraseña.TabIndex = 4;
            this.text_contraseña.UseSystemPasswordChar = true;
            this.text_contraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(193, 78);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(138, 26);
            this.text_usuario.TabIndex = 2;
            this.text_usuario.TextChanged += new System.EventHandler(this.text_usuario_TextChanged);
            // 
            // Btn_Iniciar_Sessión
            // 
            this.Btn_Iniciar_Sessión.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.Btn_Iniciar_Sessión.Location = new System.Drawing.Point(175, 213);
            this.Btn_Iniciar_Sessión.Name = "Btn_Iniciar_Sessión";
            this.Btn_Iniciar_Sessión.Size = new System.Drawing.Size(172, 34);
            this.Btn_Iniciar_Sessión.TabIndex = 6;
            this.Btn_Iniciar_Sessión.Text = "Iniciar sessión";
            this.Btn_Iniciar_Sessión.UseVisualStyleBackColor = true;
            this.Btn_Iniciar_Sessión.Click += new System.EventHandler(this.Btn_Iniciar_Sessión_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(337, 165);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(28, 26);
            this.BtnMostrar.TabIndex = 7;
            this.BtnMostrar.Text = "👀";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // Inicio_sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 328);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.Btn_Iniciar_Sessión);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.text_contraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio_sesion";
            this.Text = "Inicio_sesion";
            this.Load += new System.EventHandler(this.Inicio_sesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_contraseña;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.Button Btn_Iniciar_Sessión;
        private System.Windows.Forms.Button BtnMostrar;
    }
}