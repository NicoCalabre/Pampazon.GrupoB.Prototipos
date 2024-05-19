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
    public partial class CrearOrdenPreparacionForm : Form
    {
        public CrearOrdenPreparacionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void BotonLimpiar_Click(object sender, EventArgs e)
        //{


        //}

        //private void BotonCrear_Click(object sender, EventArgs e)
        //{

        //}

        private void BotonLimpiar_Click_1(object sender, EventArgs e)
        {
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
        }

        private void BotonCrear_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("La orden de recepción ha sido creada con éxito");
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
        }
    }
}
