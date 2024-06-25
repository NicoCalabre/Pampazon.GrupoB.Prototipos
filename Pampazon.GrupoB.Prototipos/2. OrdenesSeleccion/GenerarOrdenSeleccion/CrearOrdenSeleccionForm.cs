using System;
using System.Collections;
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
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
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
        private void BotonLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            ComboBoxIDOrdenPreparacion.Text = null;
            ComboBoxFecha.Text = null;
            ComboBoxDescripcionCliente.Text = null;
            ComboBoxPrioridad.Text = null;
        }
        private void BotonBuscar_Click_1(object sender, EventArgs e)
        {
            //ARMAR VALIDACION

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
            }

            if (ordenespreparacionagregar.Count != 0)
            {

                string ordenseleccionnuevoid = Modelo.obtenerNuevoIDOrdenSeleccion();
                //Esto funciona, hay que armarlo dinámico
                _2._OrdenesSeleccion.GenerarOrdenSeleccion.OrdenSeleccion ordenseleccionagregar = new _2._OrdenesSeleccion.GenerarOrdenSeleccion.OrdenSeleccion
                {
                    IDOrdenSeleccion = ordenseleccionnuevoid,
                    FechaCreacion = DateTime.Today,
                    OrdenesPreparacion = new List<_2._OrdenesSeleccion.GenerarOrdenSeleccion.OrdenPreparacion>()
                };

                foreach (string idorden in ordenespreparacionagregar)
                {
                    var ordenPreparacionAgregar = Modelo.OrdenesPreparacionPendientes.FirstOrDefault(orden => orden.IDOrdenPreparacion == idorden.ToString());

                    ordenseleccionagregar.OrdenesPreparacion.Add(ordenPreparacionAgregar);
                    Modelo.CambiarEstadoOrdenSeleccionada(idorden);

                }


                Modelo.AltaOrdenSeleccion(ordenseleccionagregar);
                CargarOrdenesSeleccionFiltradas(ordenseleccionagregar);
                CargarOrdenesPreparacion();
                ListViewOrdenesPreparacionSeleccionadas.Refresh();
                ActualizarComboBox();
                MessageBox.Show("“La orden de selección ID: " + ordenseleccionnuevoid + " se ha generado con éxito”");
            }else
            {
                MessageBox.Show("Debe haber al menos una orden de preparación en la lista de órdenes de preparación seleccionadas para generar una orden de selección.");
            }
            //MessageBox.Show("Debe haber al menos una orden de preparación en la lista de órdenes de preparación seleccionadas para generar una orden de selección.");

            //Debe haber al menos una orden de preparación en la lista de órdenes de preparación seleccionadas para generar una orden de selección.
        }
        private void BotonMoverOrdenPreparacion_Click(object sender, EventArgs e)
        {
            //Primero chequeo si selecciono alguna persona para editar
            if (ListViewOrdenesPreparacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la lista de órdenes de preparación seleccionadas");
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
                MessageBox.Show("Debe seleccionar alguna orden para sacar de la lista de órdenes de preparación seleccionadas");
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
        private void CrearOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
            CargarOrdenesPreparacion();
            CargarOrdenesSeleccion();
            ActualizarComboBox();
        }
        private void CargarOrdenesPreparacion()
        {
            ListViewOrdenesPreparacion.Items.Clear();

            string idOrdenAFiltrar = this.ComboBoxIDOrdenPreparacion.Text.Trim();
            string clienteAFiltrar = this.ComboBoxDescripcionCliente.Text.Trim();
            string fechaAFiltrar = this.ComboBoxFecha.Text.Trim();
            string prioridadAFiltrar = this.ComboBoxPrioridad.Text.Trim();

            var ordenesFiltradas = Modelo.OrdenesPreparacionPendientes
                        .Where(orden =>
                            (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                            (string.IsNullOrEmpty(clienteAFiltrar) || orden.DescripcionCliente.Contains(clienteAFiltrar)) &&
                            (string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar) &&
                            (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaOrdenRecepcion.Date == DateTime.Parse(fechaAFiltrar).Date))
                        .ToList();

            if (ordenesFiltradas.Count != 0)
            {

                foreach (var ordenPreparacion in ordenesFiltradas)
                {
                    List<string> productosDetalleAgrupados = new List<string>();
                    foreach (var detalle in ordenPreparacion.Productos)
                    {
                        var productoFiltrado = detalle.DescripcionProducto;

                        string productoCantidad = "Producto: " + productoFiltrado + " ,Cantidad: " + detalle.Cantidad;

                        productosDetalleAgrupados.Add(productoCantidad);
                    }

                    var fila = new ListViewItem();
                    fila.Text = ordenPreparacion.IDOrdenPreparacion.ToString();
                    //fila.SubItems.Add(ordenPreparacion.IdCliente.ToString());
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
            else 
            {
                MessageBox.Show("No existen órdenes que cumplan con los filtros seleccionados");
                ComboBoxIDOrdenPreparacion.Text = null;
                ComboBoxFecha.Text = null;
                ComboBoxDescripcionCliente.Text = null;
                ComboBoxPrioridad.Text = null;
            }

            //ListViewOrdenesPreparacion.ListViewItemSorter = new _2._OrdenesSeleccion.GenerarOrdenSeleccion.ListViewItemComparer(0, SortOrder.Ascending);

        }
        public void CargarOrdenesSeleccion()
        {
            ListViewOrdenesSeleccion.Items.Clear();

            foreach (var ordenesFiltradas in Modelo.OrdenesSeleccion)
            {
                //var ordenesFiltradas = OrdenesSeleccionLista;

                var productosAgrupados = ordenesFiltradas.OrdenesPreparacion
                    .SelectMany(op => op.Productos)
                    .GroupBy(producto => producto.DescripcionProducto)
                    .Select(grupo =>
                    {
                        var primerProducto = grupo.First();
                        var sumaCantidades = grupo.Sum(producto => producto.Cantidad);

                        return new
                        {
                            DescripcionProducto = primerProducto.DescripcionProducto,
                            CantidadTotal = sumaCantidades,
                            Ubicaciones = primerProducto.Ubicaciones
                        };
                    });

                foreach (var productoAgrupado in productosAgrupados)
                {
                    int cantidadRestante = productoAgrupado.CantidadTotal;

                    foreach (var ubicacion in productoAgrupado.Ubicaciones)
                    {
                        if (cantidadRestante <= 0)
                            break;

                        int cantidadEnUbicacion = Math.Min(cantidadRestante, ubicacion.CantidadDisponible);
                        cantidadRestante -= cantidadEnUbicacion;

                        ListViewItem fila = new ListViewItem();
                        fila.Text = ordenesFiltradas.IDOrdenSeleccion.ToString();
                        fila.SubItems.Add(productoAgrupado.DescripcionProducto);
                        fila.SubItems.Add(cantidadEnUbicacion.ToString());
                        fila.SubItems.Add(ubicacion.Ubicacion);

                        fila.Tag = ordenesFiltradas;
                        ListViewOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }


            // Realizar la ordenación
            ListViewOrdenesSeleccion.ListViewItemSorter = new _2._OrdenesSeleccion.GenerarOrdenSeleccion.ListViewItemComparer(3, SortOrder.Ascending);

        }
        public void CargarOrdenesSeleccionFiltradas(_2._OrdenesSeleccion.GenerarOrdenSeleccion.OrdenSeleccion ordenseleccion)
        {

            ListViewOrdenesSeleccion.Items.Clear();

            var ordenesFiltradas = ordenseleccion;

            var productosAgrupados = ordenesFiltradas.OrdenesPreparacion
                .SelectMany(op => op.Productos)
                .GroupBy(producto => producto.DescripcionProducto)
                .Select(grupo =>
                {
                    var primerProducto = grupo.First();
                    var sumaCantidades = grupo.Sum(producto => producto.Cantidad);

                    return new
                    {
                        DescripcionProducto = primerProducto.DescripcionProducto,
                        CantidadTotal = sumaCantidades,
                        Ubicaciones = primerProducto.Ubicaciones
                    };
                });

            foreach (var productoAgrupado in productosAgrupados)
            {
                int cantidadRestante = productoAgrupado.CantidadTotal;

                foreach (var ubicacion in productoAgrupado.Ubicaciones)
                {
                    if (cantidadRestante <= 0)
                        break;

                    int cantidadEnUbicacion = Math.Min(cantidadRestante, ubicacion.CantidadDisponible);
                    cantidadRestante -= cantidadEnUbicacion;

                    ListViewItem fila = new ListViewItem();
                    fila.Text = ordenesFiltradas.IDOrdenSeleccion.ToString();
                    fila.SubItems.Add(productoAgrupado.DescripcionProducto);
                    fila.SubItems.Add(cantidadEnUbicacion.ToString());
                    fila.SubItems.Add(ubicacion.Ubicacion);

                    fila.Tag = ordenesFiltradas;
                    ListViewOrdenesSeleccion.Items.Add(fila);
                }
            }

            // Realizar la ordenación
            ListViewOrdenesSeleccion.ListViewItemSorter = new _2._OrdenesSeleccion.GenerarOrdenSeleccion.ListViewItemComparer(3, SortOrder.Ascending);
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
        public void ActualizarComboBox()
        {
            ComboBoxIDOrdenPreparacion.Items.Clear();
            ComboBoxDescripcionCliente.Items.Clear();
            ComboBoxPrioridad.Items.Clear();
            ComboBoxFecha.Items.Clear();
            //ComboBoxIDCliente.DataSource = Modelo.OrdenesPreparacionPendientes;


            foreach (var ordenpreparacion in Modelo.OrdenesPreparacionPendientes)
            {
                ComboBoxIDOrdenPreparacion.Items.Add(ordenpreparacion.IDOrdenPreparacion.ToString());
            }

            foreach (var cliente in Modelo.OrdenesPreparacionPendientes)
            {
                ComboBoxDescripcionCliente.Items.Add(cliente.DescripcionCliente.ToString());
            }

            _2._OrdenesSeleccion.GenerarOrdenSeleccion.PrioridadOrden[] listaprioridadordenes = (_2._OrdenesSeleccion.GenerarOrdenSeleccion.PrioridadOrden[])Enum.GetValues(typeof(_2._OrdenesSeleccion.GenerarOrdenSeleccion.PrioridadOrden));
            foreach (var prioridadorden in listaprioridadordenes)
            {
                ComboBoxPrioridad.Items.Add(prioridadorden.ToString());
            }

            //aca armamos una lógica para no cargar fechas repetidas
            List<string> listafechas = new List<string>();
            foreach (var fecha in Modelo.OrdenesPreparacionPendientes)
            {
                string fechaStr = fecha.FechaOrdenRecepcion.ToString("yyyy-MM-dd");

                if (!listafechas.Contains(fechaStr))
                {
                    listafechas.Add(fechaStr);
                    ComboBoxFecha.Items.Add(fecha.FechaOrdenRecepcion.ToString());
                }
            }
        }

        public List<(string Ubicacion, int Cantidad)> DistribuirProductoEnUbicaciones(_2._OrdenesSeleccion.GenerarOrdenSeleccion.Producto producto, Dictionary<string, int> stockPorUbicacion)
        {
            List<(string Ubicacion, int Cantidad)> distribucion = new List<(string Ubicacion, int Cantidad)>();

            int cantidadRestante = producto.Cantidad;

            foreach (var ubicacion in stockPorUbicacion.Keys)
            {
                if (cantidadRestante <= 0) break;

                int cantidadDisponible = stockPorUbicacion[ubicacion];
                int cantidadEnUbicacion = Math.Min(cantidadRestante, cantidadDisponible);
                if (cantidadEnUbicacion > 0)
                {
                    distribucion.Add((ubicacion, cantidadEnUbicacion));
                    cantidadRestante -= cantidadEnUbicacion;
                }
            }

            // Si queda cantidad restante y no hay más ubicaciones, agregar una línea con cantidad sin ubicación
            if (cantidadRestante > 0)
            {
                distribucion.Add(("Sin ubicación", cantidadRestante));
            }

            return distribucion;
        }


        public Dictionary<string, int> CalcularStockPorUbicacion(List<_2._OrdenesSeleccion.GenerarOrdenSeleccion.Producto> productos)
        {
            Dictionary<string, int> stockPorUbicacion = new Dictionary<string, int>();

            foreach (var producto in productos)
            {
                foreach (var detalle in producto.Ubicaciones)
                {
                    if (stockPorUbicacion.ContainsKey(detalle.Ubicacion))
                    {
                        stockPorUbicacion[detalle.Ubicacion] += detalle.CantidadDisponible;
                    }
                    else
                    {
                        stockPorUbicacion[detalle.Ubicacion] = detalle.CantidadDisponible;
                    }
                }
            }

            return stockPorUbicacion;
        }

    }
}
