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
    public partial class CrearOrdenEntregaForm : Form
    {
        public CrearOrdenEntregaForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIdOrdenSeleccion.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La orden de entrega ha sido creada con éxito");
            TxtIdOrdenSeleccion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;

        }

        private void CrearOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            ComboBoxEstado.Items.Add(EstadoOrden.Recepcion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Preparacion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Seleccion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Entrega.ToString());
        }
    }
}
