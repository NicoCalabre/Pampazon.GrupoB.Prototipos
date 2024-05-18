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

namespace Pampazon.GrupoB.Prototipos
{
    public partial class ListadoProductosGestionStockForm : Form
    {
        GestionarStockModelo Modelo;
        public ListadoProductosGestionStockForm()
        {
            InitializeComponent();
        }

        private void ListadoProductosGestionStockForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            foreach (var stock in Modelo.ListaStock)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = stock.IdCliente.ToString();
                fila.SubItems.Add(stock.DescripcionCliente);
                fila.SubItems.Add(stock.IdProducto);
                fila.SubItems.Add(stock.DescripcionProducto);
                fila.SubItems.Add(stock.Cantidad.ToString());
                fila.SubItems.Add(stock.FechaStock.ToString());
                fila.SubItems.Add(stock.Estado.ToString());
                fila.SubItems.Add(stock.Prioridad);

                fila.Tag = stock;
                ListViewListadoProductos.Items.Add(fila);
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
