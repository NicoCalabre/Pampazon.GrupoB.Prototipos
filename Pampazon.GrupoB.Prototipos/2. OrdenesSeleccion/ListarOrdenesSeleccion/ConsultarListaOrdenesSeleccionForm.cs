//using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion;
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
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            ComboBoxIDOrdenSeleccion.Text = null;
            ComboBoxFecha.Text = null;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            ListViewListaOrdenesSeleccion.Items.Clear();

            string idOrdenAFiltrar = this.ComboBoxIDOrdenSeleccion.Text.Trim();
            string fechaAFiltrar = this.ComboBoxFecha.Text.Trim();

            var ordenesFiltradas = Modelo.OrdenesSeleccion
                                    .Where(orden =>
                                        (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenSeleccion.Contains(idOrdenAFiltrar)) &&
                                        (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
                                    .ToList();

            foreach (var ordenSeleccion in ordenesFiltradas)
            {
                for (int i = 0; i < ordenSeleccion.IDsOrdenesPreparacion.Count; i++)
                {
                    var ordenpreparacion = ordenSeleccion.IDsOrdenesPreparacion[i];

                    var ordenFiltrada = Modelo.OrdenesPreparacion.FirstOrDefault(orden => (orden.IDOrdenPreparacion == ordenpreparacion));
                    foreach (Archivos.OrdenDetalle detalle in ordenFiltrada.Productos)
                    {
                        var productoFiltrado = Modelo.Productos.FirstOrDefault(producto => producto.IDProducto == detalle.IdProducto);

                        var fila = new ListViewItem();
                        fila.Text = ordenSeleccion.IDOrdenSeleccion.ToString();
                        fila.SubItems.Add(ordenSeleccion.FechaCreacion.ToString());
                        fila.SubItems.Add(detalle.IdProducto);
                        fila.SubItems.Add(productoFiltrado.DescripcionProducto.ToString());
                        fila.SubItems.Add(detalle.Cantidad.ToString());

                        fila.Tag = ordenSeleccion;
                        ListViewListaOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
        }

        private void ConsultarListaOrdenesSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
            CargarLista();

            //PrioridadOrden[] listaprioridadordenes = (PrioridadOrden[])Enum.GetValues(typeof(PrioridadOrden));
            //foreach (var prioridadorden in listaprioridadordenes)
            //{
            //    ComboBoxPrioridad.Items.Add(prioridadorden.ToString());
            //}

            foreach (var ordenseleccion in Modelo.OrdenesSeleccion)
            {
                ComboBoxIDOrdenSeleccion.Items.Add(ordenseleccion.IDOrdenSeleccion.ToString());
            }

            foreach (var fecha in Modelo.OrdenesSeleccion)
            {
                ComboBoxFecha.Items.Add(fecha.FechaCreacion.ToString());
            }
        }

        private void CargarLista()
        {
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

                        var fila = new ListViewItem();
                        fila.Text = ordenSeleccion.IDOrdenSeleccion.ToString();
                        fila.SubItems.Add(ordenSeleccion.FechaCreacion.ToString());
                        fila.SubItems.Add(detalle.IdProducto);
                        fila.SubItems.Add(productoFiltrado.DescripcionProducto.ToString());
                        fila.SubItems.Add(detalle.Cantidad.ToString());

                        fila.Tag = ordenSeleccion;
                        ListViewListaOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
        }
    }
}
