using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos.GestionarStock.ConsultarStock;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class GestionarStockForm : Form
    {
        public GestionarStockModelo Modelo;


        public GestionarStockForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonConsultarStock_Click(object sender, EventArgs e)
        {
            var formConsultarStock = new ConsultarStockForm();
            //formGestionarStock.Modelo = modelo;
            formConsultarStock.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonEntradaMercaderia_Click(object sender, EventArgs e)
        {
            var formCargarEntradaMercaderia = new CargarEntradaMercaderiaForms();
            //formGestionarStock.Modelo = modelo;
            formCargarEntradaMercaderia.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonEgresoMercaderia_Click(object sender, EventArgs e)
        {
            var formCargarEgresoMercaderia = new CargarEgresoMercaderiaForm();
            //formGestionarStock.Modelo = modelo;
            formCargarEgresoMercaderia.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }
    }
}
