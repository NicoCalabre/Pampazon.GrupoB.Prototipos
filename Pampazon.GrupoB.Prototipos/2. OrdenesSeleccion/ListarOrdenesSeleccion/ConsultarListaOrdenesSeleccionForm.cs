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
            ComboBoxIDCliente.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            ComboBoxIDOrdenSeleccion.Text = null;
            ComboBoxFecha.Text = null;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            //ListViewListaOrdenesSeleccion.Items.Clear();


            //string idOrdenAFiltrar = this.ComboBoxIDOrdenSeleccion.Text.Trim();
            ////string clienteAFiltrar = this.ComboBoxIDCliente.Text.Trim();
            //string fechaAFiltrar = this.ComboBoxFecha.Text.Trim();
            ////string prioridadAFiltrar = this.ComboBoxPrioridad.Text.Trim();

            //var ordenesFiltradas = Modelo.OrdenesSeleccion
            //                        .Where(orden =>
            //                            (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenSeleccion.Contains(idOrdenAFiltrar)) &&
            //                            //(string.IsNullOrEmpty(clienteAFiltrar) || orden.IDCliente.ToString() == clienteAFiltrar) &&
            //                            (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
            //                        //(string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar))
            //                        .ToList();

            //foreach (var ordenSeleccion in ordenesFiltradas)
            //{
            //    for (int i = 0; i < ordenSeleccion.OrdenesPreparacion.Count; i++)
            //    {
            //        var ordenpreparacion = ordenSeleccion.OrdenesPreparacion[i];

            //        for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
            //        {

            //            var fila = new ListViewItem();
            //            fila.Text = ordenSeleccion.IDOrdenSeleccion.ToString();
            //            fila.SubItems.Add(ordenSeleccion.FechaCreacion.ToString());
            //            fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].IDProducto);
            //            fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].Cantidad.ToString());

            //            fila.Tag = ordenSeleccion;
            //            ListViewListaOrdenesSeleccion.Items.Add(fila);
            //        }
            //    }
            //}
        }

        private void ConsultarListaOrdenesSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
            CargarLista();

            PrioridadOrden[] listaprioridadordenes = (PrioridadOrden[])Enum.GetValues(typeof(PrioridadOrden));
            foreach (var prioridadorden in listaprioridadordenes)
            {
                ComboBoxPrioridad.Items.Add(prioridadorden.ToString());
            }

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
