using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Configuration; // Necesitarás añadir esta referencia


namespace Inventario_de_farmacia
{
    public partial class Caja : Form
    {
        // Obtiene la cadena de conexión del archivo App.config
        // Asegúrate de que el nombre "FarmaciaConnectionString" coincida con el nombre en App.config
        string connectionString = ConfigurationManager.ConnectionStrings["FarmaciaConnectionString"].ConnectionString;

        public Caja()
        {
            InitializeComponent();
        }

        private void Caja_Load_1(object sender, EventArgs e)
        {
            // Este método ahora carga los datos en el DataGridView cuando se inicia el formulario.
            try
            {
                this.pRODUCTOSTableAdapter1.Fill(this.fARMACIA1DataSet.PRODUCTOS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de productos: " + ex.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para llenar el TextBox con el ID del producto al hacer clic en una celda
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxComprar.Text = row.Cells["iDPRODUCTODataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void CompraCaja_Click(object sender, EventArgs e)
        {
            // Valida que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(textBoxComprar.Text) || string.IsNullOrWhiteSpace(Cantidad_producto.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del producto y la cantidad.");
                return;
            }

            // Valida que los valores sean numéricos
            if (!int.TryParse(textBoxComprar.Text, out int idProducto) || !int.TryParse(Cantidad_producto.Text, out int cantidad))
            {
                MessageBox.Show("El ID del producto y la cantidad deben ser valores numéricos.");
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Obtener el precio del producto antes de realizar la venta
                    SqlCommand getPriceCmd = new SqlCommand("SELECT PRECIO_DETALLE, STOCK FROM PRODUCTOS WHERE ID_PRODUCTO = @id", conn);
                    getPriceCmd.Parameters.AddWithValue("@id", idProducto);

                    SqlDataReader reader = getPriceCmd.ExecuteReader();
                    decimal precioDetalle = 0;
                    int stockActual = 0;

                    if (reader.Read())
                    {
                        precioDetalle = reader.GetDecimal(0);
                        stockActual = reader.GetInt32(1);
                    }
                    reader.Close();

                    // Validar si el producto existe y si hay suficiente stock (aunque el trigger también lo hace, es bueno validarlo aquí)
                    if (precioDetalle == 0)
                    {
                        MessageBox.Show("Producto no encontrado en la base de datos.");
                        return;
                    }

                    if (cantidad > stockActual)
                    {
                        MessageBox.Show($"No hay suficiente stock disponible para el producto con ID {idProducto}.\nStock actual: {stockActual}");
                        return;
                    }

                    // 2. Insertar una nueva venta en la tabla CAJA
                    // El trigger `TRG_CAJA_STOCK` se encargará de actualizar el stock automáticamente
                    SqlCommand insertSaleCmd = new SqlCommand(
                        "INSERT INTO CAJA (ID_PRODUCTO, CANTIDAD, PRECIO_UNITARIO, ID_EMPLEADO, ID_CLIENTE) VALUES (@idProducto, @cantidad, @precioUnitario, @idEmpleado, @idCliente)", conn);

                    insertSaleCmd.Parameters.AddWithValue("@idProducto", idProducto);
                    insertSaleCmd.Parameters.AddWithValue("@cantidad", cantidad);
                    insertSaleCmd.Parameters.AddWithValue("@precioUnitario", precioDetalle);

                    // Nota: Asume un ID de empleado y cliente fijo. Deberías obtener estos valores dinámicamente.
                    insertSaleCmd.Parameters.AddWithValue("@idEmpleado", 1); // Ejemplo: Empleado con ID 1
                    insertSaleCmd.Parameters.AddWithValue("@idCliente", DBNull.Value); // Cliente ocasional, por eso es DBNull

                    insertSaleCmd.ExecuteNonQuery();

                    decimal total = cantidad * precioDetalle;
                    MessageBox.Show($"Compra realizada con éxito.\nTotal a pagar: {total:C2}", "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. Recargar los datos para actualizar el DataGridView con el nuevo stock
                    this.pRODUCTOSTableAdapter1.Fill(this.fARMACIA1DataSet.PRODUCTOS);
                }
            }
            catch (SqlException ex)
            {
                // Maneja el error específico del trigger si no hay suficiente stock
                if (ex.Message.Contains("No hay suficiente stock"))
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                else
                {
                    MessageBox.Show("Error en la base de datos: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}