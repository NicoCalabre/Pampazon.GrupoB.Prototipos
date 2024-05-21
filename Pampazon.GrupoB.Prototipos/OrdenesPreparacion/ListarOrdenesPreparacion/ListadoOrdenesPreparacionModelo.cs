using Pampazon.GrupoB.Prototipos.GestionarStock.ConsultarStock;

namespace Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion
{
    public class ListadoOrdenesPreparacionModelo
    {
        public List<OrdenDePreparacion> OrdenesPreparacion { get; set; }

        public ListadoOrdenesPreparacionModelo()
        {
            OrdenesPreparacion = new List<OrdenDePreparacion>
            {
                new OrdenDePreparacion {IdOrdenPreparacion="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Preparacion, Prioridad = "Baja" },
                new OrdenDePreparacion {IdOrdenPreparacion="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Preparacion, Prioridad = "Media" },
                new OrdenDePreparacion {IdOrdenPreparacion="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Preparacion, Prioridad = "Alta" },
                new OrdenDePreparacion {IdOrdenPreparacion="OP-54367" , IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaOrdenRecepcion=DateTime.Parse("11/1/2024"), EstadoRecepcion = EstadoOrden.Preparacion, Prioridad = "Baja" }
            };

        }

    }
}