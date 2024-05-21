using Pampazon.GrupoB.Prototipos.GestionarStock.ConsultarStock;

namespace Pampazon.GrupoB.Prototipos.OrdenesRecepción.ConfirmarOrdenRecepcion
{
    public class ListadoOrdenesRecepcionConfirmarModelo
    {
        public List<OrdenDeRecepcion> OrdenesRecepcion { get; set; }

        public ListadoOrdenesRecepcionConfirmarModelo()
        {
            OrdenesRecepcion = new List<OrdenDeRecepcion>
            {
                new OrdenDeRecepcion {IdOrdenRecepcion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Recepcion, Prioridad = "Baja" },
                new OrdenDeRecepcion {IdOrdenRecepcion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Recepcion, Prioridad = "Media" },
                new OrdenDeRecepcion {IdOrdenRecepcion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Recepcion, Prioridad = "Alta" },
                new OrdenDeRecepcion {IdOrdenRecepcion="OR-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Recepcion, Prioridad = "Baja" }
            };

        }




    }
}