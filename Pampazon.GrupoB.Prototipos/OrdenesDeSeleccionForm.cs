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
    public partial class OrdenesDeSeleccionForm : Form
    {
        public OrdenesDeSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonListarOrdenesSeleccion_Click(object sender, EventArgs e)
        {
            var formConsultarListaOrdenesSeleccion = new ConsultarListaOrdenesSeleccionForm();
            //formGestionarStock.Modelo = modelo;
            formConsultarListaOrdenesSeleccion.ShowDialog();
        }

        private void BotonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            var formCrearOrdenSeleccion = new CrearOrdenSeleccionForm();
            //formGestionarStock.Modelo = modelo;
            formCrearOrdenSeleccion.ShowDialog();
        }
    }
}
