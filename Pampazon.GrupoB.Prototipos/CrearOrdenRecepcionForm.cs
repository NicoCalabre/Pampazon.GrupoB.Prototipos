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
    public partial class CrearOrdenRecepcionForm : Form
    {
        public CrearOrdenRecepcionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIdOrdenRecepcion.Text = string.Empty;
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        private void BotonCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La orden de recepción ha sido creada con éxito");
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtIdOrdenRecepcion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }
    }
}
