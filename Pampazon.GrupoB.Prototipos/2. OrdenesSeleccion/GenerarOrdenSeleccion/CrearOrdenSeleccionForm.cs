using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class CrearOrdenSeleccionForm : Form
    {
        public CrearOrdenSeleccionModelo Modelo;

        //public List<OrdenPreparacion> listaordenespreparacion { get; set; }
        public CrearOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void BotonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        //{
        //    //TxtIdCliente.Text = string.Empty;
        //    //TxtIdProducto.Text = string.Empty;
        //    //TxtIdOrdenPreparacion.Text = string.Empty;
        //    //TxtFecha.Text = string.Empty;
        //    //TxtUbicacion.Text = string.Empty;
        //    //TxtPrioridad.Text = string.Empty;
        //}

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboBoxIDOrdenPreparacion.Text))
            {
                MessageBox.Show("El Id orden preparación no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacía");
                return;
            }

            //if (string.IsNullOrWhiteSpace(TxtIdProducto.Text))
            //{
            //    MessageBox.Show("El Id Producto no puede estar vacío");
            //    return;
            //}

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

            //if (string.IsNullOrWhiteSpace(TxtUbicacion.Text))
            //{
            //    MessageBox.Show("La ubicación no puede estar vacía");
            //    return;
            //}

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
                return;
            }


            //var formListadoOrdenesSeleccionConfirmar = new ListadoOrdenesSeleccionConfirmarForm();
            ////formGestionarStock.Modelo = modelo;
            //formListadoOrdenesSeleccionConfirmar.ShowDialog();
        }

        private void CrearOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
            CargarOrdenesSeleccion();


            foreach (var ordenpreparacion in Modelo.OrdenesPreparacion)
            {
                ComboBoxIDOrdenPreparacion.Items.Add(ordenpreparacion.IDOrdenPreparacion.ToString());
            }
        }

        private void CargarOrdenesSeleccion()
        {
            ListViewOrdenesPreparacion.Items.Clear();

            string idOrdenAFiltrar      = this.ComboBoxIDOrdenPreparacion.Text.Trim();
            string clienteAFiltrar      = this.TxtIdCliente.Text.Trim();
            string fechaAFiltrar        = this.TxtFecha.Text.Trim();
            string prioridadAFiltrar    = this.ComboBoxPrioridad.Text.Trim();

            var ordenesFiltradas = Modelo.OrdenesPreparacion
                                    .Where(orden =>
                                        (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                                        (string.IsNullOrEmpty(clienteAFiltrar) || orden.IdCliente.ToString() == clienteAFiltrar) &&
                                        (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaOrdenRecepcion.Date == DateTime.Parse(fechaAFiltrar).Date) &&
                                        (string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar))
                                    .ToList();

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
                ListViewOrdenesPreparacion.Items.Add(fila);
            }

        }

        private void BotonLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            ComboBoxIDOrdenPreparacion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtIdCliente.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
        }

        private void BotonBuscar_Click_1(object sender, EventArgs e)
        {
            CargarOrdenesSeleccion();
        }

        private void BotonGenerarOrdenSeleccion_Click_1(object sender, EventArgs e)
        {

        }

        private void BotonMoverOrdenPreparacion_Click(object sender, EventArgs e)
        {

        }

        private void BotonMoverOrdenSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void BotonLimpiarOrdenesSeleccion_Click(object sender, EventArgs e)
        {

        }
    }
}
