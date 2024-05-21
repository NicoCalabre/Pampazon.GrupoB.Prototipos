using Pampazon.GrupoB.Prototipos.GestionarStock.ConsultarStock;
using Pampazon.GrupoB.Prototipos.OrdenesEntrega.CrearOrdenEntrega;

namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega
{
    public class ListadoOrdenesEntregaModelo
    {
        public List<OrdenDeEntrega> OrdenesEntrega { get; set; }

        public ListadoOrdenesEntregaModelo()
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