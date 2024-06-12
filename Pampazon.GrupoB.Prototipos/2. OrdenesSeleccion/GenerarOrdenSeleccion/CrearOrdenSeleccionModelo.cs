using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion
{
    public class CrearOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }

        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        //public List<Producto> Productos { get; set; }

        //public OrdenSeleccion OrdenSeleccion { get; set; }
        //public PrioridadOrden Prioridad { get; set; }

        public CrearOrdenSeleccionModelo()
        {
            OrdenesSeleccion = new List<OrdenSeleccion>((IEnumerable<OrdenSeleccion>)ArchivoOrdenesSeleccion.OrdenesSeleccion);
            OrdenesPreparacion = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
        }

        public string AltaOrdenSeleccion(OrdenSeleccion ordenAAgregar)
        {
            //Agrego la orden al listado de ordenesEntrega
            OrdenesSeleccion.Add(ordenAAgregar);

            return null;
        }
    }
}