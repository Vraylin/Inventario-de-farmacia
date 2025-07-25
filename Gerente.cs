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
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void Gerente_Load(object sender, EventArgs e)
        {
            this.cAJATableAdapter.Fill(this.fARMACIA1DataSet2.CAJA);

        }

        private void ArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label1Compra_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
