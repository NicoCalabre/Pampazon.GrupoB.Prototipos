using Pampazon.GrupoB.Prototipos.OrdenesEntrega.CrearOrdenEntrega;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class CrearOrdenEntregaForm : Form
    {
        public CrearOrdenEntregaModelo Modelo;

        public CrearOrdenEntregaForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {

            //Cierro la pestaña actual y vuelvo a la anterior
            this.Close();
        }

        private void CrearOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            // Cargo los estados posibles al combobox
            ComboBoxEstado.Items.Add(OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Pendiente.ToString());
            ComboBoxEstado.Items.Add(OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.EnSeleccion.ToString());
            ComboBoxEstado.Items.Add(OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada.ToString());

            // Cargo las prioridades posibles al combobox
            ComboBoxPrioridad.Items.Add(Prioridad.Baja.ToString());
            ComboBoxPrioridad.Items.Add(Prioridad.Media.ToString());
            ComboBoxPrioridad.Items.Add(Prioridad.Alta.ToString());

            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesPreparacion();

        }

        private void CargarOrdenesPreparacion()
        {
            // Borramos todo el listado de órdenes para volver a cargarlo
            // Esto asegura que al agregar una nueva orden, se actualice la lista
            OrdenesPreparacionList.Items.Clear();

            // Obtener los valores ingresados por el usuario en los TextBoxs y los ComboBoxs
            string idOrdenAFiltrar = this.TxtIdOrdenPreparacion.Text.Trim();
            string estadoAFiltrar = this.ComboBoxEstado.Text.Trim();
            string fechaAFiltrar = this.TxtFecha.Text.Trim();
            string prioridadAFiltrar = this.ComboBoxPrioridad.Text.Trim();

            // Filtrar las órdenes según los campos ingresados por el usuario
            // Si ingreso todos, filtra por todos
            // Si no ingreso nada, trae todo el listado de ordenes de preparacion
            var ordenesFiltradas = Modelo.OrdenesPreparacion
                .Where(orden =>
                    (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                    (string.IsNullOrEmpty(estadoAFiltrar) || orden.Estado.ToString() == estadoAFiltrar) &&
                    (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaOrdenRecepcion.Date == DateTime.Parse(fechaAFiltrar).Date) &&
                    (string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar))
                .ToList();

            // Agregar las órdenes filtradas a la lista
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

                OrdenesPreparacionList.Items.Add(fila);
            }     

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            CargarOrdenesPreparacion();
        }

        private void BotonAOrdenEntrega_Click(object sender, EventArgs e)
        {
            //Primero chequeo si selecciono alguna persona para editar
            if (OrdenesPreparacionList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la orden de entrega");
                return;
            }
            else
            {
                //Agarro la orden que seleccione para pasar a la orden de entrega
                ListViewItem itemSeleccionado = OrdenesPreparacionList.SelectedItems[0];

                //De esa orden que agarre, busco el IDOrden
                string idOrdenAValidar = itemSeleccionado.SubItems[0].Text;

                //valido si ya esta caragda esa orden
                if (validarOrdenAAgregar(idOrdenAValidar))
                {
                    //Mover los items de un listView al otro
                    MoverItems(OrdenesPreparacionList, OrdenesEntregaList);
                }
                else
                {
                    MessageBox.Show("La orden de entrega que estas queriendo insertar ya existe");
                }

            }

        }

        private bool validarOrdenAAgregar(string idOrdenAValidar)
        {
            //itero por las ordenes que hay en el listado de ordenes de entrega
            foreach (ListViewItem orden in OrdenesEntregaList.Items)
            {
                //valido si ya existe una ordenEntrega cargada con ese ID
                if (orden.SubItems[0].Text == idOrdenAValidar)
                {
                    return false;

                }
            }
            return true;
        }

        private void MoverItems(System.Windows.Forms.ListView origen, System.Windows.Forms.ListView destino)
        {
            //clono los datos de la list view de origen en la de destino
            //En esta itero por las ordenes seleccionadas en la listview de origen
            foreach (ListViewItem orden in origen.SelectedItems)
            {
                //la clono en la de destino
                destino.Items.Add((ListViewItem)orden.Clone());
            }
        }

        private void BotonSacarDeOrdenEntrega_Click(object sender, EventArgs e)
        {
            //Chequeo que se haya seleccionado una orden de preparacion de la orden de entrega para sacar
            if (OrdenesEntregaList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para sacar de la orden de entrega");
                return;
            }
            else
            {
                //Selecciono la orden de preparacion que voy a sacar de la la orden de entrega
                //Como solo puedo seleccionar de a 1 orden de preparacion, el index siempre va a ser [0]
                //Elimino la orden de preparacion del listado de ordenes de entrega
                OrdenesEntregaList.SelectedItems[0].Remove();
            }
        }

        private void BotonLimpiar_Click_1(object sender, EventArgs e)
        {
            // Limpio toda la data que escribio el usuario en la busqueda
            TxtIdOrdenPreparacion.Text = string.Empty;
            ComboBoxEstado.SelectedItem = null; // Establece el índice seleccionado a -1
            TxtFecha.Text = string.Empty;
            ComboBoxPrioridad.SelectedItem = null;

            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesPreparacion();
        }

        private void GenerarOrdenEntregaBoton_Click(object sender, EventArgs e)
        {
            //Muevo todas las ordenes que estaban en el listado de ordenesEntrega
            MoverTodosLosItems(OrdenesEntregaList, OrdenConfirmntregaadaList);

            OrdenEntrega ordenAAgregar = new();
            {
                //Obtengo de forma automatica un nuevo IDOrdenEntrega
                //Esto debiera validarse en el modelo o donde?
                string IDorden; //obtenerNuevoIDOrdenEntrega();
                //Obtengo la fecha de hoy
                DateTime FechaOrden = DateTime.Now;

                //Falta agregar el listado de ordenesPreparacion para sumarle


                string error = Modelo.AltaOrdenEntrega(ordenAAgregar);

                if (error != null)
                {
                    MessageBox.Show(error);
                    return;
                }
                else
                {
                    MessageBox.Show("Orden Entrega creada con exito");
                }

            }

        }

        private string obtenerNuevoIDOrdenEntrega(List<OrdenEntrega> ordenesEntrega)
        {
            // Ver si la orden que voy a cargar no es la primera
            if (ordenesEntrega.Count > 0)
            {
                // Ordena la lista por IDOrdenEntrega en orden descendente
                ordenesEntrega.Sort((a, b) => b.IDOrdenEntrega.CompareTo(a.IDOrdenEntrega));

                // Obtiene el último IDOrdenEntrega
                // Al estar ordenado de forma descendente, esta en el index [0]
                string ultimoID = ordenesEntrega[0].IDOrdenEntrega;

                // Con el substring agarro los numeros del ID, no me importan las letras
                // Con el int.Parse lo convierto a numero para poder sumarle 1
                int IDNumeros = int.Parse(ultimoID.Substring(3));

                //Obtengo el siguiente numero ID
                int NuevoNumero = IDNumeros + 1;

                //Ahora concateno la parte de letras del ID con la parte numerica transformada
                //Substring (0,3) me trae el "AA-" y despues el NumeroNuevo son los "0000"
                string nuevoID = ultimoID.Substring(0,3) + NuevoNumero.ToString();


                // Devuelve el nuevo ID como cadena
                return nuevoID;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor predeterminado (por ejemplo, "1")
                return "OE-0001";
            }
        }

        private void MoverTodosLosItems(System.Windows.Forms.ListView origen, System.Windows.Forms.ListView destino)
        {
            //Aca lo que hace es iterar por todas las ordenes que tiene la listView de origen
            foreach (ListViewItem orden in origen.Items)
            {
                //Toma esa orden en el listado de ordenes de origen y lo clona en la de destino
                destino.Items.Add((ListViewItem)orden.Clone());
            }
        }
    }
}
