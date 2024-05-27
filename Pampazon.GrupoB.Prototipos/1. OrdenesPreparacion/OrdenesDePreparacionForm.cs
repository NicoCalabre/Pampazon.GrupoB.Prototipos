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
    public partial class OrdenesDePreparacionForm : Form
    {
        public OrdenesDePreparacionModelo Modelo;
        public OrdenesDePreparacionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonListarOrdenesPreparacion_Click(object sender, EventArgs e)
        {
            var formConsultarListaOrdenesPreparacion = new ListadoOrdenesPreparacionForm();
            //formGestionarStock.Modelo = modelo;
            formConsultarListaOrdenesPreparacion.ShowDialog();
        }

        private void BotonGenerarOrdenPreparacion_Click(object sender, EventArgs e)
        {
            var formCrearOrdenPreparacion = new CrearOrdenPreparacionForm();
            //formGestionarStock.Modelo = modelo;
            formCrearOrdenPreparacion.ShowDialog();
        }

        private void OrdenesDePreparacionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
        }
    }
}
