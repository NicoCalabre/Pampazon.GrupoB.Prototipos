using Pampazon.GrupoB.Prototipos.GestionarStock.ConsultarStock;

namespace Pampazon.GrupoB.Prototipos.OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class ListadoOrdenesSeleccionModelo
    {
        public List<OrdenDeSeleccion> OrdenesSeleccion { get; set; }

        public ListadoOrdenesSeleccionModelo()
        {
            OrdenesSeleccion = new List<OrdenDeSeleccion>
            {
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Pendientes, Prioridad = "Baja" },
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Pendientes, Prioridad = "Media" },
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Pendientes, Prioridad = "Alta" },
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Pendientes, Prioridad = "Baja" }
            };

        }

    }
}