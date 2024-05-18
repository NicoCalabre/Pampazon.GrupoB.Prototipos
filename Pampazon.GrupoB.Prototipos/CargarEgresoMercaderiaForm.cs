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
    public partial class CargarEgresoMercaderiaForm : Form
    {
        public CargarEgresoMercaderiaForm()
        {
            InitializeComponent();
        }

        private void CargarEgresoMercaderiaForm_Load(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIDCliente.Text = string.Empty;
            TxtIDProducto.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        private void BotonCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cargado el egreso de la mercadería con éxito");
            TxtIDCliente.Text = string.Empty;
            TxtIDProducto.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        /*
                 private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIDCliente.Text = string.Empty;
            TxtIDProducto.Text = string.Empty;
            TxtCantidad.Text = string.Empty;
            TxtFecha.Text = string.Empty;

        }

        private void BotonCargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha ingresado la mercadería con éxito");
        }
         */
    }
}
