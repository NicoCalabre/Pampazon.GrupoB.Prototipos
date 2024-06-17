using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion;
using Pampazon.GrupoB.Prototipos.Archivos;
using Pampazon.GrupoB.Prototipos.OrdenesEntrega.CrearOrdenEntrega;
using Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class CrearOrdenSeleccionForm : Form
    {
        public CrearOrdenSeleccionModelo Modelo;
        public CrearOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
            CargarOrdenesPreparacion();
            CargarOrdenesSeleccion();


            //cargamos una lista de todos los id de orden de preparacion en el combo box. La idea es que el operario no tenga que memorizarse todos esos id. Pasa lo mismo con los id cliente
            foreach (var ordenpreparacion in Modelo.OrdenesPreparacion)
            {
                ComboBoxIDOrdenPreparacion.Items.Add(ordenpreparacion.IDOrdenPreparacion.ToString());
            }

            foreach (var cliente in Modelo.OrdenesPreparacion)
            {
                ComboBoxIDCliente.Items.Add(cliente.IdCliente.ToString());
            }

            _2._OrdenesSeleccion.GenerarOrdenSeleccion.PrioridadOrden[] listaprioridadordenes = (_2._OrdenesSeleccion.GenerarOrdenSeleccion.PrioridadOrden[])Enum.GetValues(typeof(_2._OrdenesSeleccion.GenerarOrdenSeleccion.PrioridadOrden));
            foreach (var prioridadorden in listaprioridadordenes)
            {
                ComboBoxPrioridad.Items.Add(prioridadorden.ToString());
            }
        }

        private void CargarOrdenesPreparacion()
        {
            ListViewOrdenesPreparacion.Items.Clear();

            string idOrdenAFiltrar = this.ComboBoxIDOrdenPreparacion.Text.Trim();
            string clienteAFiltrar = this.ComboBoxIDCliente.Text.Trim();
            string fechaAFiltrar = this.TxtFecha.Text.Trim();
            string prioridadAFiltrar = this.ComboBoxPrioridad.Text.Trim();

            var ordenesFiltradas = Modelo.OrdenesPreparacionPendientes
                        .Where(orden =>
                            (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                            (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                            (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                            (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaOrdenRecepcion.Date == DateTime.Parse(fechaAFiltrar).Date))
                        .ToList();

            foreach (var ordenPreparacion in ordenesFiltradas)
            {
                List<string> productosDetalleAgrupados = new List<string>();

                foreach (Archivos.OrdenDetalle detalle in ordenPreparacion.Productos)
                {

                    var productoFiltrado = Modelo.Productos.FirstOrDefault(producto => producto.IDProducto == detalle.IdProducto);

                    string productoCantidad = "Producto: " + productoFiltrado.IDProducto + " ,Cantidad: " + productoFiltrado.Cantidad;
                    productosDetalleAgrupados.Add(productoCantidad);
                }

                var fila = new ListViewItem();
                fila.Text = ordenPreparacion.IDOrdenPreparacion.ToString();
                fila.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                fila.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                fila.SubItems.Add(ordenPreparacion.Estado.ToString());
                fila.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                fila.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());
                fila.SubItems.Add(String.Join(";", productosDetalleAgrupados));

                fila.Tag = ordenPreparacion;
                ListViewOrdenesPreparacion.Items.Add(fila);
            }
            ListViewOrdenesPreparacion.Refresh();

        }

        public void CargarOrdenesSeleccion()
        {
            ListViewOrdenesSeleccion.Items.Clear();

            var ordenesFiltradas = Modelo.OrdenesSeleccion;

            foreach (var ordenSeleccion in ordenesFiltradas)
            {
                for (int i = 0; i < ordenSeleccion.IDsOrdenesPreparacion.Count; i++)
                {
                    var ordenpreparacion = ordenSeleccion.IDsOrdenesPreparacion[i];

                    var ordenFiltrada = Modelo.OrdenesPreparacion.FirstOrDefault(orden => (orden.IDOrdenPreparacion == ordenpreparacion));
                    foreach (Archivos.OrdenDetalle detalle in ordenFiltrada.Productos)
                    {
                        var productoFiltrado = Modelo.Productos.FirstOrDefault(producto => producto.IDProducto == detalle.IdProducto);
                        //public List<ProductoDetalleStock> Ubicaciones { get; set; } 


                        var fila = new ListViewItem();
                        fila.Text = ordenSeleccion.IDOrdenSeleccion.ToString();
                        //fila.SubItems.Add(ordenSeleccion.FechaCreacion.ToString());
                        fila.SubItems.Add(detalle.IdProducto);
                        //fila.SubItems.Add(productoFiltrado.DescripcionProducto.ToString());
                        fila.SubItems.Add(detalle.Cantidad.ToString());
                        fila.SubItems.Add(productoFiltrado.Ubicaciones[0].Ubicacion.ToString());


                        fila.Tag = ordenSeleccion;
                        ListViewOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
            //var items = ListViewOrdenesSeleccion.Items.Cast<ListViewItem>().OrderBy(x => x.SubItems[3]).ToList();
            //ListViewOrdenesSeleccion.Items.Clear();
            //ListViewOrdenesSeleccion.Items.AddRange(items.ToArray());
        }

        public void CargarOrdenesSeleccionFiltradas(Archivos.OrdenSeleccion ordenseleccion)
        {
            ListViewOrdenesSeleccion.Items.Clear();

            for (int i = 0; i < ordenseleccion.IDsOrdenesPreparacion.Count; i++)
            {
                var ordenpreparacion = ordenseleccion.IDsOrdenesPreparacion[i];

                var ordenFiltrada = Modelo.OrdenesPreparacion.FirstOrDefault(orden => (orden.IDOrdenPreparacion == ordenpreparacion));

                foreach (Archivos.OrdenDetalle detalle in ordenFiltrada.Productos)
                {
                    var productoFiltrado = Modelo.Productos.FirstOrDefault(producto => producto.IDProducto == detalle.IdProducto);

                    var fila = new ListViewItem();
                    fila.Text = ordenseleccion.IDOrdenSeleccion.ToString();
                    fila.SubItems.Add(detalle.IdProducto);
                    fila.SubItems.Add(detalle.Cantidad.ToString());
                    fila.SubItems.Add(productoFiltrado.Ubicaciones[0].Ubicacion.ToString());

                    fila.Tag = ordenseleccion;
                    ListViewOrdenesSeleccion.Items.Add(fila);
                }
            }
        }

        private void BotonLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            ComboBoxIDOrdenPreparacion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            ComboBoxIDCliente.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
        }

        private void BotonBuscar_Click_1(object sender, EventArgs e)
        {
            CargarOrdenesPreparacion();
        }

        private void BotonGenerarOrdenSeleccion_Click_1(object sender, EventArgs e)
        {
            ListViewOrdenesSeleccion.Items.Clear();

            List<string> ordenespreparacionagregar = new List<string>();

            foreach (ListViewItem item in ListViewOrdenesPreparacionSeleccionadas.Items)
            {
                string idOrdenAFiltrar = item.SubItems[0].Text.ToString();

                ordenespreparacionagregar.Add(idOrdenAFiltrar);

                ListViewOrdenesPreparacionSeleccionadas.Items.Remove(item);
                //Archivos.OrdenPreparacion.CambiarEstadoOrden(Modelo.OrdenesPreparacion,idOrdenAFiltrar, Archivos.EstadoOrden.Pendiente);
                Modelo.CambiarEstadoOrdenSeleccionada(idOrdenAFiltrar);
            }

            //Esto funciona, hay que armarlo dinámico
            Archivos.OrdenSeleccion ordenseleccionagregar = new Archivos.OrdenSeleccion
            {
                IDOrdenSeleccion = Modelo.obtenerNuevoIDOrdenSeleccion(),
                FechaCreacion = DateTime.Today,
                IDsOrdenesPreparacion = ordenespreparacionagregar
            };

            Modelo.AltaOrdenSeleccion(ordenseleccionagregar);

            CargarOrdenesSeleccionFiltradas(ordenseleccionagregar);
            ListViewOrdenesPreparacionSeleccionadas.Refresh();

        }

        private void BotonMoverOrdenPreparacion_Click(object sender, EventArgs e)
        {
            //Primero chequeo si selecciono alguna persona para editar
            if (ListViewOrdenesPreparacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la orden de preparación");
                return;
            }
            else
            {
                //Agarro la orden que seleccione para pasar a la orden de entrega
                ListViewItem itemSeleccionado = ListViewOrdenesPreparacion.SelectedItems[0];

                //De esa orden que agarre, busco el IDOrden
                string idOrdenAValidar = itemSeleccionado.SubItems[0].Text;

                MoverItems(ListViewOrdenesPreparacion, ListViewOrdenesPreparacionSeleccionadas);
            }
        }

        public void BotonMoverOrdenSeleccion_Click(object sender, EventArgs e)
        {
            //Primero chequeo si selecciono alguna persona para editar
            if (ListViewOrdenesPreparacionSeleccionadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la orden de preparación");
                return;
            }
            else
            {
                //Agarro la orden que seleccione para pasar a la orden de entrega
                ListViewItem itemSeleccionado = ListViewOrdenesPreparacionSeleccionadas.SelectedItems[0];

                //De esa orden que agarre, busco el IDOrden
                string idOrdenAValidar = itemSeleccionado.SubItems[0].Text;

                MoverItems(ListViewOrdenesPreparacionSeleccionadas, ListViewOrdenesPreparacion);
            }
        }

        public void BotonLimpiarOrdenesSeleccion_Click(object sender, EventArgs e)
        {
            ListViewOrdenesSeleccion.Items.Clear();
        }
        public void MoverItems(System.Windows.Forms.ListView origen, System.Windows.Forms.ListView destino)
        {
            //clono los datos de la list view de origen en la de destino
            //En esta itero por las ordenes seleccionadas en la listview de origen
            foreach (ListViewItem orden in origen.SelectedItems)
            {
                //la clono en la de destino
                destino.Items.Add((ListViewItem)orden.Clone());
                origen.Items.Remove(orden);
            }
        }

        private void ComboBoxPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            //actualizame el combo box de productos con solo que le corresponde
        }
    }
}
