using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Added for explicit SQL error handling

namespace Inventario_de_farmacia
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // Usar los miembros correctos definidos en la clase Productos
            try
            {
                // Utilizar pRODUCTOSTableAdapter1 y fARMACIA1DataSet1, que sí existen en la clase
                this.pRODUCTOSTableAdapter1.Fill(this.fARMACIA1DataSet1.PRODUCTOS);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos al cargar productos: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            // Prevents the form from closing completely (e.Cancel = true).
            // Instead, it just hides the form (this.Visible = false).
            // This is useful if you want to reuse the form instance rather than creating a new one.
            e.Cancel = true;
            this.Visible = false;

            // Optional: If you have a main form or a specific form you want to show when this one is hidden,
            // you might add code here to show that other form.
            // Example:
            // if (Application.OpenForms["MainForm"] is MainForm mainForm)
            // {
            //     mainForm.Show();
            // }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}