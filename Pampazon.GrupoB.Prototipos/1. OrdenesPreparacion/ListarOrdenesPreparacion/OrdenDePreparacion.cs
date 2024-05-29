using Pampazon.GrupoB.Prototipos;

namespace Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion
{
    public class OrdenDePreparacion
    {
        private List<OrdenDePreparacion> orders;

        public string IdOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public EstadoOrden EstadoRecepcion { get; set; }
        public PrioridadA Prioridad { get; set; }
    }
}