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
        public CrearOrdenRecepcionModelo Modelo;
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

            if (string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenRecepcion.Text))
            {
                MessageBox.Show("El Id Producto no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            {
                MessageBox.Show("La fecha no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdProducto.Text))
            {
                MessageBox.Show("El id producto no puede estar vacío");
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

            MessageBox.Show("La orden de recepción ha sido creada con éxito");
            TxtIdCliente.Text = string.Empty;
            TxtIdProducto.Text = string.Empty;
            TxtIdOrdenRecepcion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        private void CrearOrdenRecepcionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
        }
    }
}
