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
    public partial class ConfirmarOrdenRecepcionForm : Form
    {
        public ConfirmarOrdenRecepcionForm()
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
            TxtIdOrdenRecepcion.Text = string.Empty;
            TxtFechaRecepcion.Text = string.Empty;
        }


        private void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenRecepcion.Text))
            {
                MessageBox.Show("El id orden recepción no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFechaRecepcion.Text))
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

            if (!DateTime.TryParse(TxtFechaRecepcion.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida");
                return;
            }

            var formListadoOrdenesRecepcionConfirmar = new ListadoOrdenesRecepcionConfirmarForm();
            //formGestionarStock.Modelo = modelo;
            formListadoOrdenesRecepcionConfirmar.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }
        /*
        *         private void BotonLimpiar_Click(object sender, EventArgs e)
        {
           TxtIDCliente.Text = string.Empty;
           TxtIDProducto.Text = string.Empty;
           TxtCantidad.Text = string.Empty;
           TxtFecha.Text = string.Empty;

        }

        private void BotonCargar_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Se ha ingresado la mercadería con éxito");
           TxtIDCliente.Text = string.Empty;
           TxtIDProducto.Text = string.Empty;
           TxtCantidad.Text = string.Empty;
           TxtFecha.Text = string.Empty;
        }
        */
    }
}
