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

            //cargamos una lista de todos los id de orden de preparacion en el combo box. La idea es que el operario no tenga que memorizarse todos esos id. Pasa lo mismo con los id cliente
            foreach (var ordenPreparacion in Archivos.ArchivoOrdenesPreparacion.OrdenesPreparacion)
            {
                //Me tengo que asegurar de solo listar las que estan en estado "seleccionadas", no quiero otras
                if (ordenPreparacion.Estado.ToString() == "Seleccionada")
                {
                    IDOrdenPreparacionComboBox.Items.Add(ordenPreparacion.IDOrdenPreparacion.ToString());
                    FechaOrdenPreparacionComboBox.Items.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());
                }

            }

            // Cargo las prioridades posibles al combobox
            ComboBoxPrioridad.Items.Add(Prioridad.Baja.ToString());
            ComboBoxPrioridad.Items.Add(Prioridad.Media.ToString());
            ComboBoxPrioridad.Items.Add(Prioridad.Alta.ToString());

            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesPreparacion();

            //Cargo la primer orden de preparacion del listado con sus productos para que el operario arme la orden
            ListarPrimerOrdenPreparacion();

        }

        private void ListarPrimerOrdenPreparacion()
        {

            //if (OrdenesPreparacionList.Items.Count > 0)
            //{
            //    var primerOrden = (Archivos.OrdenPreparacion)OrdenesPreparacionList.Items[0].Tag;

            //    // Iterar a través de los productos de la primera orden
            //    foreach (var producto in primerOrden.ProductosIds)
            //    {
                    
            //        // Obtener los datos del producto
            //        string nroOrden = primerOrden.IDOrdenPreparacion;
            //        string idCliente = primerOrden.IdCliente;
            //        string descripcionProducto = producto.DescripcionProducto;
            //        int cantidadProducto = producto.Cantidad;

            //        // Crear un nuevo elemento para la Orden de Entrega
            //        var filaEntrega = new ListViewItem();
            //        filaEntrega.Text = nroOrden;
            //        filaEntrega.SubItems.Add(idCliente);
            //        filaEntrega.SubItems.Add(descripcionProducto);
            //        filaEntrega.SubItems.Add(cantidadProducto.ToString());

            //        // Agregar la fila a la lista de Ordenes de Entrega
            //        OrdenesEntregaList.Items.Add(filaEntrega);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No hay órdenes de preparación en la lista.");
            //}



        }

        private void CargarOrdenesPreparacion()
        {
            // Borramos todo el listado de órdenes para volver a cargarlo
            // Esto asegura que al agregar una nueva orden, se actualice la lista
            OrdenesPreparacionList.Items.Clear();

            // Obtener los valores ingresados por el usuario en los TextBoxs y los ComboBoxs
            string idOrdenAFiltrar = this.IDOrdenPreparacionComboBox.Text.ToString();
            string fechaAFiltrar = this.FechaOrdenPreparacionComboBox.Text.ToString();
            string prioridadAFiltrar = this.ComboBoxPrioridad.Text.Trim();

            // Filtrar las órdenes según los campos ingresados por el usuario
            // Si ingreso todos, filtra por todos
            // Si no ingreso nada, trae todo el listado de órdenes de preparación
            var ordenesFiltradas = Archivos.ArchivoOrdenesPreparacion.OrdenesPreparacion
                .Where(orden =>
                    (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                    (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaOrdenRecepcion.Date == DateTime.Parse(fechaAFiltrar).Date) &&
                    (string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar) &&
                    (orden.Estado.ToString() == "Seleccionada"))
                .ToList();


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Necesito filtrar que las ordenes que tengo que listar no esten en los IDS de OrdenesEntregaList ni OrdenConfirmntregaadaList
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Crear conjuntos para almacenar los IDs de las listas existentes
            // Crear conjuntos para almacenar los IDs de las listas existentes
            var idsEnLista1 = new HashSet<string>();
            var idsEnLista2 = new HashSet<string>();

            // Agarro los ids de la ListView OrdenesEntregaList y los meto en la lista
            foreach (ListViewItem ordenEntrega in OrdenesEntregaList.Items)
            {
                idsEnLista1.Add(ordenEntrega.Text.ToString());
            }

            // Agarro los ids de la ListView OrdenesEntregaList y los meto en la lista
            foreach (ListViewItem ordenEntrega in OrdenConfirmntregaadaList.Items)
            {
                idsEnLista2.Add(ordenEntrega.Text.ToString());
            }


            // Agregar las órdenes filtradas a la lista
            foreach (var ordenPreparacion in ordenesFiltradas)
            {
                //Hago una validacion de si el ID de la orden no esta ya en las ordenes de entrega
                if (!idsEnLista1.Contains(ordenPreparacion.IDOrdenPreparacion) &&
                !idsEnLista2.Contains(ordenPreparacion.IDOrdenPreparacion))
                {
                    var fila = new ListViewItem();
                    // Sumo los datos de las órdenes a la ListView del WinForms
                    fila.Text = ordenPreparacion.IDOrdenPreparacion.ToString();
                    fila.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                    fila.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                    fila.SubItems.Add(ordenPreparacion.Estado.ToString());
                    fila.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                    fila.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());


                    fila.Tag = ordenPreparacion;

                    OrdenesPreparacionList.Items.Add(fila);
                }


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
                origen.SelectedItems[0].Remove();
                origen.Refresh();
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
                //Muevo la orden seleccionada de vuelta a las ordenes de preparacion
                MoverItems(OrdenesEntregaList, OrdenesPreparacionList);

            }
        }

        private void BotonLimpiar_Click_1(object sender, EventArgs e)
        {
            // Limpio toda la data que escribio el usuario en la busqueda
            IDOrdenPreparacionComboBox.Text = null;
            FechaOrdenPreparacionComboBox.Text = null;
            ComboBoxPrioridad.SelectedItem = null;

            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesPreparacion();
        }

        private void GenerarOrdenEntregaBoton_Click(object sender, EventArgs e)
        {

            string error = Modelo.AltaOrdenEntrega(OrdenConfirmntregaadaList.Items);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }
            else
            {
                MessageBox.Show("Orden Entrega creada con exito");
                //Falta actualizar el estado de las ordenes de preparacion dentro de la orden
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

        private void AgregarOrdenEntregaBoton_Click(object sender, EventArgs e)
        {
            //Muevo todas las ordenes que estaban en el listado de ordenesEntrega
            MoverTodosLosItems(OrdenesEntregaList, OrdenConfirmntregaadaList);

            
            //Elimino la primer orden de preparacion de la listview porque ya esta completa
            if (OrdenesPreparacionList.Items.Count > 0)
            {
                OrdenesPreparacionList.Items[0].Remove();
            }
            else
            {
                MessageBox.Show("No hay mas ordenes para agregar");
            }
            

            //Borro los elementos que estan en la orden de entrega para cargar los de la siguiente orden
            foreach (ListViewItem item in OrdenesEntregaList.Items)
            {
                OrdenesEntregaList.Items.Remove(item);
            }
            

            ListarPrimerOrdenPreparacion();
        }

        private void BotonVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
