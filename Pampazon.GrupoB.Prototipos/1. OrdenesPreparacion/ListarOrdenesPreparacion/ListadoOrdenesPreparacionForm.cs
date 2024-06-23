using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class ListadoOrdenesPreparacionForm : Form
    {
        public ListadoOrdenesPreparacionModelo Modelo;

        private List<OrdenPreparacion> ordenes;
        public ListadoOrdenesPreparacionForm()
        {
            InitializeComponent();
            Modelo = new();

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            // Limpiar los ítems actuales del ListView
            ListViewListaOrdenesPreparacion.Items.Clear();

            // Obtener los valores de los filtros
            string filtrarIdOrden = ComboBoxIDOrden.SelectedItem?.ToString().Trim().ToLower();
            string filtrarIdCliente = ComboBoxIDCliente.SelectedItem?.ToString().Trim().ToLower();
            string filtrarFecha = ComboBoxFecha.SelectedItem?.ToString().Trim().ToLower();
            string filtrarPrioridad = ComboBoxPrioridad.SelectedItem?.ToString().Trim().ToLower();
            string filtrarEstado = ComboBoxEstado.SelectedItem?.ToString().Trim().ToLower();

            // Filtrar los ítems de la lista de órdenes de preparación
            var filtrarOrdenes = Modelo.OrdenesPreparacion
                .Where(orden =>
                    (string.IsNullOrEmpty(filtrarIdOrden) || orden.IDOrdenPreparacion.ToLower().Contains(filtrarIdOrden)) &&
                    (string.IsNullOrEmpty(filtrarIdCliente) || orden.IdCliente.ToLower().Contains(filtrarIdCliente)) &&
                    (string.IsNullOrEmpty(filtrarFecha) || orden.FechaOrdenRecepcion.ToString().Contains(filtrarFecha)) &&
                    (string.IsNullOrEmpty(filtrarPrioridad) || orden.Prioridad.ToString().ToLower() == filtrarPrioridad) &&
                    (string.IsNullOrEmpty(filtrarEstado) || orden.Estado.ToString().ToLower() == filtrarEstado)
                ).ToList();

            // Iterar a través de las órdenes filtradas y agregarlas al ListView
            foreach (var ordenPreparacion in filtrarOrdenes)
            {
                var fila = new ListViewItem
                {
                    Text = ordenPreparacion.IDOrdenPreparacion
                };
                fila.SubItems.Add(ordenPreparacion.IdCliente);
                fila.SubItems.Add(ordenPreparacion.DescripcionCliente);
                fila.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());
                fila.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                fila.SubItems.Add(ordenPreparacion.Estado.ToString());

                fila.Tag = ordenPreparacion;
                ListViewListaOrdenesPreparacion.Items.Add(fila);
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoOrdenesPreparacionForm_Load(object sender, EventArgs e)
        {
            CargarLista();


            // Agrega columnas al ListView.
            ListViewListaOrdenesPreparacion.Columns.Add("ID Orden Preparación", 100);
            ListViewListaOrdenesPreparacion.Columns.Add("ID Cliente", 100);
            ListViewListaOrdenesPreparacion.Columns.Add("Descripción Cliente", 150);
            ListViewListaOrdenesPreparacion.Columns.Add("Fecha", 150);
            ListViewListaOrdenesPreparacion.Columns.Add("Prioridad", 100);
            ListViewListaOrdenesPreparacion.Columns.Add("Estado", 100);


            //Cargamos una lista de todos los id de cliente en el combo box.
            foreach (var idCliente in Modelo.OrdenesPreparacion)
            {
                ComboBoxIDCliente.Items.Add(idCliente.IdCliente.ToString());
            }

            //Cargamos una lista de todos los id de orden de preparacion en el combo box.
            foreach (var ordenPreparacion in Modelo.OrdenesPreparacion)
            {
                ComboBoxIDOrden.Items.Add(ordenPreparacion.IDOrdenPreparacion.ToString());
            }

            // Usar un HashSet para almacenar las prioridades únicas
            var fechasUnicas = new HashSet<string>();

            // Cargar la lista de todas las prioridades en el ComboBox sin duplicados
            foreach (var fecha in Modelo.OrdenesPreparacion)
            {
                // Intentar agregar la prioridad al HashSet
                if (fechasUnicas.Add(fecha.FechaOrdenRecepcion.ToString()))
                {
                    // Si la prioridad se agregó exitosamente, agregarla también al ComboBox
                    ComboBoxFecha.Items.Add(fecha.FechaOrdenRecepcion.ToString());
                }
            }


            // Usar un HashSet para almacenar las prioridades únicas
            var prioridadesUnicas = new HashSet<string>();

            // Cargar la lista de todas las prioridades en el ComboBox sin duplicados
            foreach (var prioridad in Modelo.OrdenesPreparacion)
            {
                // Intentar agregar la prioridad al HashSet
                if (prioridadesUnicas.Add(prioridad.Prioridad.ToString()))
                {
                    // Si la prioridad se agregó exitosamente, agregarla también al ComboBox
                    ComboBoxPrioridad.Items.Add(prioridad.Prioridad.ToString());
                }
            }

            // Usar un HashSet para almacenar las prioridades únicas
            var estadosUnicos = new HashSet<string>();

            // Cargar la lista de todas las prioridades en el ComboBox sin duplicados
            foreach (var estado in Modelo.OrdenesPreparacion)
            {
                // Intentar agregar la prioridad al HashSet
                if (estadosUnicos.Add(estado.Estado.ToString()))
                {
                    // Si la prioridad se agregó exitosamente, agregarla también al ComboBox
                    ComboBoxEstado.Items.Add(estado.Estado.ToString());


                }
            }

        }

        private void CargarLista()
        {
            foreach (var ordenrecepcion in Modelo.OrdenesPreparacion)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenrecepcion.IDOrdenPreparacion.ToString();
                fila.SubItems.Add(ordenrecepcion.IdCliente);
                fila.SubItems.Add(ordenrecepcion.DescripcionCliente);
                fila.SubItems.Add(ordenrecepcion.FechaOrdenRecepcion.ToString());
                fila.SubItems.Add(ordenrecepcion.Prioridad.ToString());
                fila.SubItems.Add(ordenrecepcion.Estado.ToString());
                fila.Tag = ordenrecepcion;
                ListViewListaOrdenesPreparacion.Items.Add(fila);
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            ComboBoxIDOrden.Text = null;
            ComboBoxIDCliente.Text = null;
            ComboBoxFecha.Text = null;
            ComboBoxPrioridad.Text = null;
            ComboBoxEstado.Text = null;
            ListViewListaOrdenesPreparacion.Items.Clear();
            CargarLista();
        }
    }
}

