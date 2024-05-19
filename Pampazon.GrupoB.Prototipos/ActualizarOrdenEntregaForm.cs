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
