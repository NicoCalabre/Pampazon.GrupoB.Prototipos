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
    public partial class CrearOrdenSeleccionForm : Form
    {
        public CrearOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtUbicacion.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            var formListadoOrdenesSeleccionConfirmar = new ListadoOrdenesSeleccionConfirmarForm();
            //formGestionarStock.Modelo = modelo;
            formListadoOrdenesSeleccionConfirmar.ShowDialog();
        }
    }
}
