//using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
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
            //var ordenFiltrada = Modelo.OrdenesSeleccion.FirstOrDefault(orden => (orden.IdOrdenSeleccion == idOrdenAFiltrar));
            ListViewListaOrdenesSeleccion.Items.Clear();

            string idOrdenAFiltrar = this.ComboBoxIDOrdenSeleccion.Text.Trim();
            string fechaAFiltrar = this.ComboBoxFecha.Text.Trim();

            //var ordenesFiltradas = Modelo.OrdenesSeleccion.Where(orden => (orden.IDsOrdenesPreparacion.Contains(idOrdenAFiltrar) || orden.FechaCreacion == DateTime.Parse(fechaAFiltrar)));
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

                    var ordenesPreparacionFiltradas = ordenesFiltradas
                        .Where(orden =>
                            (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDsOrdenesPreparacion.Contains(idOrdenAFiltrar)) &&
                            (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
                        .ToList();

                    //for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
                    //{

                    //    var fila = new ListViewItem();
                    //    fila.Text = ordenSeleccion.IDOrdenSeleccion.ToString();
                    //    fila.SubItems.Add(ordenSeleccion.FechaCreacion.ToString());
                    //    fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].IdProducto);
                    //    fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].Cantidad.ToString());

                    //    fila.Tag = ordenSeleccion;
                    //    ListViewListaOrdenesSeleccion.Items.Add(fila);
                    //}
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
            //ListViewListaOrdenesSeleccion.Items.Clear();


            //foreach (var ordenseleccion in Modelo.OrdenesSeleccion)
            //{
            //    for (int i = 0; i < ordenseleccion.OrdenesPreparacion.Count; i++)
            //    {
            //        var ordenpreparacion = ordenseleccion.OrdenesPreparacion[i];

            //        for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
            //        {
            //            var fila = new ListViewItem();
            //            fila.Text = ordenseleccion.IDOrdenSeleccion.ToString();
            //            fila.SubItems.Add(ordenseleccion.FechaCreacion.ToString());
            //            fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].IDProducto);
            //            fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].Cantidad.ToString());

            //            fila.Tag = ordenseleccion;
            //            ListViewListaOrdenesSeleccion.Items.Add(fila);
            //        }
            //    }
            //}
        }
    }
}
