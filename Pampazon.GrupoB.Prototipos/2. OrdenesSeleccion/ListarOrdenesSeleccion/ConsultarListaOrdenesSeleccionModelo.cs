using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
using Pampazon.GrupoB.Prototipos.OrdenesSeleccion.ListarOrdenesSeleccion;

namespace Pampazon.GrupoB.Prototipos
{
    public class ConsultarListaOrdenesSeleccionModelo
    {
        public List<OrdenDeSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion{ get; set; }
        public List<Producto> Productos { get; set; }

        public ConsultarListaOrdenesSeleccionModelo()
        {
            OrdenesSeleccion = new List<OrdenDeSeleccion>
            {
                new OrdenDeSeleccion {IDOrdenSeleccion="OR-54367", FechaCreacion=DateTime.Parse("11/1/2024"), OrdenesPreparacion = new List <OrdenPreparacion> { new OrdenPreparacion { Estado = EstadoOrden.EnSeleccion, IdCliente = "CC-4532", DescripcionCliente = "CocaCola", Prioridad = Prioridad.Alta, Productos = new List <Producto> { IDProducto = "CC-1042" } } } }
                //new OrdenDeSeleccion {IDOrdenSeleccion="OR-54367", FechaCreacion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.EnSeleccion, IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, PrioridadSeleccion = Prioridad.Media},
                //new OrdenDeSeleccion {IDOrdenSeleccion="OR-54367", FechaCreacion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.EnSeleccion, IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, PrioridadSeleccion = Prioridad.Baja},
                //new OrdenDeSeleccion {IDOrdenSeleccion="OR-54367", FechaCreacion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.EnSeleccion, IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, PrioridadSeleccion = Prioridad.Alta}
            };

        }

    }
}