using System;
using System.Configuration; // Necesario para ConfigurationManager
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventario_de_farmacia
{
    public partial class Suplidores : Form
    {
        // Obtiene la cadena de conexión de la configuración de la aplicación (App.config).
        // Asegúrate de que "FarmaciaConnectionString" coincida con el nombre en tu App.config.
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["FarmaciaConnectionString"].ConnectionString;

        public Suplidores()
        {
            InitializeComponent();
            // Suscribe el evento FormClosing al método Cerrar.
            // Esto asegura que el formulario se oculte en lugar de cerrarse.
            this.FormClosing += Cerrar;
        }

        /// <summary>
        /// Se ejecuta cuando el formulario Suplidores se carga.
        /// Carga los datos iniciales en los DataGridViews.
        /// </summary>
        private void Suplidores_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga los datos en los TableAdapters para mostrarlos en los DataGridViews.
                // Es crucial que estos nombres de TableAdapters y DataSets coincidan con los de tu diseñador.
                this.sP_ObtenerSaldoFarmaciaTableAdapter.Fill(this.fARMACIA1DataSet11.SP_ObtenerSaldoFarmacia);
                this.sP_ListarProductosTableAdapter.Fill(this.fARMACIA1DataSet8.SP_ListarProductos);
                this.pRODUCTOSTableAdapter.Fill(this.fARMACIA1DataSet6.PRODUCTOS);
                this.sP_ListarProductosTableAdapter3.Fill(this.fARMACIA1DataSet14.SP_ListarProductos);
                this.sP_ListarProductosTableAdapter4.Fill(this.fARMACIA1DataSet15.SP_ListarProductos);
                this.cOMPRAS_SUPLIDORESTableAdapter.Fill(this.fARMACIA1DataSet3.COMPRAS_SUPLIDORES);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos al cargar datos iniciales: {ex.Message}\nCódigo de error: {ex.Number}",
                                "Error de Carga de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado al cargar datos iniciales: {ex.Message}",
                                "Error General de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento FormClosing para ocultar el formulario en lugar de cerrarlo,
        /// permitiendo su reutilización.
        /// </summary>
        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancela el cierre real del formulario.
            this.Visible = false; // Lo oculta.
        }

        /// <summary>
        /// Valida la entrada en el campo de cantidad de producto para asegurar que solo sean números.
        /// También elimina ceros iniciales innecesarios.
        /// </summary>
        private void Cantidad_producto_TextChanged_1(object sender, EventArgs e)
        {
            // Verifica si el texto no es un número y no está vacío.
            if (!int.TryParse(Cantidad_producto1.Text, out _) && Cantidad_producto1.Text.Length > 0)
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo Cantidad.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cantidad_producto1.Clear(); // Limpia el campo si la entrada es inválida.
            }
            // Elimina ceros iniciales si la cantidad no es simplemente "0".
            while (Cantidad_producto1.Text.Length > 1 && Cantidad_producto1.Text.StartsWith("0") && Cantidad_producto1.Text != "0")
            {
                Cantidad_producto1.Text = Cantidad_producto1.Text.Substring(1);
            }
        }

        /// <summary>
        /// Valida la entrada en el campo de ID de producto para asegurar que solo sean números.
        /// </summary>
        private void TextBoxIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBoxIdProducto.Text, out _) && TextBoxIdProducto.Text.Length > 0)
            {
                MessageBox.Show("Por favor, ingrese solo números en el ID de Producto.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxIdProducto.Clear();
            }
        }

        /// <summary>
        /// Valida la entrada en el campo de ID de suplidor para asegurar que solo sean números.
        /// </summary>
        private void TextBoxIdSuplidor_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBoxIdSuplidor.Text, out _) && TextBoxIdSuplidor.Text.Length > 0)
            {
                MessageBox.Show("Por favor, ingrese solo números en el ID de Suplidor.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxIdSuplidor.Clear();
            }
        }
