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
    public partial class ListadoOrdenesEntregaForm : Form
    {
        public GestionarOrdenesEntregaModelo Modelo;

        public ListadoOrdenesEntregaForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            var formActualizarSeleccionEntrega = new ActualizarSeleccionEntregaForm();
            //formGestionarStock.Modelo = modelo;
            formActualizarSeleccionEntrega.ShowDialog();
        }

        private void ListadoOrdenesEntregaForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            foreach (var ordenentrega in Modelo.OrdenesEntrega)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenentrega.IdOrdenEntrega.ToString();
                fila.SubItems.Add(ordenentrega.IdCliente);
                fila.SubItems.Add(ordenentrega.DescripcionCliente);
                fila.SubItems.Add(ordenentrega.IdProducto);
                fila.SubItems.Add(ordenentrega.DescripcionProducto);
                fila.SubItems.Add(ordenentrega.Cantidad.ToString());
                fila.SubItems.Add(ordenentrega.FechaOrdenEntrega.ToString());
                fila.SubItems.Add(ordenentrega.EstadoEntrega.ToString());
                fila.SubItems.Add(ordenentrega.Prioridad);
                fila.Tag = ordenentrega;
                ListViewListaOrdenesEntregaConfirmar.Items.Add(fila);
            }
        }

    }
}
