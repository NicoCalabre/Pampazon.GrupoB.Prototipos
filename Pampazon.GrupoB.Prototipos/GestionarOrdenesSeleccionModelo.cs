namespace Pampazon.GrupoB.Prototipos
{
    public class GestionarOrdenesSeleccionModelo
    {
        public List<OrdenDeSeleccion> OrdenesSeleccion { get; set; }

        public GestionarOrdenesSeleccionModelo()
        {
            OrdenesSeleccion = new List<OrdenDeSeleccion>
            {
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Seleccion, Prioridad = "Baja" },
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Seleccion, Prioridad = "Media" },
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Seleccion, Prioridad = "Alta" },
                new OrdenDeSeleccion {IdOrdenSeleccion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenSeleccion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.Seleccion, Prioridad = "Baja" }
            };

        }

    }
}