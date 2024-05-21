namespace Pampazon.GrupoB.Prototipos
{
    public partial class PaginaPrincipalForm : Form
    {
        public PaginaPrincipalModelo Modelo;
        public PaginaPrincipalForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            Modelo = new();
        }

        private void BotonGestionarStock_Click(object sender, EventArgs e)
        {
            var formGestionarStock = new GestionarStockForm();
            //formGestionarStock.Modelo = modelo;
            formGestionarStock.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonOrdenesRecepcion_Click(object sender, EventArgs e)
        {
            var formOrdenesRecepcion = new OrdenesDeRecepcionForm();
            //formGestionarStock.Modelo = modelo;
            formOrdenesRecepcion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonOrdenesPreparacion_Click(object sender, EventArgs e)
        {
            var formOrdenesPreparacion = new OrdenesDePreparacionForm();
            //formGestionarStock.Modelo = modelo;
            formOrdenesPreparacion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonOrdenesSeleccion_Click(object sender, EventArgs e)
        {
            var formOrdenesSeleccion = new OrdenesDeSeleccionForm();
            //formGestionarStock.Modelo = modelo;
            formOrdenesSeleccion.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }

        private void BotonOrdenesEntrega_Click(object sender, EventArgs e)
        {
            var formOrdenesEntrega = new OrdenesDeEntregaForm();
            //formGestionarStock.Modelo = modelo;
            formOrdenesEntrega.ShowDialog();//el codigo se detiene aca hasta que el formulario de cierre
        }
    }
}
