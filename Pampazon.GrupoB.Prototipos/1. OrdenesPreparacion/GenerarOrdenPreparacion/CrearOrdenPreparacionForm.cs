using Pampazon.GrupoB.Prototipos._1._OrdenesPreparacion.GenerarOrdenPreparacion;
using Pampazon.GrupoB.Prototipos.Archivos;
using Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class CrearOrdenPreparacionForm : Form
    {
        public CrearOrdenPreparacionModelo Modelo;
        public CrearOrdenPreparacionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click_1(object sender, EventArgs e)
        {
            ComboBoxIDCliente.Text = null;
            ComboBoxIDProducto.Text = null;
            TxtCantidad.Text = string.Empty;
            ComboBoxPrioridad.SelectedIndex = -1;
            ComboBoxEstado.SelectedIndex = -1;
            ProductosList.Items.Clear();
        }

        private void ComboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID del cliente seleccionado
            string clienteId = (string)ComboBoxIDCliente.SelectedValue;

            // Filtrar los productos por el cliente seleccionado
            var productosFiltrados = Modelo.OrdenesPreparacion
                                           .SelectMany(op => op.Productos)
                                           .Where(p => p.IdCliente == clienteId)
                                           .Distinct()
                                           .ToList();

            // Actualizar el ComboBox de productos
            ComboBoxIDProducto.DisplayMember = "IDProducto";
            ComboBoxIDProducto.ValueMember = "IDProducto";
            ComboBoxIDProducto.DataSource = productosFiltrados;
        }

        private void BotonCrear_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los ComboBox
            string idCliente = ComboBoxIDCliente.Text.Trim();
            var prioridad = (_1._OrdenesPreparacion.GenerarOrdenPreparacion.PrioridadOrden)ComboBoxPrioridad.SelectedItem;
            var estado = (_1._OrdenesPreparacion.GenerarOrdenPreparacion.EstadoOrden)ComboBoxEstado.SelectedItem;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(idCliente) || prioridad == null || estado == null)
            {
                MessageBox.Show("Por favor, seleccione todos los campos.");
                return;
            }

            // Verificar si se han seleccionado productos
            if (ProductosList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto.");
                return;
            }

            var clienteSeleccionado = Modelo.ObtenerClientesUnicos().FirstOrDefault(c => c.IDCliente == idCliente);
            string descripcionCliente = clienteSeleccionado?.DescripcionCliente ?? string.Empty;

            // Generar un nuevo ID de orden único
            string nuevoIdOrden = GenerarNuevoIDOrden();

            // Crear una nueva orden de preparación
            var nuevaOrden = new _1._OrdenesPreparacion.GenerarOrdenPreparacion.OrdenPreparacion()
            {
                IDOrdenPreparacion = nuevoIdOrden,
                IdCliente = idCliente,
                DescripcionCliente = descripcionCliente,
                FechaOrdenRecepcion = DateTime.Now,
                Prioridad = prioridad,
                Estado = estado,
                Productos = new List<_1._OrdenesPreparacion.GenerarOrdenPreparacion.Producto>()
            };

            // Obtener los productos seleccionados en el ListView
            foreach (ListViewItem item in ProductosList.CheckedItems)
            {
                string idProducto = item.SubItems[0].Text;
                string descripcionProducto = item.SubItems[2].Text;
                string cantidadProductoText = item.SubItems[3].Text;
                string ubicacion = item.SubItems[4].Text;

                if (!int.TryParse(cantidadProductoText, out int cantidadProducto))
                {
                    MessageBox.Show($"La cantidad del producto '{descripcionProducto}' no es válida: '{cantidadProductoText}'.");
                    return;
                }

                var producto = new _1._OrdenesPreparacion.GenerarOrdenPreparacion.Producto
                {
                    IDProducto = idProducto,
                    IdCliente = idCliente,
                    DescripcionProducto = descripcionProducto,
                    Cantidad = cantidadProducto,
                    Ubicaciones = new List<_1._OrdenesPreparacion.GenerarOrdenPreparacion.ProductoDetalleStock>
                {
                    new _1._OrdenesPreparacion.GenerarOrdenPreparacion.ProductoDetalleStock
                    {
                        Ubicacion = ubicacion,
                        Cantidad = cantidadProducto
                    }
                }
                };

                nuevaOrden.Productos.Add(producto);
            }

            // Agregar la nueva orden a la lista principal
            Modelo.OrdenesPreparacion.Add(nuevaOrden);
            Modelo.AltaOrdenPreparacion(nuevaOrden);

            // Mostrar un mensaje de confirmación
            //MessageBox.Show("La orden de preparación ha sido creada con éxito");
            MessageBox.Show($"La orden de preparación '{nuevaOrden.IDOrdenPreparacion}' ha sido creada con éxito.");

            // Limpiar los campos después de crear la orden
            BotonLimpiar_Click_1(sender, e);
        }


        // Método para generar un nuevo ID de orden único
        private string GenerarNuevoIDOrden()
        {
            // Obtener el último ID de orden si existe
            var ultimaOrden = Modelo.OrdenesPreparacion.OrderByDescending(op => op.IDOrdenPreparacion).FirstOrDefault();
            if (ultimaOrden == null)
            {
                return "OP-0001";
            }

            // Extraer el número del ID de orden actual y generar el nuevo ID
            string ultimoId = ultimaOrden.IDOrdenPreparacion;
            int numero = int.Parse(ultimoId.Substring(3));
            string nuevoId = "OP-" + (numero + 1).ToString("D4");
            return nuevoId;
        }

        private void CrearOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            // Configurar columnas del ListView
            ProductosList.Columns.Add("ID Producto", 100, HorizontalAlignment.Left);
            ProductosList.Columns.Add("ID Cliente", 100, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Descripción", 150, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Cantidad", 70, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Ubicación", 100, HorizontalAlignment.Left);


            // Llenar el ComboBox de clientes
            Modelo.LlenarComboBoxClientes(ComboBoxIDCliente);

            // Manejar el evento de selección cambiada del ComboBox de clientes
            ComboBoxIDCliente.SelectedIndexChanged += ComboBoxClientes_SelectedIndexChanged;

            // Cargar opciones en ComboBoxPrioridad
            ComboBoxPrioridad.DataSource = Enum.GetValues(typeof(_1._OrdenesPreparacion.GenerarOrdenPreparacion.PrioridadOrden)).Cast<_1._OrdenesPreparacion.GenerarOrdenPreparacion.PrioridadOrden>().ToList();

            // Cargar opciones en ComboBoxEstado
            ComboBoxEstado.DataSource = Enum.GetValues(typeof(_1._OrdenesPreparacion.GenerarOrdenPreparacion.EstadoOrden)).Cast<_1._OrdenesPreparacion.GenerarOrdenPreparacion.EstadoOrden>().ToList();

        }

        private void CargarProductos()
        {
            ProductosList.Items.Clear();

            // Recolectar todos los productos de las órdenes de preparación
            var productos = Modelo.OrdenesPreparacion.SelectMany(op => op.Productos).Distinct();

            foreach (var producto in productos)
            {
                var fila = new ListViewItem();
                fila.Text = producto.IDProducto.ToString();
                fila.SubItems.Add(producto.IdCliente.ToString());
                fila.SubItems.Add(producto.DescripcionProducto);
                fila.SubItems.Add(producto.Cantidad.ToString());

                // Convertir ubicaciones a una cadena para mostrar
                var ubicaciones = string.Join(", ", producto.Ubicaciones.Select(u => $"{u.Ubicacion} ({u.Cantidad})"));
                fila.SubItems.Add(ubicaciones);

                fila.Tag = producto;
                ProductosList.Items.Add(fila);
            }

            ProductosList.Refresh();

        }

        private void ComboBoxPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProductosList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarProductoBoton_Click(object sender, EventArgs e)
        {
            // Obtener el ID del producto seleccionado
            string idProductoSeleccionado = ComboBoxIDProducto.SelectedValue.ToString();
            // Obtener la cantidad ingresada
            string cantidadTexto = TxtCantidad.Text;

            // Verificar si la cantidad es un número válido
            if (int.TryParse(cantidadTexto, out int cantidad))
            {
                // Buscar el producto seleccionado en el modelo
                _1._OrdenesPreparacion.GenerarOrdenPreparacion.Producto productoSeleccionado = Modelo.OrdenesPreparacion
                                                       .SelectMany(op => op.Productos)
                                                       .FirstOrDefault(p => p.IDProducto == idProductoSeleccionado);

                if (productoSeleccionado != null)
                {
                    // Calcular la cantidad total disponible en las ubicaciones
                    int cantidadTotalDisponible = productoSeleccionado.Ubicaciones.Sum(u => u.Cantidad);

                    if (cantidad > cantidadTotalDisponible)
                    {
                        // Mostrar mensaje de error si la cantidad ingresada excede la cantidad disponible
                        MessageBox.Show("La cantidad ingresada excede la cantidad disponible en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int cantidadRestante = cantidad;

                        // Iterar sobre las ubicaciones del producto seleccionado
                        foreach (var ubicacion in productoSeleccionado.Ubicaciones)
                        {
                            if (cantidadRestante <= 0) break;

                            // Calcular la cantidad a usar de la ubicación actual
                            int cantidadUsar = Math.Min(ubicacion.Cantidad, cantidadRestante);
                            ubicacion.Cantidad -= cantidadUsar; // Restar la cantidad usada de la ubicación
                            cantidadRestante -= cantidadUsar; // Restar la cantidad usada de la cantidad restante

                            // Crear un nuevo elemento para la ListView
                            ListViewItem item = new ListViewItem(productoSeleccionado.IDProducto);
                            item.SubItems.Add(productoSeleccionado.IdCliente);
                            item.SubItems.Add(productoSeleccionado.DescripcionProducto);
                            item.SubItems.Add(cantidadUsar.ToString());
                            item.SubItems.Add(ubicacion.Ubicacion);
                            ProductosList.Items.Add(item); // Agregar el elemento a la ListView
                        }
                    }
                }
                else
                {
                    // Mostrar mensaje de error si el producto no se encuentra
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje de error si la cantidad ingresada no es válida
                MessageBox.Show("Cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarProductoBoton_Click(object sender, EventArgs e)
        {
            // Verificar si hay algún elemento seleccionado en el ListView
            if (ProductosList.CheckedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                var itemSeleccionado = ProductosList.CheckedItems[0];

                // Remover el elemento del ListView
                ProductosList.Items.Remove(itemSeleccionado);
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminarlo.");
            }
        }

        private void TxtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxIDProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxIDCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
