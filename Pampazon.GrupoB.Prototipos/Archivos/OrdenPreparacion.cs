using System.Reflection;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public class OrdenPreparacion
    {
        public string IDOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        //public List<Producto> Productos { get; set; }
        public List<OrdenDetalle> Productos { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public EstadoOrden Estado { get; set; }
        public PrioridadOrden Prioridad { get; set; }


        public void CambiarEstadoOrden (List<OrdenPreparacion> listaordenespreparacion,string idOrdenPreparacion,EstadoOrden estado)
        {
            var ordenFiltrada = listaordenespreparacion.FirstOrDefault(orden => (orden.IDOrdenPreparacion == idOrdenPreparacion));
            listaordenespreparacion.Remove(ordenFiltrada);

            ordenFiltrada.Estado = estado;
            listaordenespreparacion.Add(ordenFiltrada);
        }
    }
}