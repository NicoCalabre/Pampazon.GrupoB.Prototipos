//using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion;
using Microsoft.VisualBasic.Logging;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
using Pampazon.GrupoB.Prototipos.Archivos;
using System.Data;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class ConsultarListaOrdenesSeleccionForm : Form
    {
        public ConsultarListaOrdenesSeleccionModelo Modelo;

        public ConsultarListaOrdenesSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            //Cerramos la ventana
            this.Close();
        }
        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            //Borramos los valores que estén en los ComboBox en cuestión
            ComboBoxIDOrdenSeleccion.Text = null;
            ComboBoxFecha.Text = null;
        }
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            ListViewListaOrdenesSeleccion.Items.Clear();

            string idOrdenAFiltrar  = this.ComboBoxIDOrdenSeleccion.Text.Trim();
            string fechaAFiltrar    = this.ComboBoxFecha.Text.Trim();

            var ordenesFiltradas    = FiltrarOrdenesSeleccion(idOrdenAFiltrar, fechaAFiltrar);
            if(ordenesFiltradas.Count != 0)
            {
                CargarLista(ordenesFiltradas);
            }
            else
            {
                MessageBox.Show("No existen órdenes que cumplan con los filtros seleccionados");
                ComboBoxIDOrdenSeleccion.Text = null;
                ComboBoxFecha.Text = null;
            }
            
        }
        private void ConsultarListaOrdenesSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            CargarLista(Modelo.OrdenesSeleccion);

            foreach (var ordenseleccion in Modelo.OrdenesSeleccion)
            {
                ComboBoxIDOrdenSeleccion.Items.Add(ordenseleccion.IDOrdenSeleccion.ToString());
            }

            //aca armamos una lógica para no cargar fechas repetidas
            List<string> listafechas = new List<string>();
            foreach (var fecha in Modelo.OrdenesSeleccion)
            {
                string fechaStr = fecha.FechaCreacion.ToString("yyyy-MM-dd");

                if (!listafechas.Contains(fechaStr))
                {
                    listafechas.Add(fechaStr);
                    ComboBoxFecha.Items.Add(fecha.FechaCreacion.ToString());
                }
            }
        }
        private void CargarLista(List<_2._OrdenesSeleccion.ListarOrdenesSeleccion.OrdenSeleccion> OrdenesSeleccionLista)
        {
            ListViewListaOrdenesSeleccion.Items.Clear();

            foreach (var ordenesFiltradas in OrdenesSeleccionLista)
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
                        fila.SubItems.Add(ordenesFiltradas.FechaCreacion.ToString());
                        fila.SubItems.Add(productoAgrupado.DescripcionProducto);
                        fila.SubItems.Add(cantidadEnUbicacion.ToString());
                        fila.SubItems.Add(ubicacion.Ubicacion);

                        fila.Tag = ordenesFiltradas;
                        ListViewListaOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
            ListViewListaOrdenesSeleccion.ListViewItemSorter = new _2._OrdenesSeleccion.ListarOrdenesSeleccion.ListViewItemComparer(4, SortOrder.Ascending);
        }
        private List<_2._OrdenesSeleccion.ListarOrdenesSeleccion.OrdenSeleccion> FiltrarOrdenesSeleccion(string idOrdenAFiltrar, string fechaAFiltrar)
        {
            var ordenesFiltradas = Modelo.OrdenesSeleccion
                        .Where(orden =>
                            (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenSeleccion.Contains(idOrdenAFiltrar)) &&
                            (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
                        .ToList();

            return ordenesFiltradas;
        }
    }
}
