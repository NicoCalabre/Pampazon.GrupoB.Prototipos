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
    public partial class OrdenesDeRecepcionForm : Form
    {
        public OrdenesDeRecepcionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonListarOrdenesRecepcion_Click(object sender, EventArgs e)
        {
            var formConsultarListaOrdenesRecepcion = new ConsultarListaOrdenesRecepcionForm();
            //formGestionarStock.Modelo = modelo;
            formConsultarListaOrdenesRecepcion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonCrearOrdenRecepcion_Click(object sender, EventArgs e)
        {
            var formCrearOrdenRecepcion = new CrearOrdenRecepcionForm();
            //formGestionarStock.Modelo = modelo;
            formCrearOrdenRecepcion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonConfirmarOrdenRecepcion_Click(object sender, EventArgs e)
        {
            var formConfirmarOrdenRecepcionForm = new ConfirmarOrdenRecepcionForm();
            //formGestionarStock.Modelo = modelo;
            formConfirmarOrdenRecepcionForm.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }
    }
}
