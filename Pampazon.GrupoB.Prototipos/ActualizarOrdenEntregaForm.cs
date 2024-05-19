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
    public partial class ActualizarOrdenEntregaForm : Form
    {
        public ActualizarOrdenEntregaForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtFecha.Text = string.Empty;
            TxtIdOrdenSeleccion.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboBoxEstado.Text))
            {
                MessageBox.Show("El estado no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenSeleccion.Text))
            {
                MessageBox.Show("El id orden entrega no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            {
                MessageBox.Show("La fecha no puede estar vacía");
                return;
            }

            //if (!int.TryParse(this.TxtCantidad.Text, out var espaciondisponible))
            //{
            //    MessageBox.Show("La cantidad debe ser un valor númerico");
            //    return;
            //}

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida");
                return;
            }

            var formListadoOrdenesEntrega = new ListadoOrdenesEntregaForm();
            //formGestionarStock.Modelo = modelo;
            formListadoOrdenesEntrega.ShowDialog();
        }

        private void ActualizarOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            ComboBoxEstado.Items.Add(EstadoOrden.Recepcion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Preparacion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Seleccion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Entrega.ToString());
        }
    }
}
