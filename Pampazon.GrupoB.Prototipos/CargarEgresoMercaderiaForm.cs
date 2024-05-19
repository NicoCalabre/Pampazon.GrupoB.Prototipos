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

            if (string.IsNullOrWhiteSpace(TxtIDCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIDProducto.Text))
            {
                MessageBox.Show("El Id Producto no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            {
                MessageBox.Show("La fecha no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCantidad.Text))
            {
                MessageBox.Show("La cantidad no puede estar vacía");
                return;
            }


            if (!int.TryParse(this.TxtCantidad.Text, out var espaciondisponible))
            {
                MessageBox.Show("La cantidad debe ser un valor númerico");
                return;
            }

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
                return;
            }

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
