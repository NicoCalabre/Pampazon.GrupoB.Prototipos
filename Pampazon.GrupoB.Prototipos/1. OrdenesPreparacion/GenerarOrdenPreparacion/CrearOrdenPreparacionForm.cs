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
            ProductosList.Columns.Add("Descripción", 150, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Cantidad", 70, HorizontalAlignment.Left);
            ProductosList.Columns.Add("Ubicación", 100, HorizontalAlignment.Left);


            //Cargamos una lista de todos los id cliente en el combo box.
            foreach (var idCliente in Modelo.Ordenes)
            {
                ComboBoxIDCliente.Items.Add(idCliente.IdCliente.ToString());
            }

            // Usar un HashSet para almacenar las prioridades únicas
            var prioridadesUnicas = new HashSet<string>();

            // Cargar opciones en ComboBoxPrioridad
            ComboBoxPrioridad.DataSource = Enum.GetValues(typeof(PrioridadM)).Cast<PrioridadM>().ToList();

            // Cargar opciones en ComboBoxEstado
            ComboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoOrdenM)).Cast<EstadoOrdenM>().ToList();


            //// Cargar la lista de todas las prioridades en el ComboBox sin duplicados
            //foreach (var prioridad in Modelo.Ordenes)
            //{
            //    // Intentar agregar la prioridad al HashSet
            //    if (prioridadesUnicas.Add(prioridad.Prioridad.ToString()))
            //    {
            //        // Si la prioridad se agregó exitosamente, agregarla también al ComboBox
            //        ComboBoxPrioridad.Items.Add(prioridad.Prioridad.ToString());
            //    }
            //}

            //// Usar un HashSet para almacenar los estados únicos
            //var estadosUnicos = new HashSet<string>();

            //// Cargar la lista de todas las prioridades en el ComboBox sin duplicados
            //foreach (var estado in Modelo.Ordenes)
            //{
            //    // Intentar agregar la prioridad al HashSet
            //    if (estadosUnicos.Add(estado.Estado.ToString()))
            //    {
            //        // Si la prioridad se agregó exitosamente, agregarla también al ComboBox
            //        ComboBoxEstado.Items.Add(estado.Estado.ToString());


            //    }
            //}

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
            string idProducto = TxtIDProducto.Text;
            string descripcionProducto = TxtDescProd.Text;
            if (!int.TryParse(TxtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la cantidad.");
                return;
            }

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(idProducto) ||
                string.IsNullOrWhiteSpace(descripcionProducto) /*||*/
                /*string.IsNullOrWhiteSpace(ubicacion)*/)
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            // Crear un array con los valores de los TextBox
            string[] row = { idProducto, descripcionProducto, cantidad.ToString(), /*ubicacion*/ };

            // Crear un ListViewItem con el array
            ListViewItem item = new ListViewItem(row);

            // Agregar el item al ListBox
            ProductosList.Items.Add(item);

            // Limpiar los TextBox
            TxtIDProducto.Text = string.Empty;
            TxtDescProd.Text = string.Empty;
            TxtCantidad.Text = string.Empty;

        }

        private void EliminarProductoBoton_Click(object sender, EventArgs e)
        {
            // Verificar si hay algún elemento seleccionado en el ListView
            if (ProductosList.CheckedItems.Count > 0)
            {
                // Obtener el elemento seleccionado
                var itemSeleccionado = ProductosList.CheckedItems[0];

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

        private void ComboBoxIDProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
