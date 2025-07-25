using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventario_de_farmacia
{
    public partial class Suplidores : Form
    {
        // Cadena de conexión desde App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["FarmaciaConnectionString"].ConnectionString;

        public Suplidores()
        {
            InitializeComponent();
            this.FormClosing += Cerrar;
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga el saldo de la farmacia
                this.sP_ObtenerSaldoFarmaciaTableAdapter.Fill(this.fARMACIA1DataSet11.SP_ObtenerSaldoFarmacia);

                // Carga los productos
                this.sP_ListarProductosTableAdapter.Fill(this.fARMACIA1DataSet8.SP_ListarProductos);
                this.pRODUCTOSTableAdapter.Fill(this.fARMACIA1DataSet6.PRODUCTOS);

                // Carga las compras de suplidores
                this.cOMPRAS_SUPLIDORESTableAdapter.Fill(this.fARMACIA1DataSet3.COMPRAS_SUPLIDORES);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos iniciales: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Evita que el formulario se cierre completamente
            this.Visible = false; // Solo oculta el formulario
        }

        private void Cantidad_producto_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Cantidad_producto.Text, out int temp) && Cantidad_producto.Text.Length > 0)
            {
                MessageBox.Show("Solo se permiten números en el campo Cantidad.", "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cantidad_producto.Clear();
            }
            while (Cantidad_producto.Text.Length > 1 && Cantidad_producto.Text.StartsWith("0") && Cantidad_producto.Text != "0")
            {
                Cantidad_producto.Text = Cantidad_producto.Text.Substring(1);
            }
        }

        private void TextBoxIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBoxIdProducto.Text, out int temp) && TextBoxIdProducto.Text.Length > 0)
            {
                MessageBox.Show("Solo se permiten números en el ID de producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxIdProducto.Clear();
            }
        }

        private void TextBoxIdSuplidor_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBoxIdSuplidor.Text, out int temp) && TextBoxIdSuplidor.Text.Length > 0)
            {
                MessageBox.Show("Solo se permiten números en el ID de suplidor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxIdSuplidor.Clear();
            }
        }

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
                            MessageBox.Show("No se encontró el saldo de la farmacia. Asegúrese de que la tabla SALDO_FARMACIA está inicializada.", "Error de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error de base de datos al obtener el saldo de la farmacia: {ex.Message}\nCódigo SQL: {ex.Number}", "Error de Saldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error inesperado al obtener el saldo de la farmacia: {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return saldo;
        }

        private decimal ObtenerMontoCompra()
        {
            decimal.TryParse(Cantidad_producto.Text, out decimal cantidad);
            int.TryParse(TextBoxIdProducto.Text, out int idProducto);

            if (idProducto <= 0 || cantidad <= 0)
                return 0m;

            decimal precioUnitario = 0m;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PRECIO_MAYOR, PRECIO FROM PRODUCTOS WHERE ID_PRODUCTO = @IdProducto";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["PRECIO_MAYOR"] != DBNull.Value)
                                precioUnitario = Convert.ToDecimal(reader["PRECIO_MAYOR"]);
                            else if (reader["PRECIO"] != DBNull.Value)
                                precioUnitario = Convert.ToDecimal(reader["PRECIO"]);
                        }
                    }
                }
            }
            return cantidad * precioUnitario;
        }

        private void CompraSuplido_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBoxIdSuplidor.Text, out int idSuplidor) || idSuplidor <= 0)
            {
                MessageBox.Show("ID de suplidor inválido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(TextBoxIdProducto.Text, out int idProducto) || idProducto <= 0)
            {
                MessageBox.Show("ID de producto inválido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(Cantidad_producto.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal montoTotalCompra = ObtenerMontoCompra();
            if (montoTotalCompra <= 0)
            {
                MessageBox.Show("No se pudo calcular el monto de la compra. Verifique el ID del producto o la cantidad.", "Error de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal saldoActual = ObtenerSaldoActual();
            if (saldoActual < montoTotalCompra)
            {
                MessageBox.Show($"No se puede realizar la compra. Saldo actual ({saldoActual:C2}) insuficiente para el monto de la compra ({montoTotalCompra:C2}).", "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    decimal precioUnitario = montoTotalCompra / cantidad;

                    SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO COMPRAS_SUPLIDORES (ID_SUPLIDOR, ID_PRODUCTO, CANTIDAD, PRECIO_UNITARIO, FECHA_COMPRA) " +
                        "VALUES (@IdSuplidor, @IdProducto, @Cantidad, @PrecioUnitario, GETDATE())", connection, transaction);

                    insertCmd.Parameters.AddWithValue("@IdSuplidor", idSuplidor);
                    insertCmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    insertCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    insertCmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                    insertCmd.ExecuteNonQuery();

                    SqlCommand updateStockCmd = new SqlCommand(
                        "UPDATE PRODUCTOS SET STOCK = STOCK + @Cantidad WHERE ID_PRODUCTO = @IdProducto", connection, transaction);

                    updateStockCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    updateStockCmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    updateStockCmd.ExecuteNonQuery();

                    SqlCommand updateSaldoCmd = new SqlCommand("SP_ActualizarSaldoFarmacia", connection, transaction);
                    updateSaldoCmd.CommandType = CommandType.StoredProcedure;
                    updateSaldoCmd.Parameters.AddWithValue("@Monto", montoTotalCompra);
                    updateSaldoCmd.Parameters.AddWithValue("@TipoOperacion", "RESTA");
                    updateSaldoCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Compra registrada, stock y saldo actualizados correctamente.", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TextBoxIdSuplidor.Clear();
                    TextBoxIdProducto.Clear();
                    Cantidad_producto.Clear();

                    this.cOMPRAS_SUPLIDORESTableAdapter.Fill(this.fARMACIA1DataSet3.COMPRAS_SUPLIDORES);
                    this.pRODUCTOSTableAdapter.Fill(this.fARMACIA1DataSet6.PRODUCTOS);
                    this.sP_ListarProductosTableAdapter.Fill(this.fARMACIA1DataSet8.SP_ListarProductos);
                    this.sP_ObtenerSaldoFarmaciaTableAdapter.Fill(this.fARMACIA1DataSet11.SP_ObtenerSaldoFarmacia);
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error de base de datos durante la compra: {ex.Message}\nCódigo SQL: {ex.Number}", "Error de Transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ocurrió un error inesperado al procesar la compra: {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DataGridViewSaldoAdtual_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ListodeProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}