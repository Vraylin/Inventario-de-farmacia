using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_de_farmacia
{
    public partial class Inicio_sesion : Form
    {
        private string RolIngresar;
        public Inicio_sesion(string rol)
        {
            InitializeComponent();
            RolIngresar = rol;
        }
        
        private void Btn_Iniciar_Sessión_Click(object sender, EventArgs e)
        {
            var usuarios = Registro_Usuarios.Validar(text_usuario.Text, text_contraseña.Text);

            if (usuarios != null && usuarios.Rol== RolIngresar)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
            }
        }
        private void Inicio_sesion_Load(object sender, EventArgs e)
        {
            text_usuario.Enabled = true;
            text_usuario.Visible = true;
            text_usuario.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (text_contraseña.UseSystemPasswordChar)
            {
                text_contraseña.UseSystemPasswordChar= false;
                BtnMostrar.Text = "😴";
            }
            else
            {
                text_contraseña.UseSystemPasswordChar= true;
                BtnMostrar.Text = "👀";
            }
        }
    }
}
