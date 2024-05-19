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
            var formListadoOrdenesSeleccion = new ListadoOrdenesSeleccionForm();
            //formGestionarStock.Modelo = modelo;
            formListadoOrdenesSeleccion.ShowDialog();
        }
    }
}
