using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos.OrdenesSeleccion.ListarOrdenesSeleccion;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class ListadoOrdenesSeleccionForm : Form
    {
        public ListadoOrdenesSeleccionModelo Modelo;

        public ListadoOrdenesSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoOrdenesSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            foreach (var ordenseleccion in Modelo.OrdenesSeleccion)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenseleccion.IdOrdenSeleccion.ToString();
                fila.SubItems.Add(ordenseleccion.IdCliente);
                fila.SubItems.Add(ordenseleccion.DescripcionCliente);
                fila.SubItems.Add(ordenseleccion.IdOrdenSeleccion);
                fila.SubItems.Add(ordenseleccion.FechaOrdenSeleccion.ToString());
                fila.SubItems.Add(ordenseleccion.EstadoSeleccion.ToString());
                fila.SubItems.Add(ordenseleccion.Prioridad);
                fila.Tag = ordenseleccion;
                ListViewListaOrdenSeleccion.Items.Add(fila);
            }
        }
    }
}
