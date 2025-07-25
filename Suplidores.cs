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
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fARMACIA1DataSet4.GERENTE' Puede moverla o quitarla según sea necesario.
            this.gERENTETableAdapter.Fill(this.fARMACIA1DataSet4.GERENTE);
            // TODO: esta línea de código carga datos en la tabla 'fARMACIA1DataSet3.COMPRAS_SUPLIDORES' Puede moverla o quitarla según sea necesario.
            this.cOMPRAS_SUPLIDORESTableAdapter.Fill(this.fARMACIA1DataSet3.COMPRAS_SUPLIDORES);

        }
    }
}
