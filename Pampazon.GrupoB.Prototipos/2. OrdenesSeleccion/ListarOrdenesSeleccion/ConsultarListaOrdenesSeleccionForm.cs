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

            string idOrdenAFiltrar = this.ComboBoxIDOrdenSeleccion.Text.Trim();
            string fechaAFiltrar = this.ComboBoxFecha.Text.Trim();

            var ordenesFiltradas = FiltrarOrdenesSeleccion(idOrdenAFiltrar,fechaAFiltrar);

            CargarLista(ordenesFiltradas);
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
        private void CargarLista(List<OrdenSeleccion> OrdenesSeleccionLista)
        {
            var ordenesFiltradas = OrdenesSeleccionLista;

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
                        fila.SubItems.Add(productoFiltrado.Ubicaciones[0].Ubicacion.ToString());

                        fila.Tag = ordenSeleccion;
                        ListViewListaOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
        }
        private List<OrdenSeleccion> FiltrarOrdenesSeleccion(string idOrdenAFiltrar, string fechaAFiltrar)
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
