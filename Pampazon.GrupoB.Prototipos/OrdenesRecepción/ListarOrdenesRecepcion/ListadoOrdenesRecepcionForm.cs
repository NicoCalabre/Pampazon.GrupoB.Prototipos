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
using Pampazon.GrupoB.Prototipos.OrdenesRecepción.ConfirmarOrdenRecepcion;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class ListadoOrdenesRecepcionForm : Form
    {
        public ListadoOrdenesRecepcionModelo Modelo;
        public ListadoOrdenesRecepcionForm()
        {
            InitializeComponent();
        }

        public void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListViewListadoProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListadoOrdenesRecepcionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            foreach (var ordenrecepcion in Modelo.OrdenesRecepcion)//cuando armemos la lista en el modelo de este forms esto se soluciona
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenrecepcion.IdOrdenRecepcion.ToString();
                fila.SubItems.Add(ordenrecepcion.IdCliente);
                fila.SubItems.Add(ordenrecepcion.DescripcionCliente);
                fila.SubItems.Add(ordenrecepcion.IdProducto);
                fila.SubItems.Add(ordenrecepcion.DescripcionProducto);
                fila.SubItems.Add(ordenrecepcion.Cantidad.ToString());
                fila.SubItems.Add(ordenrecepcion.FechaOrdenRecepcion.ToString());
                fila.SubItems.Add(ordenrecepcion.EstadoRecepcion.ToString());
                fila.SubItems.Add(ordenrecepcion.Prioridad);
                fila.Tag = ordenrecepcion;
                ListViewListaOrdenesRecepcion.Items.Add(fila);
            }
        }
    }
}
