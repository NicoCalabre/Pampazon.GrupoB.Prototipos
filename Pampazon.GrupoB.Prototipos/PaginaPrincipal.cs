namespace Pampazon.GrupoB.Prototipos
{
    public partial class PaginaPrincipal : Form
    {
        OrdenesModelo modelo = new();

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
