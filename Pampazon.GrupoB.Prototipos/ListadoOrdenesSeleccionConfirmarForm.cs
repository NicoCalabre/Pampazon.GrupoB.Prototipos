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
    public partial class ListadoOrdenesSeleccionConfirmarForm : Form
    {
        public GestionarOrdenesSeleccionModelo Modelo;

        public ListadoOrdenesSeleccionConfirmarForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            if (ListViewListaOrdenesSeleccionConfirmar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un ítem de la lista primero");
                return;
            }

            MessageBox.Show("La orden de selección se ha generado con éxito");
        }

        private void ListadoOrdenesSeleccionConfirmarForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            foreach (var ordenseleccion in Modelo.OrdenesSeleccion)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenseleccion.IdOrdenSeleccion.ToString();
                fila.SubItems.Add(ordenseleccion.IdCliente);
                fila.SubItems.Add(ordenseleccion.DescripcionCliente);
                fila.SubItems.Add(ordenseleccion.IdProducto);
                fila.SubItems.Add(ordenseleccion.DescripcionProducto);
                fila.SubItems.Add(ordenseleccion.Cantidad.ToString());
                fila.SubItems.Add(ordenseleccion.FechaOrdenSeleccion.ToString());
                fila.SubItems.Add(ordenseleccion.EstadoSeleccion.ToString());
                fila.SubItems.Add(ordenseleccion.Prioridad);
                fila.Tag = ordenseleccion;
                ListViewListaOrdenesSeleccionConfirmar.Items.Add(fila);
            }

        }
    }
}
