using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TxtIDCliente.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            TxtIdOrdenSeleccion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIDCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenSeleccion.Text))
            {
                MessageBox.Show("El id orden selección no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            {
                MessageBox.Show("La fecha no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPrioridad.Text))
            {
                MessageBox.Show("La prioridad no puede estar vacía");
                return;
            }

            //if (!int.TryParse(this.TxtCantidad.Text, out var espaciondisponible))
            //{
            //    MessageBox.Show("La cantidad debe ser un valor númerico");
            //    return;
            //}

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
                return;
            }

            var formListadoOrdenesSeleccion = new ListadoOrdenesSeleccionForm();
            //formGestionarStock.Modelo = modelo;
            formListadoOrdenesSeleccion.ShowDialog();
        }

        private void ConsultarListaOrdenesSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
        }

        private void CargarLista()
        {
            foreach (var ordenseleccion Modelo.OrdenesSeleccion)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenseleccion.IdOrdenPreparacion.ToString();
                fila.SubItems.Add(ordenseleccion.IdCliente);
                fila.SubItems.Add(ordenseleccion.DescripcionCliente);
                fila.SubItems.Add(ordenseleccion.IdProducto);
                fila.SubItems.Add(ordenseleccion.DescripcionProducto);
                fila.SubItems.Add(ordenseleccion.Cantidad.ToString());
                fila.SubItems.Add(ordenseleccion.FechaOrdenRecepcion.ToString());
                fila.SubItems.Add(ordenseleccion.EstadoRecepcion.ToString());
                fila.SubItems.Add(ordenseleccion.Prioridad);
                fila.Tag = ordenseleccion;
                ListViewListaOrdenesSeleccion.Items.Add(fila);
        };
    }
}
