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
            var formListadoOrdenesRecepcion = new ListadoOrdenesRecepcionForm();
            //formGestionarStock.Modelo = modelo;
            formListadoOrdenesRecepcion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }



    }
}
