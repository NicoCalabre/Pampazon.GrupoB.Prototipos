namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class OrdenSeleccion
    {
        public string IDOrdenSeleccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
    }
}