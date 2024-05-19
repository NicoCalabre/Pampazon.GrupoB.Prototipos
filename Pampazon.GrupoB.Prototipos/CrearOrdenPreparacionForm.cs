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
            if (string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenPreparacion.Text))
            {
                MessageBox.Show("El id orden preparación no puede estar vacío");
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

            if (string.IsNullOrWhiteSpace(TxtCantidad.Text))
            {
                MessageBox.Show("La cantidad no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdProducto.Text))
            {
                MessageBox.Show("El id producto no puede estar vacío");
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
