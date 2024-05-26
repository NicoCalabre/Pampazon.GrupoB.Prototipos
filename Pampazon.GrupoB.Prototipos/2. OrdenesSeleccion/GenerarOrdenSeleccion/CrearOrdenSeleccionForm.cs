using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion;
//using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class CrearOrdenSeleccionForm : Form
    {
        public CrearOrdenSeleccionModelo Modelo;

        //public List<OrdenPreparacion> listaordenespreparacion { get; set; }
        public CrearOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComboBoxIDOrdenPreparacion.Text))
            {
                MessageBox.Show("El Id orden preparación no puede estar vacío");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("El id cliente no puede estar vacía");
                return;
            }

            //if (string.IsNullOrWhiteSpace(TxtIdProducto.Text))
            //{
            //    MessageBox.Show("El Id Producto no puede estar vacío");
            //    return;
            //}

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

            //if (string.IsNullOrWhiteSpace(TxtUbicacion.Text))
            //{
            //    MessageBox.Show("La ubicación no puede estar vacía");
            //    return;
            //}

            if (!DateTime.TryParse(TxtFecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha no es válida. Debe tener el siguiente formato: Día/Mes/Año ");
                return;
            }


            //var formListadoOrdenesSeleccionConfirmar = new ListadoOrdenesSeleccionConfirmarForm();
            ////formGestionarStock.Modelo = modelo;
            //formListadoOrdenesSeleccionConfirmar.ShowDialog();
        }

        private void CrearOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
            CargarOrdenesPreparacion();
            CargarOrdenesSeleccion();



            foreach (var ordenpreparacion in Modelo.OrdenesPreparacion)
            {
                ComboBoxIDOrdenPreparacion.Items.Add(ordenpreparacion.IDOrdenPreparacion.ToString());
            }
        }

        private void CargarOrdenesPreparacion()
        {
            ListViewOrdenesPreparacion.Items.Clear();


            string idOrdenAFiltrar      = this.ComboBoxIDOrdenPreparacion.Text.Trim();
            string clienteAFiltrar      = this.TxtIdCliente.Text.Trim();
            string fechaAFiltrar        = this.TxtFecha.Text.Trim();
            string prioridadAFiltrar    = this.ComboBoxPrioridad.Text.Trim();

            var ordenesFiltradas = Modelo.OrdenesPreparacion
                                    .Where(orden =>
                                        (string.IsNullOrEmpty(idOrdenAFiltrar) || orden.IDOrdenPreparacion.Contains(idOrdenAFiltrar)) &&
                                        (string.IsNullOrEmpty(clienteAFiltrar) || orden.IdCliente.ToString() == clienteAFiltrar) &&
                                        (string.IsNullOrEmpty(fechaAFiltrar) || orden.FechaOrdenRecepcion.Date == DateTime.Parse(fechaAFiltrar).Date) &&
                                        (string.IsNullOrEmpty(prioridadAFiltrar) || orden.Prioridad.ToString() == prioridadAFiltrar))
                                    .ToList();

            foreach (var ordenPreparacion in ordenesFiltradas)
            {
                for (int i = 0; i < ordenPreparacion.Productos.Count; i++)
                {
                    var ordenpreparacion = ordenPreparacion.Productos[i];

                    var fila = new ListViewItem();
                    //Sumo los datos de las ordenes a la ListView del WInforms
                    fila.Text = ordenPreparacion.IDOrdenPreparacion.ToString();
                    fila.SubItems.Add(ordenPreparacion.IdCliente.ToString());
                    fila.SubItems.Add(ordenPreparacion.DescripcionCliente.ToString());
                    fila.SubItems.Add(ordenPreparacion.Estado.ToString());
                    fila.SubItems.Add(ordenPreparacion.Prioridad.ToString());
                    fila.SubItems.Add(ordenPreparacion.FechaOrdenRecepcion.ToString());

                    //string.Join lo que hace es concatenar elementos separados por ";"
                    //Select( producto => ) lo que hace es recorrer el listado de productos
                    //De ese listado de productos obtiene los datos relevantes y los concatena separandolos por ";"
                    var DescripcionProductosOrden = string.Join("; ",
                                                                ordenPreparacion.Productos.Select(
                                                                                                    producto =>
                                                                                                    $"IDProducto: {producto.IDProducto}, " +
                                                                                                    $"DescripcionProducto: {producto.DescripcionProducto}, " +
                                                                                                    $"Cantidad: {producto.Cantidad}, " +
                                                                                                    $"Ubicacion: {producto.Ubicacion}"
                                                                                                 )
                                                                );
                    //Sumo esas descripciones de producto a la columna de Productos en el WinForms
                    fila.SubItems.Add(DescripcionProductosOrden);
                    fila.SubItems.Add(ordenPreparacion.Productos[i].IDProducto.ToString());
                    fila.SubItems.Add(ordenPreparacion.Productos[i].Cantidad.ToString());

                    fila.Tag = ordenPreparacion;
                    ListViewOrdenesPreparacion.Items.Add(fila);
                }
            }
        }

        public void CargarOrdenesSeleccion() 
        {
            ListViewOrdenesSeleccion.Items.Clear();

            foreach (var ordenSeleccion in Modelo.OrdenesSeleccion)
            {
                for (int i = 0; i < ordenSeleccion.OrdenesPreparacion.Count; i++)
                {
                    var ordenpreparacion = ordenSeleccion.OrdenesPreparacion[i];

                    for (int j = 0; j < ordenpreparacion.Productos.Count; j++)
                    {
                        var fila = new ListViewItem();
                        fila.Text = ordenSeleccion.IDOrdenSeleccion.ToString();
                        fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].IDProducto.ToString());
                        fila.SubItems.Add(ordenSeleccion.OrdenesPreparacion[i].Productos[j].Cantidad.ToString());

                        fila.Tag = ordenSeleccion;
                        ListViewOrdenesSeleccion.Items.Add(fila);
                    }
                }
            }
        }

        private void BotonLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            ComboBoxIDOrdenPreparacion.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            TxtIdCliente.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
        }

        private void BotonBuscar_Click_1(object sender, EventArgs e)
        {
            CargarOrdenesPreparacion();
        }

        private void BotonGenerarOrdenSeleccion_Click_1(object sender, EventArgs e)
        {
            foreach(ListViewItem item in ListViewOrdenesPreparacionSeleccionadas.Items)
            {
                OrdenSeleccion ordenSeleccion = new()
                {
                    IDOrdenSeleccion = "OS-12345",
                    FechaCreacion = DateTime.Now,
                    OrdenesPreparacion = new List<OrdenPreparacion>
                    {
                        new OrdenPreparacion
                        {
                            //IDOrdenPreparacion = item.SubItems[0].Text,
                            Productos = new List<Producto>
                            {
                                new Producto
                                {
                                    IDProducto = item.SubItems[7].Text,
                                    Cantidad = int.Parse(item.SubItems[8].Text)
                                    

                                }
                                //new Producto
                                //{
                                //    IDProducto = item.SubItems[5].Text,
                                //    Cantidad = int.Parse(item.SubItems[6].Text)
                                //}
                            }
                        }
                    }    
                };
                Modelo.OrdenesSeleccion.Add(ordenSeleccion);

            }



            CargarOrdenesSeleccion();
        }

        private void BotonMoverOrdenPreparacion_Click(object sender, EventArgs e)
        {
            //Primero chequeo si selecciono alguna persona para editar
            if (ListViewOrdenesPreparacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la orden de preparación");
                return;
            }
            else
            {
                //Agarro la orden que seleccione para pasar a la orden de entrega
                ListViewItem itemSeleccionado = ListViewOrdenesPreparacion.SelectedItems[0];

                //De esa orden que agarre, busco el IDOrden
                string idOrdenAValidar = itemSeleccionado.SubItems[0].Text;

                MoverItems(ListViewOrdenesPreparacion, ListViewOrdenesPreparacionSeleccionadas);
            }
        }

        public void BotonMoverOrdenSeleccion_Click(object sender, EventArgs e)
        {
            //Primero chequeo si selecciono alguna persona para editar
            if (ListViewOrdenesPreparacionSeleccionadas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar alguna orden para agregar a la orden de preparación");
                return;
            }
            else
            {
                //Agarro la orden que seleccione para pasar a la orden de entrega
                ListViewItem itemSeleccionado = ListViewOrdenesPreparacionSeleccionadas.SelectedItems[0];

                //De esa orden que agarre, busco el IDOrden
                string idOrdenAValidar = itemSeleccionado.SubItems[0].Text;

                MoverItems(ListViewOrdenesPreparacionSeleccionadas,ListViewOrdenesPreparacion);
            }
        }

        public void BotonLimpiarOrdenesSeleccion_Click(object sender, EventArgs e)
        {

        }
        public void MoverItems(System.Windows.Forms.ListView origen, System.Windows.Forms.ListView destino)
        {
            //clono los datos de la list view de origen en la de destino
            //En esta itero por las ordenes seleccionadas en la listview de origen
            foreach (ListViewItem orden in origen.SelectedItems)
            {
                //la clono en la de destino
                destino.Items.Add((ListViewItem)orden.Clone());
                origen.Items.Remove(orden);
            }
        }

        //public string GenerarNuevoIDOrdenSeleccion()
        //{


        //    return null;
        //}
    }
}
