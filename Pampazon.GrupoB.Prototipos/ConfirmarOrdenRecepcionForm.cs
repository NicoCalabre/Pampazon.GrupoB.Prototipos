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
