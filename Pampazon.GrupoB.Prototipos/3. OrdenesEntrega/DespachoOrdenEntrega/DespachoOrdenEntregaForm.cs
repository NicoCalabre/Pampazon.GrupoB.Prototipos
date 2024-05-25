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

            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesEntrega();
        }

        private void CargarOrdenesEntrega()
        {
            // Borramos todo el listado de órdenes para volver a cargarlo
            // Esto asegura que al agregar una nueva orden, se actualice la lista
            OrdenesEntregaList.Items.Clear();

            // Obtener los valores ingresados por el usuario en los TextBoxs y los ComboBoxs
            string idOrdenAFiltrar = this.TxtIdOrdenEntrega.Text.Trim();
            string fechaAFiltrar = this.TxtFecha.Text.Trim();

            // Filtrar las órdenes según los campos ingresados por el usuario
            // Si ingreso todos, filtra por todos
            // Si no ingreso nada, trae todo el listado de ordenes de preparacion
            var ordenesFiltradas = Modelo.OrdenesEntrega
                .Where(orden =>
                    (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenEntrega.Contains(idOrdenAFiltrar)) &&
                    (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaCreacion.Date == DateTime.Parse(fechaAFiltrar).Date))
                .ToList();

            // Agregar las órdenes filtradas a la lista
            foreach (var ordenEntrega in ordenesFiltradas)
            {
                var fila = new ListViewItem();
                fila.Text = ordenEntrega.IDOrdenEntrega.ToString();
                fila.SubItems.Add(ordenEntrega.FechaCreacion.ToString());

                // Agregar la fila a la ListView
                OrdenesEntregaList.Items.Add(fila);
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
            TxtIdOrdenEntrega.Text = string.Empty;
            TxtFecha.Text = string.Empty;


            // Cargo el listado de ordenes al listView de ordenes
            CargarOrdenesEntrega();
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
                //Selecciono la orden de preparacion que voy a sacar de la la orden de entrega
                //Como solo puedo seleccionar de a 1 orden de preparacion, el index siempre va a ser [0]
                //Elimino la orden de preparacion del listado de ordenes de entrega
                OrdenesDespachoList.SelectedItems[0].Remove();
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

                //De esa orden que agarre, busco el IDOrden
                string idOrdenAValidar = itemSeleccionado.SubItems[0].Text;

                //valido si ya esta caragda esa orden
                if (validarOrdenAAgregar(idOrdenAValidar))
                {
                    //Mover los items de un listView al otro
                    MoverItems(OrdenesEntregaList, OrdenesDespachoList);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Cierro la pestaña actual y vuelvo a la anterior
            this.Close();
        }

        private void BotonCrearOrdenDespacho_Click(object sender, EventArgs e)
        {
            //Muevo todas las ordenes que estaban en el listado de ordenesEntrega
            MoverTodosLosItems(OrdenesEntregaList, OrdenDespachoConfirmadaList);

            OrdenEntrega ordenAAgregar = new();
            {
                //Obtengo de forma automatica un nuevo IDOrdenEntrega
                //Esto debiera validarse en el modelo o donde?
                string IDOrdenDespacho; //obtenerNuevoIDOrdenEntrega();
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

        private string obtenerNuevoIDOrdenEntrega(List<OrdenDespacho> ordenesDespacho)
        {
            // Ver si la orden que voy a cargar no es la primera
            if (ordenesDespacho.Count > 0)
            {
                // Ordena la lista por IDOrdenEntrega en orden descendente
                ordenesDespacho.Sort((a, b) => b.IDOrdenDespacho.CompareTo(a.IDOrdenDespacho));

                // Obtiene el último IDOrdenEntrega
                // Al estar ordenado de forma descendente, esta en el index [0]
                string ultimoID = ordenesDespacho[0].IDOrdenDespacho;

                // Con el substring agarro los numeros del ID, no me importan las letras
                // Con el int.Parse lo convierto a numero para poder sumarle 1
                int IDNumeros = int.Parse(ultimoID.Substring(3));

                //Obtengo el siguiente numero ID
                int NuevoNumero = IDNumeros + 1;

                //Ahora concateno la parte de letras del ID con la parte numerica transformada
                //Substring (0,3) me trae el "AA-" y despues el NumeroNuevo son los "0000"
                string nuevoID = ultimoID.Substring(0, 3) + NuevoNumero.ToString();


                // Devuelve el nuevo ID como cadena
                return nuevoID;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor predeterminado (por ejemplo, "1")
                return "OD-0001";
            }
        }
    }
}