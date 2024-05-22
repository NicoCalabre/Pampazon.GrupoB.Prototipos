using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    public partial class DespachoOrdenEntregaForm : Form
    {
        public DespachoOrdenEntregaModelo Modelo;
        public DespachoOrdenEntregaForm()
        {
            InitializeComponent();
        }

        private void DespachoOrdenEntrega_Load(object sender, EventArgs e)
        {
            Modelo = new();
        }
    }
}
