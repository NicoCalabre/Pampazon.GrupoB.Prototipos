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

        private List<OrdenDePreparacion> ordenes;
        public ListadoOrdenesPreparacionForm()
        {
            InitializeComponent();
            Modelo = new();

            // Agrega columnas al ListView.
            ListViewListaOrdenesPreparacion.Columns.Add("ID Orden Preparación", 50);
            ListViewListaOrdenesPreparacion.Columns.Add("ID Cliente", 100);
            ListViewListaOrdenesPreparacion.Columns.Add("Descripción Cliente", 100);
            ListViewListaOrdenesPreparacion.Columns.Add("Fecha", 100);
            ListViewListaOrdenesPreparacion.Columns.Add("Prioridad", 100);
            ListViewListaOrdenesPreparacion.Columns.Add("Estado", 100);

            // Inicializar ComboBoxes con valores de las enumeraciones
            ComboBoxPrioridad.DataSource = Enum.GetValues(typeof(PrioridadA));
            ComboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoOrden));

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            // Limpiar los ítems actuales del ListView
            ListViewListaOrdenesPreparacion.Items.Clear();

            // Obtener los valores de los filtros
            string filtrarIdOrden = TxtIdOrdenPreparacion.Text.Trim().ToLower();
            string filtrarIdCliente = TxtIDCliente.Text.Trim().ToLower();
            string filtrarFecha = TxtFecha.Text.Trim();
            string filtrarPrioridad = ComboBoxPrioridad.SelectedItem?.ToString().Trim().ToLower();
            string filtrarEstado = ComboBoxEstado.SelectedItem?.ToString().Trim().ToLower();

            // Filtrar los ítems de la lista de órdenes de preparación
            var filtrarOrdenes = Modelo.GenerarEjemplos()
                .Where(orden =>
                    (string.IsNullOrEmpty(filtrarIdOrden) || orden.IdOrdenPreparacion.ToLower().Contains(filtrarIdOrden)) &&
                    (string.IsNullOrEmpty(filtrarIdCliente) || orden.IdCliente.ToLower().Contains(filtrarIdCliente)) &&
                    (string.IsNullOrEmpty(filtrarFecha) || orden.FechaOrdenRecepcion.ToString("yyyy-MM-dd").Contains(filtrarFecha)) &&
                    (string.IsNullOrEmpty(filtrarPrioridad) || orden.Prioridad.ToString().ToLower() == filtrarPrioridad) &&
                    (string.IsNullOrEmpty(filtrarEstado) || orden.EstadoRecepcion.ToString().ToLower() == filtrarEstado)
                ).ToList();

            // Iterar a través de las órdenes filtradas y agregarlas al ListView
            foreach (var ordenPreparacion in filtrarOrdenes)
            {
                var fila = new ListViewItem
                {
                    Text = ordenPreparacion.IdOrdenPreparacion
                };
                fila.SubItems.Add(ordenPreparacion.IdCliente);
                fila.SubItems.Add(ordenPreparacion.DescripcionCliente);
                fila.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString("yyyy-MM-dd"));
                fila.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                fila.SubItems.Add(ordenPreparacion.EstadoRecepcion.ToString());

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
        }

        private void CargarLista()
        {
            foreach (var ordenrecepcion in Modelo.GenerarEjemplos())
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenrecepcion.IdOrdenPreparacion.ToString();
                fila.SubItems.Add(ordenrecepcion.IdCliente);
                fila.SubItems.Add(ordenrecepcion.DescripcionCliente);
                fila.SubItems.Add(ordenrecepcion.FechaOrdenRecepcion.ToString());
                fila.SubItems.Add(ordenrecepcion.Prioridad.ToString());
                fila.SubItems.Add(ordenrecepcion.EstadoRecepcion.ToString());
                fila.Tag = ordenrecepcion;
                ListViewListaOrdenesPreparacion.Items.Add(fila);
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtIDCliente.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
        }

    }
}

