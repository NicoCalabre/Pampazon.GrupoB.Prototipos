using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class CrearOrdenEntregaForm : Form
    {
        public CrearOrdenEntregaModelo Modelo;
        public CrearOrdenEntregaForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIdOrdenSeleccion.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboBoxEstado.Text))
            {
                MessageBox.Show("El estado no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenSeleccion.Text))
            {
                MessageBox.Show("El id orden selección no puede estar vacío");
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

            MessageBox.Show("La orden de entrega ha sido creada con éxito");
            TxtIdOrdenSeleccion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;

        }

        private void CrearOrdenEntregaForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            //ComboBoxEstado.Items.Add(EstadoOrden.Recepcion.ToString());
            //ComboBoxEstado.Items.Add(EstadoOrden.Preparacion.ToString());
            //ComboBoxEstado.Items.Add(EstadoOrden.Seleccion.ToString());
            //ComboBoxEstado.Items.Add(EstadoOrden.Entrega.ToString());
        }
    }
}
