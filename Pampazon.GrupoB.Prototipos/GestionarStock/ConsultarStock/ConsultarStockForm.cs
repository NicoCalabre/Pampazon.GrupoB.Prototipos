using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos.GestionarStock.ConsultarStock;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class ConsultarStockForm : Form
    {
        public ListadoProductosGestionStockModelo Modelo;
        public ConsultarStockForm()
        {
            InitializeComponent();
        }

        public void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIDCliente.Text))
            {
                MessageBox.Show("El Id Cliente no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtDescripcionCliente.Text))
            {
                MessageBox.Show("La descripcion de cliente no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIDProducto.Text))
            {
                MessageBox.Show("El Id Producto no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtDescripcionProducto.Text))
            {
                MessageBox.Show("La descripción de producto no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(ComboBoxEstado.Text))
            {
                MessageBox.Show("El estado no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPrioridad.Text))
            {
                MessageBox.Show("La prioridad no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtPosicion.Text))
            {
                MessageBox.Show("La posición no puede estar vacía");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtEspacioDisponible.Text))
            {
                MessageBox.Show("El espacio disponible no puede estar vacío");
                return;
            }

            if (!int.TryParse(this.TxtEspacioDisponible.Text, out var espaciondisponible))
            {
                MessageBox.Show("El espacio disponible debe ser númerico");
                return;
            }
            //var persona = new Persona();
            //persona.Dni = dni;
            //persona.Apellido = this.TxtApellido.Text;
            //persona.Nombre = this.TxtNombre.Text;
            //persona.FechaNacimiento = fechaNacimiento;

            //string error = modelo.Validar(persona);
            //if (error == null) //si no hay errores
            //{
            //    MessageBox.Show("Todo OK!");
            //}
            //else
            //{
            //    MessageBox.Show(error);
            //}
            //            public string IdCliente { get; set; }
            //public string DescripcionCliente { get; set; }
            //public string IdProducto { get; set; }
            //public string DescripcionProducto { get; set; }
            //public int Cantidad { get; set; }
            // public DateTime FechaStock { get; set; }
            //public EstadoOrden Estado { get; set; }
            //public string Prioridad { get; set; }
            Stock stock = new()
            {
            IdCliente = TxtIDCliente.Text,
            DescripcionCliente = TxtDescripcionCliente.Text,
            IdProducto = TxtIDProducto.Text,
            DescripcionProducto = TxtDescripcionProducto.Text,
            Estado = Enum.Parse<EstadoOrden>(ComboBoxEstado.Text),
            Prioridad = TxtPrioridad.Text,
            Posicion = int.Parse(TxtPosicion.Text),
            EspacioDisponible = int.Parse(TxtEspacioDisponible.Text),
            };
            Modelo.Nuevo(stock);



            var formListadoProductosGestionStock = new ListadoProductosGestionStockForm();
            //formGestionarStock.Modelo = modelo;
            formListadoProductosGestionStock.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIDCliente.Text = string.Empty;
            TxtDescripcionCliente.Text = string.Empty;
            TxtIDProducto.Text = string.Empty;
            TxtDescripcionProducto.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
            TxtPrioridad.Text = string.Empty;
            TxtPosicion.Text = string.Empty;
            TxtEspacioDisponible.Text = string.Empty;

        }

        private void ConsultarStockForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            ComboBoxEstado.Items.Add(EstadoOrden.Recepcion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Preparacion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Seleccion.ToString());
            ComboBoxEstado.Items.Add(EstadoOrden.Entrega.ToString());

            /*
                Recepcion,
                Preparacion,
                Seleccion,
                Entrega
             */
        }
    }
}
