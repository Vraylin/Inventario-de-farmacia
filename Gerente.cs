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

        public static object TabPages { get; internal set; }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void Gerente_Load(object sender, EventArgs e)
        {

        }
    }
}
