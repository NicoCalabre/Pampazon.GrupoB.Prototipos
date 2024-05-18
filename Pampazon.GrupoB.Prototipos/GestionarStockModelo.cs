namespace Pampazon.GrupoB.Prototipos
{
    public class GestionarStockModelo
    {
        public List<Stock> ListaStock { get; set; }

        public GestionarStockModelo() 
        {
            ListaStock = new List<Stock>
            {
                new Stock {IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaStock=DateTime.Parse("11/1/2024"), Estado = EstadoOrden.Recepcion, Prioridad = "Baja" },
                new Stock {IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaStock=DateTime.Parse("11/1/2024"), Estado = EstadoOrden.Recepcion, Prioridad = "Media" },
                new Stock {IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaStock=DateTime.Parse("11/1/2024"), Estado = EstadoOrden.Recepcion, Prioridad = "Alta" },
                new Stock {IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, FechaStock=DateTime.Parse("11/1/2024"), Estado = EstadoOrden.Recepcion, Prioridad = "Baja" }
            };

        }


    }
}