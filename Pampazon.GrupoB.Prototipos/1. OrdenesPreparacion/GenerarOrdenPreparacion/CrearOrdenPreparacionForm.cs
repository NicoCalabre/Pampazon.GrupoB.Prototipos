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
            ComboBoxIDCliente.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
        }

        private void BotonCrear_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string idCliente = ComboBoxIDCliente.Text.Trim();        

            PrioridadM prioridad = (PrioridadM)ComboBoxPrioridad.SelectedItem;
            EstadoOrdenM estado = (EstadoOrdenM)ComboBoxEstado.SelectedItem;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(idCliente))
            {
                MessageBox.Show("Por favor, seleccione todos los campos.");
                return;
            }

            // Crear una nueva orden
            OrdenPreparacionM nuevaOrden = new()
            {
                IdCliente = idCliente,
                FechaOrdenRecepcion = DateTime.Now,
                Prioridad = prioridad,
                Estado = estado,
                Productos = new List<ProductoM>()
            };

            // Verificar si se han seleccionado productos
            if (ProductosList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto.");
                return;
            }

            // Obtener los productos seleccionados en el ListView
            foreach (ListViewItem item in ProductosList.CheckedItems)
            {
                ProductoM producto = new ProductoM
                {
                    IDProducto = item.SubItems[0].Text,
                    DescripcionProducto = item.SubItems[1].Text,
                    Cantidad = int.Parse(item.SubItems[2].Text),
                    Ubicacion = item.SubItems[3].Text
                };
                nuevaOrden.Productos.Add(producto);
            }

            CargarProductos();

            // Mostrar un mensaje de confirmación
            MessageBox.Show("La orden de preparación ha sido creada con éxito");

            // Limpiar los campos después de crear la orden
            ComboBoxIDCliente.Text = null;
            ComboBoxPrioridad.Text = null;
            ComboBoxEstado.Text = null;

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
            ComboBoxIDCliente.DisplayMember = "IDCliente";
            ComboBoxIDCliente.ValueMember = "IDCliente";
            ComboBoxIDCliente.DataSource = Modelo.Clientes;

            // Manejar el evento de selección cambiada del ComboBox de clientes
            ComboBoxIDCliente.SelectedIndexChanged += ComboBoxClientes_SelectedIndexChanged;

            // Usar un HashSet para almacenar las prioridades únicas
            var prioridadesUnicas = new HashSet<string>();

            // Cargar opciones en ComboBoxPrioridad
            ComboBoxPrioridad.DataSource = Enum.GetValues(typeof(PrioridadM)).Cast<PrioridadM>().ToList();

            // Cargar opciones en ComboBoxEstado
            ComboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoOrdenM)).Cast<EstadoOrdenM>().ToList();

        }

        private void ComboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID del cliente seleccionado
            string clienteId = (string)ComboBoxIDCliente.SelectedValue;

            // Filtrar los productos por el cliente seleccionado
            var productosFiltrados = Modelo.Productos.FindAll(p => p.IdCliente == clienteId);

            // Actualizar el ComboBox de productos
            ComboBoxIDProducto.DisplayMember = "IDProducto";
            ComboBoxIDProducto.ValueMember = "IDProducto";
            ComboBoxIDProducto.DataSource = productosFiltrados;
        }

        private void CargarProductos()
        {
            ProductosList.Items.Clear();

            foreach (Archivos.Producto producto in Modelo.Productos)
            {

                var fila = new ListViewItem();
                fila.Text = producto.IDProducto.ToString();
                fila.SubItems.Add(producto.IdCliente.ToString());
                fila.SubItems.Add(producto.DescripcionProducto.ToString());
                fila.SubItems.Add(producto.Cantidad.ToString());
                fila.SubItems.Add(producto.Ubicaciones.ToString());

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

            string idProductoSeleccionado = ComboBoxIDProducto.SelectedValue.ToString();
            string cantidadTexto = TxtCantidad.Text;

            if (int.TryParse(cantidadTexto, out int cantidad))
            {
                Producto productoSeleccionado = Modelo.Productos.FirstOrDefault(p => p.IDProducto == idProductoSeleccionado);

                if (productoSeleccionado != null)
                {
                    int cantidadTotalDisponible = productoSeleccionado.Ubicaciones.Sum(u => u.Cantidad);

                    if (cantidad > cantidadTotalDisponible)
                    {
                        MessageBox.Show("La cantidad ingresada excede la cantidad disponible en el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int cantidadRestante = cantidad;

                        foreach (var ubicacion in productoSeleccionado.Ubicaciones)
                        {
                            if (cantidadRestante <= 0) break;

                            int cantidadUsar = Math.Min(ubicacion.Cantidad, cantidadRestante);
                            ubicacion.Cantidad -= cantidadUsar;
                            cantidadRestante -= cantidadUsar;

                            ListViewItem item = new ListViewItem(productoSeleccionado.IDProducto);
                            item.SubItems.Add(productoSeleccionado.IdCliente);
                            item.SubItems.Add(productoSeleccionado.DescripcionProducto);
                            item.SubItems.Add(cantidadUsar.ToString());
                            item.SubItems.Add(ubicacion.Ubicacion);
                            ProductosList.Items.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
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
    }
}
