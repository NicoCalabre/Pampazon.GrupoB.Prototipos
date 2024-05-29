using Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class CrearOrdenPreparacionForm : Form
    {
        public CrearOrdenPreparacionModelo Modelo;

        private List<ProductoM> productos;
        public CrearOrdenPreparacionForm()
        {
            InitializeComponent();
            // Configurar columnas del ListView
            ProductosList.Columns.Add("ID Producto", 100, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Descripción", 150, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Cantidad", 70, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Ubicación", 100, HorizontalAlignment.Left);

            // Inicializar ComboBoxes con valores de las enumeraciones
            ComboBoxPrioridad.DataSource = Enum.GetValues(typeof(PrioridadM));
            ComboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoOrdenM));

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click_1(object sender, EventArgs e)
        {
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
        }

        private void BotonCrear_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string idCliente = TxtIdCliente.Text.Trim();
            string idOrdenPreparacion = TxtIdOrdenPreparacion.Text.Trim();
            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida, formato DD/MM/AAAA.");
                return;
            }
            PrioridadM prioridad = (PrioridadM)ComboBoxPrioridad.SelectedItem;
            EstadoOrdenM estado = (EstadoOrdenM)ComboBoxEstado.SelectedItem;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(idCliente) ||
                string.IsNullOrWhiteSpace(idOrdenPreparacion))
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            // Crear una nueva orden
            OrdenPreparacionM nuevaOrden = new()
            {
                IdCliente = idCliente,
                IDOrdenPreparacion = idOrdenPreparacion,
                FechaOrdenRecepcion = fecha,
                Prioridad = prioridad,
                Estado = estado,
            };

            // Verificar si se han seleccionado productos
            if (nuevaOrden.Productos.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto.");
                return;
            }

            // Obtener los productos seleccionados en el ListView
            foreach (ListViewItem item in ProductosList.SelectedItems)
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
            TxtIdCliente.Text = string.Empty;
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;

        }

        private void CrearOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            CargarProductos();
        }

        private void CargarProductos()
        {
            ProductosList.Items.Clear();

            // Agregar los productos a la lista
            foreach (var producto in Modelo.ProductoM)
            {

                var fila = new ListViewItem();
                //Sumo los datos de los prodcutos a la ListView del WInforms
                fila.Text = producto.IDProducto;
                fila.SubItems.Add(producto.DescripcionProducto);
                fila.SubItems.Add(producto.Cantidad.ToString());
                fila.SubItems.Add(producto.Ubicacion);

                fila.Tag = producto;

                ProductosList.Items.Add(fila);
            }
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
            // Obtener los valores de los TextBox
            string idProducto = TxtIdProducto.Text;
            string descripcionProducto = TxtDescProd.Text;
            if (!int.TryParse(TxtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la cantidad.");
                return;
            }
            string ubicacion = TxtUbicacion.Text;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(idProducto) ||
                string.IsNullOrWhiteSpace(descripcionProducto) ||
                string.IsNullOrWhiteSpace(ubicacion))
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            // Crear un array con los valores de los TextBox
            string[] row = { idProducto, descripcionProducto, cantidad.ToString(), ubicacion };

            // Crear un ListViewItem con el array
            ListViewItem item = new ListViewItem(row);

            // Agregar el item al ListBox
            ProductosList.Items.Add(item);

            // Limpiar los TextBox
            TxtIdProducto.Clear();
            TxtDescProd.Clear();
            TxtCantidad.Clear();
            TxtUbicacion.Clear();

        }

        private void EliminarProductoBoton_Click(object sender, EventArgs e)
        {
            // Verificar si hay algún elemento seleccionado en el ListView
            if (ProductosList.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                var itemSeleccionado = ProductosList.SelectedItems[0];

                // Obtener la orden de preparación asociada al elemento seleccionado
                var ordenPreparacion = (ProductoM)itemSeleccionado.Tag;

                // Remover la orden de preparación de la lista
                Modelo.ProductoM.Remove(ordenPreparacion);

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
    }
}
