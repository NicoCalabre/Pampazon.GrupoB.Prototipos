using Pampazon.GrupoB.Prototipos.OrdenesEntrega.CrearOrdenEntrega;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;


namespace Pampazon.GrupoB.Prototipos
{
    public class CrearOrdenEntregaModelo
    {

        // Propiedad para almacenar las órdenes de preparación
        public List<OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<OrdenEntrega> ordenesEntrega { get; set; }
        public CrearOrdenEntregaModelo()
        {
            // Inicializa la lista de órdenes de preparación
            OrdenesPreparacion = new List<OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion>
            {
                // Orden 1
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1234",
                    IdCliente = "CC-1118",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        //Ingresar producto 1 en la orden de preparacion
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0000",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 10,
                            Ubicacion = "x,y,z"
                        },
                        //Ingresar producto 2 en la orden de preparacion
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0001",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        }

                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada,
                    Prioridad = Prioridad.Alta
                },
                // Orden 2
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1111",
                    IdCliente = "CC-5900",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0002",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        }
                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada,
                    Prioridad = Prioridad.Alta
                },
                // Orden 3
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1235",
                    IdCliente = "CC-5678",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0031",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        },
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0002",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        }
                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada,
                    Prioridad = Prioridad.Alta
                },
                // Orden 5
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-2222",
                    IdCliente = "CC-1111",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0001",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 20,
                            Ubicacion = "x,y,z"
                        },
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0002",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 15,
                            Ubicacion = "x,y,z"
                        },
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0003",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 10,
                            Ubicacion = "x,y,z"
                        }
                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada,
                    Prioridad = Prioridad.Alta
                },
            };
        }

        internal string AltaOrdenEntrega(OrdenEntrega ordenAAgregar)
        {
            //Agrego la orden al listado de ordenesEntrega
            ordenesEntrega.Add(ordenAAgregar);

            return null;
        }
    }
}