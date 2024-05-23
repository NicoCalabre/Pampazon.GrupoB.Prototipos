using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;

namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class ConsultarListaOrdenesSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion{ get; set; }
        public List<Producto> Productos { get; set; }

        public OrdenSeleccion OrdenSeleccion { get; set; }

        public ConsultarListaOrdenesSeleccionModelo()
        {
            OrdenesSeleccion = new List<OrdenSeleccion>
            {
                new OrdenSeleccion
                {
                    IDOrdenSeleccion="OR-54367",
                    FechaCreacion=DateTime.Parse("11/1/2024"),
                    OrdenesPreparacion = new List <OrdenPreparacion>
                    {
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion="OP-1111",
                            Estado = EstadoOrden.EnSeleccion,
                            IdCliente = "CC-4532",
                            DescripcionCliente = "CocaCola",
                            Prioridad = PrioridadOrden.Alta,
                            Productos = new List <Producto>
                            {
                                new Producto 
                                {
                                    IDProducto  = "CC-1042",
                                    Cantidad    = 20 
                                },
                                new Producto
                                {
                                    IDProducto  = "BB-1042",
                                    Cantidad    = 40
                                }
                            }
                        },
                                                new OrdenPreparacion
                        {
                            IDOrdenPreparacion="OP-1111",
                            Estado = EstadoOrden.EnSeleccion,
                            IdCliente = "CC-4532",
                            DescripcionCliente = "CocaCola",
                            Prioridad = PrioridadOrden.Alta,
                            Productos = new List <Producto>
                            {
                                new Producto
                                {
                                    IDProducto  = "AA-1042",
                                    Cantidad    = 200
                                },
                                new Producto
                                {
                                    IDProducto  = "CC-1042",
                                    Cantidad    = 434
                                }
                            }
                        }
                    }
                }
                //new OrdenDeSeleccion {IDOrdenSeleccion="OR-54367", FechaCreacion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.EnSeleccion, IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, PrioridadSeleccion = Prioridad.Media},
                //new OrdenDeSeleccion {IDOrdenSeleccion="OR-54367", FechaCreacion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.EnSeleccion, IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, PrioridadSeleccion = Prioridad.Baja},
                //new OrdenDeSeleccion {IDOrdenSeleccion="OR-54367", FechaCreacion=DateTime.Parse("11/1/2024"), EstadoSeleccion = EstadoOrden.EnSeleccion, IdCliente="CC-4532", DescripcionCliente="CocaCola", IdProducto="CC-1042", DescripcionProducto="Liquidos", Cantidad=800, PrioridadSeleccion = Prioridad.Alta}
            };
        }
    }
}