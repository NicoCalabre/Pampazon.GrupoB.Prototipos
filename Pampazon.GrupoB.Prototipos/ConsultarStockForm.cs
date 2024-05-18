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
    public partial class ConsultarStockForm : Form
    {
        public ConsultarStockForm()
        {
            InitializeComponent();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            var formListadoProductosGestionStock = new ListadoProductosGestionStockForm();
            //formGestionarStock.Modelo = modelo;
            formListadoProductosGestionStock.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIDCliente.Text = string.Empty;
            TxtDescripcionCliente.Text = string.Empty;
            TxtIDProducto.Text = string.Empty;
            TxtDescripcionProducto.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            TxtPosicion.Text = string.Empty;
            TxtEspacioDisponible.Text = string.Empty;

        }

        private void ConsultarStockForm_Load(object sender, EventArgs e)
        {
            ComboBoxEstado.Items.Add(EstadoOrden.Recepcion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Preparacion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Seleccion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Entrega.ToString());

            /*
                Recepcion,
                Preparacion,
                Seleccion,
                Entrega
             */
        }
    }
}
