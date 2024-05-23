using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;

namespace Pampazon.GrupoB.Prototipos.OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class OrdenPreparacion
    {//sumar cliente como clase
        public string IDOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public List<Producto> Productos { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public EstadoOrden Estado { get; set; }
        public Prioridad Prioridad { get; set; }
    }
}