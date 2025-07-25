using System;
using System.Windows.Forms;

namespace Inventario_de_farmacia
{
    public partial class Form1 : Form
    {
        // --- Declaración de instancias de formularios ---
        // Se declaran a nivel de clase para mantener una referencia.
        // Se inicializan a 'null' para saber si ya se han creado o no.
        private Caja _ventanaCaja;
        private Productos _ventanaProductos;
        private Gerente _ventanaGerente;
        // Para Suplidores y Clientes, si quieres que se abran en una nueva ventana modal
        // cada vez, no necesitas declararlos aquí.

        public Form1()
        {
            InitializeComponent();
            // Aseguramos que la ventana principal esté maximizada al iniciar
            this.WindowState = FormWindowState.Maximized;
        }

        // --- Método Auxiliar para Mostrar un Formulario Contenido ---
        // Este método centraliza la lógica para mostrar un formulario
        // y ocultar los demás, evitando repetición de código.
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

        // --- Evento de Carga del Formulario Principal ---
        // Usamos solo un Form1_Load para evitar duplicidad.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Puedes iniciar mostrando una ventana por defecto, por ejemplo, Caja.
            // Esto creará la instancia si no existe y la mostrará.
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
            // Para Suplidores, abrimos una nueva instancia en un diálogo modal cada vez.
            // Esto es bueno si es una ventana para una tarea específica que debe completarse antes de seguir.
            using (Suplidores suplidoresForm = new Suplidores())
            {
                suplidoresForm.ShowDialog();
            }
        }

        private void CajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Para Cajas, si te refieres a la gestión de cajas, también puedes abrirlo como modal.
            // Si este 'Cajas' es el mismo que 'Ventana_Caja' que gestionas con botones,
            // entonces deberías usar la lógica de MostrarVentanaContenida y no ShowDialog.
            // Asumo que este CajasToolStripMenuItem es para una funcionalidad diferente o una ventana independiente.
            BtnCaja_Click(sender, e); // Reutilizamos el botón BtnCaja_Click para mostrar la ventana de Caja
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reutilizamos la lógica del botón BtnProductos_Click
            // Esto evita duplicar código y asegura un comportamiento consistente.
            BtnProductos_Click(sender, e);
        }

        // --- Métodos de Evento Vacíos (Considera eliminarlos si no los usas) ---
        // Estos métodos estaban en tu código original y no tenían lógica.
        // Es una buena práctica eliminarlos si no se van a implementar para mantener el código limpio.

        private void PagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para "Pago" si la implementas
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Lógica para "Button1" si la implementas
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para "Empleados" si la implementas
        }

        // Si tienes dos eventos Form1_Load, revisa tu diseñador.
        // Mantén solo uno que sea el que se asigne al evento Load del formulario.
        // private void Form1_Load_1(object sender, EventArgs e) { /* ... */ }
    }
}