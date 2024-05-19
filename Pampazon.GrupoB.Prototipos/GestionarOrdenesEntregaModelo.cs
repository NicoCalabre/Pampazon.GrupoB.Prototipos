namespace Pampazon.GrupoB.Prototipos
{
    public class GestionarOrdenesEntregaModelo
    {
        public List<OrdenDeEntrega> OrdenesEntrega{ get; set; }

        public GestionarOrdenesEntregaModelo()
        {
            OrdenesEntrega = new List<OrdenDeEntrega>
            {
                new OrdenDeEntrega {IdOrdenEntrega="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenEntrega=DateTime.Parse("11/1/2024"), EstadoEntrega = EstadoOrden.Preparacion, Prioridad = "Baja" },
                new OrdenDeEntrega {IdOrdenEntrega="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenEntrega=DateTime.Parse("11/1/2024"), EstadoEntrega = EstadoOrden.Preparacion, Prioridad = "Media" },
                new OrdenDeEntrega {IdOrdenEntrega="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenEntrega=DateTime.Parse("11/1/2024"), EstadoEntrega = EstadoOrden.Preparacion, Prioridad = "Alta" },
                new OrdenDeEntrega {IdOrdenEntrega="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenEntrega=DateTime.Parse("11/1/2024"), EstadoEntrega = EstadoOrden.Preparacion, Prioridad = "Baja" }
            };

        }

    }
}