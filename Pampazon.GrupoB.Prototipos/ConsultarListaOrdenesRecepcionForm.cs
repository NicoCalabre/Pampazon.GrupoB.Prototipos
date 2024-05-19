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
    public partial class ConsultarListaOrdenesRecepcionForm : Form
    {

        public ConsultarListaOrdenesRecepcionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarListaOrdenesRecepcionForm_Load(object sender, EventArgs e)
        {
            ComboBoxEstado.Items.Add(EstadoOrden.Recepcion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Preparacion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Seleccion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Entrega.ToString());
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIDCliente.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            TxtIDOrdenesRecepcion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(ComboBoxEstado.Text))
            {
                MessageBox.Show("El estado no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIDCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIDOrdenesRecepcion.Text))
            {
                MessageBox.Show("El Id Producto no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            {
                MessageBox.Show("La fecha no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPrioridad.Text))
            {
                MessageBox.Show("La prioridad no puede estar vacía");
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

            var formListadoOrdenesRecepcion = new ListadoOrdenesRecepcionForm();
            //formGestionarStock.Modelo = modelo;
            formListadoOrdenesRecepcion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }



    }
}
