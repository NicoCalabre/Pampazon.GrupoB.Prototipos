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
    public partial class GestionarStockForm : Form
    {
        public GestionarStockModelo ModeloGS = new();


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
            var formListadoProductosGestion = new ListadoProductosGestionStockForm();
            //formGestionarStock.Modelo = modelo;
            formListadoProductosGestion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }
    }
}
