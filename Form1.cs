using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario_de_farmacia
{
    public partial class Form1 : Form
    {
        Caja Ventana_Caja = new Caja();
        Productos Ventana_productos = new Productos();
        Gerente Ventana_Gerente = new Gerente();
        public Form1()
        {
            InitializeComponent();
        
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {

     


            var login = new Inicio_sesion("Caja");
            if (login.ShowDialog() == DialogResult.OK)
            {
                var FmCaja = new Caja();
                FmCaja.Show();
            }

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Ventana_productos.Visible = true;
        }

        private void BtnGerente_Click(object sender, EventArgs e)
        {

            var login = new Inicio_sesion("Gerente");
            if (login.ShowDialog() == DialogResult.OK)
            {
                
                var FmGerente=new Gerente();
                FmGerente.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
