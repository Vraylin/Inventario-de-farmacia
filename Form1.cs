using System;
using System.Windows.Forms;

namespace Inventario_de_farmacia
{
    public partial class Form1 : Form
    {
        // --- Declaración de instancias de formularios ---
        
        private Caja _ventanaCaja;
        private Productos _ventanaProductos;
        private Gerente _ventanaGerente;
   

        public Form1()
        {
            InitializeComponent();
        
            this.WindowState = FormWindowState.Maximized;
        }

        // --- Método Auxiliar para Mostrar un Formulario Contenido ---
    
        private void MostrarVentanaContenida(Form ventanaAMostrar)
        {
            // Oculta todas las ventanas "secundarias" gestionadas por Form1
            if (_ventanaCaja != null && !_ventanaCaja.IsDisposed)
            {
                _ventanaCaja.Hide(); // Usar Hide() para mantenerla en memoria si se va a reutilizar
            }
            if (_ventanaProductos != null && !_ventanaProductos.IsDisposed)
            {
                _ventanaProductos.Hide();
            }
            if (_ventanaGerente != null && !_ventanaGerente.IsDisposed)
            {
                _ventanaGerente.Hide();
            }

            // Muestra la ventana deseada
            if (ventanaAMostrar != null)
            {
                ventanaAMostrar.Show(); // Usar Show() para mostrarla
                ventanaAMostrar.BringToFront(); // Asegura que esté al frente
                ventanaAMostrar.WindowState = FormWindowState.Maximized; // Maximiza la ventana dentro de Form1 si es posible
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.sP_ListarProductosTableAdapter.Fill(this.fARMACIA1DataSet16.SP_ListarProductos);
            BtnCaja_Click(sender, e);
        }

        // --- Eventos de Botones (Panel lateral, etc.) ---

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            // Si la instancia de _ventanaCaja no existe o ya se cerró, créala de nuevo.
            if (_ventanaCaja == null || _ventanaCaja.IsDisposed)
            {
                _ventanaCaja = new Caja();
                // Puedes configurar _ventanaCaja como un formulario hijo si Form1 es un contenedor MDI
                // _ventanaCaja.MdiParent = this; // Descomentar si Form1.IsMdiContainer = true
            }
            MostrarVentanaContenida(_ventanaCaja);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            // Si la instancia de _ventanaProductos no existe o ya se cerró, créala de nuevo.
            if (_ventanaProductos == null || _ventanaProductos.IsDisposed)
            {
                _ventanaProductos = new Productos();
                // _ventanaProductos.MdiParent = this; // Descomentar si Form1.IsMdiContainer = true
            }
            MostrarVentanaContenida(_ventanaProductos);
        }

        private void BtnGerente_Click(object sender, EventArgs e)
        {
            // Si la instancia de _ventanaGerente no existe o ya se cerró, créala de nuevo.
            if (_ventanaGerente == null || _ventanaGerente.IsDisposed)
            {
                _ventanaGerente = new Gerente();
                // _ventanaGerente.MdiParent = this; // Descomentar si Form1.IsMdiContainer = true
            }
            MostrarVentanaContenida(_ventanaGerente);
        }

        // --- Eventos de ToolStripMenuItems (Menú superior) ---

        private void SuplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Suplidores suplidoresForm = new Suplidores())
            {
                suplidoresForm.ShowDialog();
            }
        }

        private void CajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnCaja_Click(sender, e); // Reutilizamos el botón BtnCaja_Click para mostrar la ventana de Caja
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reutilizamos la lógica del botón BtnProductos_Click
            // Esto evita duplicar código y asegura un comportamiento consistente.
            BtnProductos_Click(sender, e);
        }

       
        private void PagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            }

        private void Button1_Click(object sender, EventArgs e)
        {
            }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        }
}