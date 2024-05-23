using Pampazon.GrupoB.Prototipos;

namespace Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion
{
    public class OrdenDePreparacion
    {
        public string IdOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public string IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public EstadoOrden EstadoRecepcion { get; set; }
        public string Prioridad { get; set; }
    }
}