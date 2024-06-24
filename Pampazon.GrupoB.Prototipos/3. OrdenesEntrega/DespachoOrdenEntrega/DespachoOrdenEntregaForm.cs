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
            // Crear conjuntos para almacenar valores únicos
            HashSet<string> idsUnicos = new HashSet<string>();
            HashSet<DateTime> fechasUnicas = new HashSet<DateTime>();

            foreach (var ordenEntrega in Modelo.OrdenesEntregaEstadoPreparada)
            {
                // Agregar ID de orden de entrega al conjunto
                idsUnicos.Add(ordenEntrega.IDOrdenEntrega.ToString());

                // Agregar fecha de creación al conjunto
                fechasUnicas.Add(ordenEntrega.FechaCreacion);
            }

            // Convertir conjuntos a listas (si es necesario)
            List<string> listaIdsUnicos = idsUnicos.ToList();
            List<DateTime> listaFechasUnicas = fechasUnicas.ToList();

            // Ahora puedes usar las listas con valores únicos según tus necesidades
            // Por ejemplo, para agregarlos a los ComboBox:
            foreach (var idUnico in listaIdsUnicos)
            {
                IDOrdenEntregaComboBox.Items.Add(idUnico);
            }

            foreach (var fechaUnica in listaFechasUnicas)
            {
                FechaOrdenEntregaComboBox.Items.Add(fechaUnica.ToString());
            }



            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesEntrega();
        }

        private void CargarOrdenesEntrega()
        {
            // Borramos todo el listado de órdenes para volver a cargarlo
            // Esto asegura que al agregar una nueva orden, se actualice la lista
            OrdenesEntregaList.Items.Clear();

            // Obtener los valores ingresados por el usuario en los TextBoxs y los ComboBoxs
            string idOrdenAFiltrar = this.IDOrdenEntregaComboBox.Text.ToString();
            string fechaAFiltrar = this.FechaOrdenEntregaComboBox.Text.ToString();

            // Filtrar las órdenes según los campos ingresados por el usuario
            // Si ingreso todos, filtra por todos
            // Si no ingreso nada, trae todo el listado de ordenes de preparacion
            var ordenesFiltradas = Modelo.OrdenesEntregaEstadoPreparada
                .Where(orden =>
                    (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenEntrega.Contains(idOrdenAFiltrar)) &&
                    (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
                .ToList();


            // Crear conjuntos para almacenar los IDs de las listas existentes
            // Crear conjuntos para almacenar los IDs de las listas existentes
            var idsEnLista1 = new HashSet<string>();
            var idsEnLista2 = new HashSet<string>();

            // Agarro los ids de la ListView OrdenesEntregaList y los meto en la lista
            foreach (ListViewItem ordenEntrega in OrdenesDespachoList.Items)
            {
                idsEnLista1.Add(ordenEntrega.Text.ToString());
            }

            // Agarro los ids de la ListView OrdenesEntregaList y los meto en la lista
            foreach (ListViewItem ordenEntrega in OrdenDespachoConfirmadaList.Items)
            {
                idsEnLista2.Add(ordenEntrega.Text.ToString());
            }

            // Agregar las órdenes filtradas a la lista
            foreach (var ordenEntrega in ordenesFiltradas)
            {
                foreach (var ordenPreparacion in ordenEntrega.OrdenesPreparacion)
                {

                    if (!idsEnLista1.Contains(ordenPreparacion.IDOrdenPreparacion) &&
                    !idsEnLista2.Contains(ordenPreparacion.IDOrdenPreparacion))
                    {
                        var fila = new ListViewItem();
                        fila.Text = ordenEntrega.IDOrdenEntrega;
                        fila.SubItems.Add(ordenPreparacion.IDOrdenPreparacion);
                        fila.SubItems.Add(ordenPreparacion.IdCliente);
                        fila.SubItems.Add(ordenEntrega.FechaCreacion.ToString());

                        // Agregar la fila a la ListView
                        OrdenesEntregaList.Items.Add(fila);
                    }
                }
            }

            // Actualizar la vista de la ListView
            OrdenesEntregaList.Update();
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
            if(OrdenDespachoConfirmadaList.Items.Count > 0)
            {
                List<string> ordenespreparacionagregar = new List<string>();

                foreach (ListViewItem item in OrdenDespachoConfirmadaList.Items)
                {
                    string idOrdenAFiltrar = item.SubItems[0].Text.ToString();
                    if (!ordenespreparacionagregar.Contains(idOrdenAFiltrar))
                    {
                        ordenespreparacionagregar.Add(idOrdenAFiltrar);
                    }
                }
                OrdenDespachoConfirmadaList.Items.Clear();

                string ordenentreganuevoid = Modelo.obtenerNuevoIDOrdenDespacho();
                //Esto funciona, hay que armarlo dinámico
                OrdenDespacho ordendespachoagregar = new OrdenDespacho
                {
                    IDOrdenDespacho = ordenentreganuevoid,
                    FechaCreacion = DateTime.Today,
                    OrdenesPreparacion = new List<OrdenPreparacion>()
                };

                foreach (string idorden in ordenespreparacionagregar)
                {
                    var ordenPreparacionAgregar = Modelo.OrdenesPreparacionEstadoPreparadas.FirstOrDefault(orden => orden.IDOrdenPreparacion == idorden.ToString());

                    if (ordenPreparacionAgregar != null) // Ensure the object is not null
                    {
                        ordendespachoagregar.OrdenesPreparacion.Add(ordenPreparacionAgregar);
                        Modelo.CambiarEstadoOrdenSeleccionada(idorden);
                    }
                }



                Modelo.AltaOrdenDespacho(ordendespachoagregar);
                //CargarOrdenesSeleccionFiltradas(ordenseleccionagregar);
                //CargarOrdenesPreparacion();
                OrdenesDespachoList.Refresh();
                //ActualizarComboBox();
                MessageBox.Show("“La orden de entrega ID: " + ordenentreganuevoid + " se ha generado con éxito”");
            }
            else
            {
                MessageBox.Show("Debe agregar ordenes de despacho para despachar");
            }


        }


        private void BotonAgregarDespacho_Click(object sender, EventArgs e)
        {
            if (OrdenesDespachoList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe agregar ordenes de preparación para despachar");
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