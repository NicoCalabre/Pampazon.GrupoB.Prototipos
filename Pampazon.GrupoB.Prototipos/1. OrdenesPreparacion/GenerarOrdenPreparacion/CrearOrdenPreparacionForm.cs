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
        public CrearOrdenPreparacionForm()
        {
            InitializeComponent();

            OrdenesPreparacionList.Columns.Add("Producto", 100, HorizontalAlignment.Left);
            OrdenesPreparacionList.Columns.Add("Cantidad", 100, HorizontalAlignment.Left);
            OrdenesPreparacionList.Columns.Add("ID Orden Preparación", 100, HorizontalAlignment.Left);
            OrdenesPreparacionList.Columns.Add("ID Cliente", 100, HorizontalAlignment.Left);
            OrdenesPreparacionList.Columns.Add("Fecha", 100, HorizontalAlignment.Left);
            OrdenesPreparacionList.Columns.Add("Estado", 100, HorizontalAlignment.Left);
            OrdenesPreparacionList.Columns.Add("Prioridad", 100, HorizontalAlignment.Left);

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
            if (string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenPreparacion.Text))
            {
                MessageBox.Show("El id orden preparación no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            {
                MessageBox.Show("La fecha no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(ComboBoxPrioridad.Text))
            {
                MessageBox.Show("La prioridad no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(ComboBoxEstado.Text))
            {
                MessageBox.Show("El estado no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCantidad.Text))
            {
                MessageBox.Show("La cantidad no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdProducto.Text))
            {
                MessageBox.Show("El id producto no puede estar vacío");
                return;
            }

            if (!int.TryParse(this.TxtCantidad.Text, out var espaciondisponible))
            {
                MessageBox.Show("La cantidad debe ser un valor númerico");
                return;
            }

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
                return;
            }

            MessageBox.Show("La orden de preparación ha sido creada con éxito");
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
        }

        private void CrearOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            // Cargo los estados posibles al combobox
            ComboBoxEstado.Items.Add(EstadoOrdenM.Pendiente.ToString());
            ComboBoxEstado.Items.Add(EstadoOrdenM.EnSeleccion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrdenM.Seleccionada.ToString());

            // Cargo las prioridades posibles al combobox
            ComboBoxPrioridad.Items.Add(PrioridadM.Baja.ToString());
            ComboBoxPrioridad.Items.Add(PrioridadM.Media.ToString());
            ComboBoxPrioridad.Items.Add(PrioridadM.Alta.ToString());

            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesPreparacion();
        }

        private void CargarOrdenesPreparacion()
        {
            // Borramos todo el listado de órdenes para volver a cargarlo
            // Esto asegura que al agregar una nueva orden, se actualice la lista
            OrdenesPreparacionList.Items.Clear();

            // Obtener los valores ingresados por el usuario en los TextBoxs y los ComboBoxs
            string idOrdenAFiltrar = this.TxtIdOrdenPreparacion.Text.Trim();
            string estadoAFiltrar = this.ComboBoxEstado.Text.Trim();
            string fechaAFiltrar = this.TxtFecha.Text.Trim();
            string prioridadAFiltrar = this.ComboBoxPrioridad.Text.Trim();

            // Filtrar las órdenes según los campos ingresados por el usuario
            // Si ingreso todos, filtra por todos
            // Si no ingreso nada, trae todo el listado de ordenes de preparacion
            var ordenesFiltradas = Modelo.OrdenesPreparacionM
                .Where(orden =>
                    (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                    (string.IsNullOrEmpty(estadoAFiltrar) || orden.Estado.ToString() == estadoAFiltrar) &&
                    (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaOrdenRecepcion.Date == DateTime.Parse(fechaAFiltrar).Date) &&
                    (string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar))
                .ToList();

            // Agregar las órdenes filtradas a la lista
            foreach (var ordenPreparacion in ordenesFiltradas)
            {
                var fila = new ListViewItem();
                //Sumo los datos de las ordenes a la ListView del WInforms
                fila.Text = ordenPreparacion.IDOrdenPreparacion.ToString();
                fila.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                fila.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                fila.SubItems.Add(ordenPreparacion.Estado.ToString());
                fila.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                fila.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());

                //string.Join lo que hace es concatenar elementos separados por ";"
                //Select( producto => ) lo que hace es recorrer el listado de productos
                //De ese listado de productos obtiene los datos relevantes y los concatena separandolos por ";"
                var DescripcionProductosOrden = string.Join("; ",
                                                            ordenPreparacion.Productos.Select(
                                                                                                producto =>
                                                                                                $"IDProducto: {producto.IDProducto}, " +
                                                                                                $"DescripcionProducto: {producto.DescripcionProducto}, " +
                                                                                                $"Cantidad: {producto.Cantidad}, " +
                                                                                                $"Ubicacion: {producto.Ubicacion}"
                                                                                             )
                                                            );
                //Sumo esas descripciones de producto a la columna de Productos en el WinForms
                fila.SubItems.Add(DescripcionProductosOrden);

                fila.Tag = ordenPreparacion;

                OrdenesPreparacionList.Items.Add(fila);
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

        private void OrdenesPreparacionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string producto = TxtIdProducto.Text;
            string cantidad = TxtCantidad.Text;

            string idOrden = TxtIdOrdenPreparacion.Text;
            string idCliente = TxtIdCliente.Text;
            string fecha = TxtFecha.Text;
            string estado = ComboBoxEstado.Text;
            string prioridad = ComboBoxPrioridad.Text;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(producto) ||
                string.IsNullOrWhiteSpace(cantidad) ||
                string.IsNullOrWhiteSpace(idOrden) ||
                string.IsNullOrWhiteSpace(idCliente) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(estado) ||
                string.IsNullOrWhiteSpace(prioridad))
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            // Crear una cadena concatenada con los valores de los TextBox
            //string item = $"{producto}, {cantidad}, {idOrden}, {idCliente}, {fecha}, {estado}, {prioridad}";
            string[] row = { producto, cantidad, idOrden, idCliente, fecha, estado, prioridad };

            // Crear un ListViewItem con el array
            ListViewItem item = new ListViewItem(row);

            // Agregar el item al ListBox
            OrdenesPreparacionList.Items.Add(item);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
