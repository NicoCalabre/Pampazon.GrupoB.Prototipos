using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    public partial class DespachoOrdenEntregaForm : Form
    {
        public DespachoOrdenEntregaModelo Modelo;

        public DespachoOrdenEntregaForm()
        {
            InitializeComponent();
        }

        private void DespachoOrdenEntrega_Load(object sender, EventArgs e)
        {
            Modelo = new();

            //cargamos una lista de todos los id de orden de preparacion en el combo box. La idea es que el operario no tenga que memorizarse todos esos id. Pasa lo mismo con los id cliente
            foreach (var ordenEntrega in Archivos.ArchivoOrdenesEntrega.OrdenesEntrega)
            {
                IDOrdenEntregaComboBox.Items.Add(ordenEntrega.IDOrdenEntrega.ToString());
            }

            foreach (var ordenEntrega in Archivos.ArchivoOrdenesEntrega.OrdenesEntrega)
            {
                FechaOrdenEntregaComboBox.Items.Add(ordenEntrega.FechaCreacion.ToString());
            }

            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesEntrega();
        }

        private void CargarOrdenesEntrega()
        {
            //// Limpiamos la lista OrdenesEntregaList
            //OrdenesEntregaList.Items.Clear();

            //// Obtenemos los valores ingresados por el usuario desde los ComboBoxes
            //string idOrdenAFiltrar = IDOrdenEntregaComboBox.Text;
            //string fechaAFiltrar = FechaOrdenEntregaComboBox.Text;

            //// Filtramos las órdenes según la entrada del usuario
            //// Si ambos campos están vacíos, se devuelven todas las órdenes
            //// De lo contrario, filtramos por IDOrdenEntrega y FechaCreacion
            //var ordenesFiltradas = Archivos.ArchivoOrdenesEntrega.OrdenesEntrega
            //    .Where(orden =>
            //        (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenEntrega.Contains(idOrdenAFiltrar)) &&
            //        (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
            //    .ToList();

            //// Creamos un conjunto para almacenar los IDs existentes en las listas combinadas
            //var idsEnListasCombinadas = new HashSet<string>();

            //// Agregamos los IDs de OrdenesDespachoList y OrdenDespachoConfirmadaList al conjunto
            //foreach (ListViewItem ordenPreparacion in OrdenesDespachoList.Items)
            //{
            //    idsEnListasCombinadas.Add(ordenPreparacion.SubItems[1].Text);
            //}

            //foreach (ListViewItem ordenPreparacion in OrdenDespachoConfirmadaList.Items)
            //{
            //    idsEnListasCombinadas.Add(ordenPreparacion.SubItems[0].Text);
            //}

            //// Agregamos las órdenes filtradas a la lista OrdenesEntregaList
            //foreach (var ordenEntrega in ordenesFiltradas)
            //{
            //    foreach (var ordenPreparacion in ordenEntrega.OrdenesPreparacionIds)
            //    {
            //        if (!idsEnListasCombinadas.Contains(ordenPreparacion.IDOrdenPreparacion))
            //        {
            //            var fila = new ListViewItem();
            //            fila.Text = ordenEntrega.IDOrdenEntrega;
            //            fila.SubItems.Add(ordenPreparacion.IDOrdenPreparacion);
            //            fila.SubItems.Add(ordenPreparacion.IdCliente);
            //            fila.SubItems.Add(ordenEntrega.FechaCreacion.ToString());
            //            OrdenesEntregaList.Items.Add(fila);
            //        }
            //    }
            //}
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            CargarOrdenesEntrega();
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            // Limpio toda la data que escribio el usuario en la busqueda
            IDOrdenEntregaComboBox.Text = null;
            FechaOrdenEntregaComboBox.Text = null;


            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesEntrega();
        }


        private void MoverTodosLosItems(System.Windows.Forms.ListView origen, System.Windows.Forms.ListView destino)
        {
            //Aca lo que hace es iterar por todas las ordenes que tiene la listView de origen
            foreach (ListViewItem orden in origen.Items)
            {
                // Clonar solo las columnas que deseas (por ejemplo, índice 1, 2 y 3)
                ListViewItem newItem = new ListViewItem(orden.SubItems[1].Text); // Clonar columna 1
                newItem.SubItems.Add(orden.SubItems[2].Text); // Clonar columna 2
                newItem.SubItems.Add(orden.SubItems[3].Text); // Clonar columna 3

                // Agregar el nuevo ítem a la nueva ListView
                destino.Items.Add(newItem);
            }
        }

        private void BotonSacarOrdenDespacho_Click(object sender, EventArgs e)
        {
            //Chequeo que se haya seleccionado una orden de preparacion de la orden de entrega para sacar
            if (OrdenesDespachoList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para sacar de la orden de entrega");
                return;
            }
            else
            {
                //Muevo la orden seleccionada de vuelta a las ordenes de preparacion
                MoverItems(OrdenesDespachoList, OrdenesEntregaList);

                //Selecciono la orden de preparacion que voy a sacar de la la orden de entrega
                //Como solo puedo seleccionar de a 1 orden de preparacion, el index siempre va a ser [0]
                //Elimino la orden de preparacion del listado de ordenes de entrega
                OrdenesDespachoList.SelectedItems[0].Remove();
                OrdenesDespachoList.Refresh();
            }
        }

        private void BotonAgregarOrdenDespacho_Click(object sender, EventArgs e)
        {
            //Primero chequeo si selecciono alguna persona para editar
            if (OrdenesEntregaList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la orden de entrega");
                return;
            }
            else
            {
                //Agarro la orden que seleccione para pasar a la orden de entrega
                ListViewItem itemSeleccionado = OrdenesEntregaList.SelectedItems[0];

                //De esa orden que agarre, busco el IDOrdenPreparacion
                string idOrdenAValidar = itemSeleccionado.SubItems[1].Text;

                //valido si ya esta caragda esa orden
                if (validarOrdenAAgregar(idOrdenAValidar))
                {
                    //Mover los items de un listView al otro
                    MoverItems(OrdenesEntregaList, OrdenesDespachoList);
                    //Elimino la orden seleccionada del listado de ordenes de entrega
                    OrdenesEntregaList.SelectedItems[0].Remove();

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
            foreach (ListViewItem orden in OrdenesDespachoList.Items)
            {
                //valido si ya existe una ordenPreparacion cargada con ese ID
                if (orden.SubItems[1].Text == idOrdenAValidar)
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Cierro la pestaña actual y vuelvo a la anterior
            this.Close();
        }

        private void BotonCrearOrdenDespacho_Click(object sender, EventArgs e)
        {

            string error = Modelo.AltaOrdenDespacho(OrdenesDespachoList.Items);

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


        private void BotonAgregarDespacho_Click(object sender, EventArgs e)
        {
            if (OrdenesDespachoList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la orden de entrega");
                return;
            }
            else
            {
                //Muevo todas las ordenes que estaban en el listado de ordenesEntrega
                MoverTodosLosItems(OrdenesDespachoList, OrdenDespachoConfirmadaList);

                //Borro los elementos que estan en la orden de entrega para cargar los de la siguiente orden
                foreach (ListViewItem item in OrdenesDespachoList.Items)
                {
                    OrdenesDespachoList.Items.Remove(item);
                }
            }

            
        }
    }
}