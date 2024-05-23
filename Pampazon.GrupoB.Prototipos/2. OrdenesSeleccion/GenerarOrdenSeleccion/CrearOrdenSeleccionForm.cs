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
    public partial class CrearOrdenSeleccionForm : Form
    {
        public CrearOrdenSeleccionModelo Modelo;
        public CrearOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            //TxtIdCliente.Text = string.Empty;
            //TxtIdProducto.Text = string.Empty;
            //TxtIdOrdenPreparacion.Text = string.Empty;
            //TxtFecha.Text = string.Empty;
            //TxtUbicacion.Text = string.Empty;
            //TxtPrioridad.Text = string.Empty;
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIdOrdenPreparacion.Text))
            {
                MessageBox.Show("El Id orden preparación no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacía");
                return;
            }

            //if (string.IsNullOrWhiteSpace(TxtIdProducto.Text))
            //{
            //    MessageBox.Show("El Id Producto no puede estar vacío");
            //    return;
            //}

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

            //if (string.IsNullOrWhiteSpace(TxtUbicacion.Text))
            //{
            //    MessageBox.Show("La ubicación no puede estar vacía");
            //    return;
            //}

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
                return;
            }


            //var formListadoOrdenesSeleccionConfirmar = new ListadoOrdenesSeleccionConfirmarForm();
            ////formGestionarStock.Modelo = modelo;
            //formListadoOrdenesSeleccionConfirmar.ShowDialog();
        }

        private void CrearOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
        }
    }
}
