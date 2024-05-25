using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
using System;
using System.Collections;
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
    public partial class ConsultarListaOrdenesSeleccionForm : Form
    {
        public ConsultarListaOrdenesSeleccionModelo Modelo;

        public ConsultarListaOrdenesSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIDCliente.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            TxtIdOrdenSeleccion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIDCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdOrdenSeleccion.Text))
            {
                MessageBox.Show("El id orden selección no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtFecha.Text))
            {
                MessageBox.Show("La fecha no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(ComboBoxPrioridad.Text))
            {
                MessageBox.Show("La prioridad no puede estar vacía");
                return;
            }

            //if (!int.TryParse(this.TxtCantidad.Text, out var espaciondisponible))
            //{
            //    MessageBox.Show("La cantidad debe ser un valor númerico");
            //    return;
            //}

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
                return;
            }
            CargarLista();

            //var formListadoOrdenesSeleccion = new ConsultarListaOrdenesSeleccionModelo();
            ////formGestionarStock.Modelo = modelo;
            //formListadoOrdenesSeleccion.ShowDialog();
        }

        private void ConsultarListaOrdenesSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
            CargarLista();

            PrioridadOrden[] listaprioridadordenes = (PrioridadOrden[])Enum.GetValues(typeof(PrioridadOrden));
            foreach(var prioridadorden in listaprioridadordenes)
            {
                ComboBoxPrioridad.Items.Add(prioridadorden.ToString());
            }

            //ComboBoxPrioridad.Items.Add(EstadoOrden.Recepcion.ToString());
            //ComboBoxPrioridad.Items.Add(EstadoOrden.Preparacion.ToString());
            //ComboBoxPrioridad.Items.Add(EstadoOrden.Seleccion.ToString());
            //ComboBoxPrioridad.Items.Add(EstadoOrden.Entrega.ToString());
        }

        private void CargarLista()
        {


            foreach (var ordenseleccion in Modelo.OrdenesSeleccion)
            {
                for (int i = 0; i < ordenseleccion.OrdenesPreparacion.Count; i++)
                {
                    var ordenpreparacion = ordenseleccion.OrdenesPreparacion[i];

                    for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
                    {
                        var fila = new ListViewItem();
                        //hacer algo con la fila
                        fila.Text = ordenseleccion.IDOrdenSeleccion.ToString();
                        fila.SubItems.Add(ordenseleccion.FechaCreacion.ToString());
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].IdCliente);
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].DescripcionCliente);
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Estado.ToString());
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Prioridad.ToString());
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].IDProducto);
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].DescripcionProducto);
                        fila.SubItems.Add(ordenseleccion.OrdenesPreparacion[i].Productos[j].Cantidad.ToString());

                        fila.Tag = ordenseleccion;
                        ListViewListaOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
        }
    }
}