private bool SuplidorExiste(int idSuplidor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Consulta para contar los suplidores con el ID dado.
                    // Asegúrate de que 'SUPLIDORES' y 'ID_SUPLIDOR' sean los nombres correctos de tu tabla/columna.
                    string query = "SELECT COUNT(1) FROM SUPLIDORES WHERE ID_SUPLIDOR = @IdSuplidor";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdSuplidor", idSuplidor);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Retorna true si se encontró al menos un suplidor.
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error de base de datos al verificar suplidor: {ex.Message}\nCódigo SQL: {ex.Number}",
                                    "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado al verificar suplidor: {ex.Message}",
                                    "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        /// <summary>
        /// Obtiene el saldo actual de la farmacia desde la base de datos.
        /// </summary>
        /// <returns>El saldo actual como decimal, o 0m si hay un error o no se encuentra.</returns>
        private decimal ObtenerSaldoActual()
        {
            decimal saldo = 0m;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ObtenerSaldoFarmacia", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            saldo = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el saldo de la farmacia. Verifique la tabla SALDO_FARMACIA o el SP.",
                                            "Error de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error de base de datos al obtener el saldo: {ex.Message}\nCódigo SQL: {ex.Number}",
                                    "Error de Saldo de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado al obtener el saldo: {ex.Message}",
                                    "Error General de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return saldo;
        }

        /// <summary>
        /// Calcula el monto total de la compra basándose en la cantidad y el precio del producto.
        /// Utiliza PRECIO_MAYOR si está disponible, de lo contrario, usa PRECIO.
        /// </summary>
        /// <returns>El monto total de la compra como decimal, o 0m si hay un error o el producto no se encuentra.</returns>
        private decimal ObtenerMontoCompra()
        {
            // Intenta convertir la cantidad y el ID del producto.
            if (!decimal.TryParse(Cantidad_producto1.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad de producto inválida.", "Error de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0m;
            }
            if (!int.TryParse(TextBoxIdProducto.Text, out int idProducto) || idProducto <= 0)
            {
                MessageBox.Show("ID de producto inválido.", "Error de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0m;
            }

            decimal precioUnitario = 0m;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Obtiene los precios del producto.
                    string query = "SELECT PRECIO_MAYOR, PRECIO FROM PRODUCTOS WHERE ID_PRODUCTO = @IdProducto";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Prioriza el precio al por mayor (PRECIO_MAYOR).
                                if (reader["PRECIO_MAYOR"] != DBNull.Value)
                                    precioUnitario = Convert.ToDecimal(reader["PRECIO_MAYOR"]);
                                else if (reader["PRECIO"] != DBNull.Value)
                                    precioUnitario = Convert.ToDecimal(reader["PRECIO"]);
                                else
                                {
                                    MessageBox.Show("El producto no tiene un precio definido.", "Producto Sin Precio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return 0m;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El ID del producto no se encontró en la base de datos.", "Producto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return 0m;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error de base de datos al obtener el precio del producto: {ex.Message}\nCódigo SQL: {ex.Number}",
                                    "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0m;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado al obtener el precio del producto: {ex.Message}",
                                    "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0m;
                }
            }
            return cantidad * precioUnitario;
        }

        /// <summary>
        /// Maneja el clic en el botón "Comprar Suplido".
        /// Realiza validaciones, verifica el saldo y procesa la transacción de compra.
        /// </summary>
        private void CompraSuplido_Click(object sender, EventArgs e)
        {
            // 1. Validar y obtener el ID del suplidor.
            if (!int.TryParse(TextBoxIdSuplidor.Text, out int idSuplidor) || idSuplidor <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID de suplidor válido (número positivo).",
                                "Validación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. **Validación Crítica**: Verificar si el suplidor existe en la base de datos.
            if (!SuplidorExiste(idSuplidor))
            {
                MessageBox.Show("El ID de suplidor ingresado no existe en el sistema. Por favor, verifique.",
                                "Suplidor Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validar y obtener el ID del producto.
            if (!int.TryParse(TextBoxIdProducto.Text, out int idProducto) || idProducto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido (número positivo).",
                                "Validación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Validar y obtener la cantidad del producto.
            if (!int.TryParse(Cantidad_producto1.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida (número positivo).",
                                "Validación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Calcular el monto total de la compra.
            decimal montoTotalCompra = ObtenerMontoCompra();
            if (montoTotalCompra <= 0)
            {
                // El mensaje de error ya se muestra dentro de ObtenerMontoCompra.
                return;
            }

            // 6. Obtener el saldo actual de la farmacia y verificar si es suficiente.
            decimal saldoActual = ObtenerSaldoActual();
            if (saldoActual < montoTotalCompra)
            {
                MessageBox.Show($"Saldo actual ({saldoActual:C2}) insuficiente para esta compra ({montoTotalCompra:C2}).",
                                "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 7. Iniciar la transacción de base de datos para asegurar que todas las operaciones
            // (insertar compra, actualizar stock, actualizar saldo) se realicen de forma atómica.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // Inicia la transacción.

                try
                {
                    decimal precioUnitarioCalculado = montoTotalCompra / cantidad; // Precio unitario real de la compra.

                    // Inserta el registro de la compra del suplidor.
                    using (SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO COMPRAS_SUPLIDORES (ID_SUPLIDOR, ID_PRODUCTO, CANTIDAD, PRECIO_UNITARIO, FECHA_COMPRA) " +
                        "VALUES (@IdSuplidor, @IdProducto, @Cantidad, @PrecioUnitario, GETDATE())", connection, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@IdSuplidor", idSuplidor);
                        insertCmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        insertCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        insertCmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitarioCalculado);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Actualiza el stock del producto, sumando la cantidad comprada.
                    using (SqlCommand updateStockCmd = new SqlCommand(
                        "UPDATE PRODUCTOS SET STOCK = STOCK + @Cantidad WHERE ID_PRODUCTO = @IdProducto", connection, transaction))
                    {
                        updateStockCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        updateStockCmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        updateStockCmd.ExecuteNonQuery();
                    }

                    // Actualiza el saldo de la farmacia, restando el monto de la compra.
                    using (SqlCommand updateSaldoCmd = new SqlCommand("SP_ActualizarSaldoFarmacia", connection, transaction))
                    {
                        updateSaldoCmd.CommandType = CommandType.StoredProcedure;
                        updateSaldoCmd.Parameters.AddWithValue("@Monto", montoTotalCompra);
                        updateSaldoCmd.Parameters.AddWithValue("@TipoOperacion", "RESTA"); // 'RESTA' para disminuir el saldo.
                        updateSaldoCmd.ExecuteNonQuery();
                    }

                    transaction.Commit(); // Confirma todas las operaciones si no hubo errores.
                    MessageBox.Show("Compra registrada, stock y saldo actualizados con éxito.",
                                    "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpia los campos de entrada para una nueva operación.
                    TextBoxIdSuplidor.Clear();
                    TextBoxIdProducto.Clear();
                    Cantidad_producto1.Clear();

                    // Refresca los datos en los DataGridViews para reflejar los cambios.
                    ActualizarDatosDataGridViews();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback(); // Si hay un error SQL, revierte toda la transacción.
                    MessageBox.Show($"Error de base de datos durante la compra: {ex.Message}\nCódigo SQL: {ex.Number}",
                                    "Error de Transacción DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Si hay cualquier otro error, revierte la transacción.
                    MessageBox.Show($"Ocurrió un error inesperado al procesar la compra: {ex.Message}",
                                    "Error General de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     
        private void DataGridViewSaldoAdtual_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este evento está vinculado al DataGridViewSaldoAdtual.
            // Actualmente no contiene lógica.
        }

        private void ListodeProductos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este evento está vinculado al DataGridView ListodeProductos.
            // Se usa ListodeProductos1_CellContentClick, lo cual sugiere que quizás
            // en algún momento hubo un ListodeProductos sin el '1' y el diseñador
            // generó un nuevo nombre. Es importante que el vínculo en Designer.cs
            // apunte correctamente a este método.
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Este método parece ser un remanente o no está directamente vinculado a un control
            // en tu Designer.cs compartido. Lo mantengo vacío para no eliminar objetos.
        }

        private void ListodeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Similar al caso anterior, este método existe, pero el diseñador parece
            // usar ListodeProductos1_CellContentClick para el DataGridView 'ListodeProductos'.
            // Lo mantengo vacío para no causar problemas con el diseñador.
        }

     
        private void ActualizarDatosDataGridViews()
        {
            try
            {
                // Vuelve a llenar los TableAdapters para refrescar los DataGridViews.
                this.cOMPRAS_SUPLIDORESTableAdapter.Fill(this.fARMACIA1DataSet3.COMPRAS_SUPLIDORES);
                this.pRODUCTOSTableAdapter.Fill(this.fARMACIA1DataSet6.PRODUCTOS);
                this.sP_ListarProductosTableAdapter.Fill(this.fARMACIA1DataSet8.SP_ListarProductos);
                this.sP_ObtenerSaldoFarmaciaTableAdapter.Fill(this.fARMACIA1DataSet11.SP_ObtenerSaldoFarmacia);
                this.sP_ListarProductosTableAdapter3.Fill(this.fARMACIA1DataSet14.SP_ListarProductos);
                this.sP_ListarProductosTableAdapter4.Fill(this.fARMACIA1DataSet15.SP_ListarProductos);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos al actualizar DataGridViews: {ex.Message}\nCódigo SQL: {ex.Number}",
                                "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado al actualizar DataGridViews: {ex.Message}",
                                "Error General de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío si no necesitas funcionalidad específica
        }
    }
}