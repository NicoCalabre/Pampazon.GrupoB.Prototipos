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
    public partial class ListadoOrdenesRecepcionConfirmarForm : Form
    {
        public GestionarOrdenesRecepcionModelo Modelo;
        public ListadoOrdenesRecepcionConfirmarForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            var formActualizarSeleccion = new ActualizarSeleccionForm();
            //formGestionarStock.Modelo = modelo;
            formActualizarSeleccion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void ListadoOrdenesRecepcionConfirmarForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            foreach (var ordenrecepcion in Modelo.OrdenesRecepcion)
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
                ListViewListaOrdenesEntregaConfirmar.Items.Add(fila);
            }
        }
    }
}
