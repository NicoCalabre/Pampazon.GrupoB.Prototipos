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

            string idOrdenAFiltrar  = this.ComboBoxIDOrdenSeleccion.Text.Trim();
            string fechaAFiltrar    = this.ComboBoxFecha.Text.Trim();

            var ordenesFiltradas    = FiltrarOrdenesSeleccion(idOrdenAFiltrar, fechaAFiltrar);

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
        private void CargarLista(List<_2._OrdenesSeleccion.ListarOrdenesSeleccion.OrdenSeleccion> OrdenesSeleccionLista)
        {
            if (OrdenesSeleccionLista == null)
            {
                // Maneja el caso en que OrdenesSeleccionLista es null
                MessageBox.Show("La lista de órdenes de selección es nula.");
                return ;
            }

            foreach (var ordenSeleccion in OrdenesSeleccionLista)
            {
                if (ordenSeleccion?.OrdenesPreparacion == null)
                {
                    continue; // Salta a la siguiente ordenSeleccion si OrdenesPreparacion es null
                }

                for (int i = 0; i < ordenSeleccion.OrdenesPreparacion.Count; i++)
                {
                    var ordenpreparacion = ordenSeleccion.OrdenesPreparacion[i];

                    if (ordenpreparacion?.Productos == null)
                    {
                        continue; // Salta a la siguiente ordenpreparacion si Productos es null
                    }

                    for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
                    {
                        var producto = ordenpreparacion.Productos[j];

                        if (producto?.Ubicaciones == null)
                        {
                            continue; // Salta al siguiente producto si Ubicaciones es null
                        }

                        //for (int k = 0; k < producto.Ubicaciones.Count; k++)// REVISAR COMO LEVANTAR UBICACION, NO ESTÁ EXPLICITO EN LA ENTIDAD NI EN LOS ARCHIVOS. SE CONSTRUYE 
                        //{
                            var ubicaciones = producto.Ubicaciones[0];

                            if (ubicaciones == null)
                            {
                                continue; // Salta a la siguiente ubicación si ubicaciones es null
                            }

                            var fila = new ListViewItem();

                            fila.Text = ordenSeleccion.IDOrdenSeleccion;
                            fila.SubItems.Add(ordenSeleccion.FechaCreacion.ToString());
                            //fila.SubItems.Add(producto.IDProducto);
                            fila.SubItems.Add(producto.DescripcionProducto);
                            fila.SubItems.Add(producto.Cantidad.ToString());
                            fila.SubItems.Add(ubicaciones.Ubicacion.ToString());

                            fila.Tag = ordenSeleccion;
                            ListViewListaOrdenesSeleccion.Items.Add(fila);
                        //}
                    }
                }
            }
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
