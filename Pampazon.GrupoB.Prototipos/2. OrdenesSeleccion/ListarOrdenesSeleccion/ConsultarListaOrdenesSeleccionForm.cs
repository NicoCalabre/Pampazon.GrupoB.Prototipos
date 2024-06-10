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
            ComboBoxIDOrdenSeleccion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(TxtIDCliente.Text))
            //{
            //    MessageBox.Show("El id cliente no puede estar vacío");
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(TxtIdOrdenSeleccion.Text))
            //{
            //    MessageBox.Show("El id orden selección no puede estar vacío");
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            //{
            //    MessageBox.Show("La fecha no puede estar vacía");
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(ComboBoxPrioridad.Text))
            //{
            //    MessageBox.Show("La prioridad no puede estar vacía");
            //    return;
            //}

            ////if (!int.TryParse(this.TxtCantidad.Text, out var espaciondisponible))
            ////{
            ////    MessageBox.Show("La cantidad debe ser un valor númerico");
            ////    return;
            ////}

            //if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            //{
            //    MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
            //    return;
            //}

            ListViewListaOrdenesSeleccion.Items.Clear();


            string idOrdenAFiltrar = this.ComboBoxIDOrdenSeleccion.Text.Trim();
            string clienteAFiltrar = this.ComboBoxIDCliente.Text.Trim();
            string fechaAFiltrar = this.TxtFecha.Text.Trim();
            string prioridadAFiltrar = this.ComboBoxPrioridad.Text.Trim();

            var ordenesFiltradas = Modelo.OrdenesSeleccion
                                    .Where(orden =>
                                        (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenSeleccion.Contains(idOrdenAFiltrar)) &&
                                        //(string.IsNullOrEmpty(clienteAFiltrar) || orden.IDCliente.ToString() == clienteAFiltrar) &&
                                        (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
                                    //(string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar))
                                    .ToList();

            foreach (var ordenSeleccion in ordenesFiltradas)
            {
                for (int i = 0; i < ordenSeleccion.OrdenesPreparacion.Count; i++)
                {
                    var ordenpreparacion = ordenSeleccion.OrdenesPreparacion[i];

                    for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
                    {

                        var fila = new ListViewItem();
                        //Sumo los datos de las ordenes a la ListView del WInforms
                        fila.Text = ordenSeleccion.IDOrdenSeleccion.ToString();
                        fila.SubItems.Add(ordenSeleccion.FechaCreacion.ToString());
                        //fila.subitems.add(ordenseleccion.idcliente.tostring());
                        //fila.subitems.add(ordenseleccion.descripcioncliente.tostring());
                        //fila.subitems.add(ordenseleccion.estado.tostring());
                        //fila.subitems.add(ordenseleccion.prioridad.tostring());


                        //string.Join lo que hace es concatenar elementos separados por ";"
                        //Select( producto => ) lo que hace es recorrer el listado de productos
                        //De ese listado de productos obtiene los datos relevantes y los concatena separandolos por ";"
                        //var DescripcionProductosOrden = string.Join("; ",
                        //                                            ordenPreparacion.Productos.Select(
                        //                                                                                producto =>
                        //                                                                                $"IDProducto: {producto.IDProducto}, " +
                        //                                                                                $"DescripcionProducto: {producto.DescripcionProducto}, " +
                        //                                                                                $"Cantidad: {producto.Cantidad}, " +
                        //                                                                                $"Ubicacion: {producto.Ubicacion}"
                        //                                                                             )
                        //                                            );
                        ////Sumo esas descripciones de producto a la columna de Productos en el WinForms
                        //fila.SubItems.Add(DescripcionProductosOrden);
                        fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].IDProducto);
                        fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].Cantidad.ToString());

                        fila.Tag = ordenSeleccion;
                        ListViewListaOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }

            CargarLista();

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

            foreach (var cliente in Modelo.OrdenesPreparacion)
            {
                ComboBoxIDCliente.Items.Add(cliente.IdCliente.ToString());
            }
            //ComboBoxPrioridad.Items.Add(EstadoOrden.Recepcion.ToString());
            //ComboBoxPrioridad.Items.Add(EstadoOrden.Preparacion.ToString());
            //ComboBoxPrioridad.Items.Add(EstadoOrden.Seleccion.ToString());
            //ComboBoxPrioridad.Items.Add(EstadoOrden.Entrega.ToString());
        }

        private void CargarLista()
        {
            ListViewListaOrdenesSeleccion.Items.Clear();

            foreach (var ordenseleccion in Modelo.OrdenesSeleccion)
            {
                for (int i = 0; i < ordenseleccion.OrdenesPreparacion.Count; i++)
                {
                    var ordenpreparacion = ordenseleccion.OrdenesPreparacion[i];

                    for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
                    {
                        var fila = new ListViewItem();
                        //hacer algo con la fila
                        fila.Text = ordenseleccion.IDOrdenSeleccion.ToString();
                        fila.SubItems.Add(ordenseleccion.FechaCreacion.ToString());
                        //fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].IdCliente);
                        //fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].DescripcionCliente);
                        //fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Estado.ToString());
                        //fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Prioridad.ToString());
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].IDProducto);
                        //fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].DescripcionProducto);
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].Cantidad.ToString());

                        fila.Tag = ordenseleccion;
                        ListViewListaOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
        }
    }
}
