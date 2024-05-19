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
    public partial class ActualizarSeleccionEntregaForm : Form
    {
        public ActualizarSeleccionEntregaForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha actualizado el estado con éxito");
            this.Close();
        }
    }
}
