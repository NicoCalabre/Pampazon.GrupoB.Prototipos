//namespace Pampazon.GrupoB.Prototipos
//{
//    public class CrearOrdenPreparacionModelo
//    {

//        // Propiedad para almacenar las órdenes de preparación
//        public List<OrdenPreparacionM> OrdenPreparacionM { get; set; }
//        public CrearOrdenPreparacionModelo()
//        {
//            // Inicializa la lista de órdenes de preparación
//            OrdenPreparacionM = new List<OrdenPreparacionM>
//            {
//                // Orden 1
//                new OrdenPreparacionM
//                {
//                    IDOrdenPreparacion = "OP-1234",
//                    IdCliente = "CC-1118",
//                    DescripcionCliente = "Cliente A",
//                    Productos = new List<ProductoM>
//                    {
//                        //Ingresar producto 1 en la orden de preparacion
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0000",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 10,
//                            Ubicacion = "x,y,z"
//                        },
//                        //Ingresar producto 2 en la orden de preparacion
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0001",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 5,
//                            Ubicacion = "x,y,z"
//                        }

//                    },
//                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
//                    Estado = EstadoOrdenM.Seleccionada,
//                    Prioridad = PrioridadM.Alta
//                },
//                // Orden 2
//                new OrdenPreparacionM
//                {
//                    IDOrdenPreparacion = "OP-1111",
//                    IdCliente = "CC-5900",
//                    DescripcionCliente = "Cliente A",
//                    Productos = new List<ProductoM>
//                    {
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0002",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 5,
//                            Ubicacion = "x,y,z"
//                        }
//                    },
//                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
//                    Estado = EstadoOrdenM.Seleccionada,
//                    Prioridad = PrioridadM.Alta
//                },
//                // Orden 3
//                new OrdenPreparacionM
//                {
//                    IDOrdenPreparacion = "OP-1235",
//                    IdCliente = "CC-5678",
//                    DescripcionCliente = "Cliente A",
//                    Productos = new List<ProductoM>
//                    {
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0031",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 5,
//                            Ubicacion = "x,y,z"
//                        },
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0002",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 5,
//                            Ubicacion = "x,y,z"
//                        }
//                    },
//                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
//                    Estado = EstadoOrdenM.Seleccionada,
//                    Prioridad = PrioridadM.Alta
//                },
//                // Orden 5
//                new OrdenPreparacionM
//                {
//                    IDOrdenPreparacion = "OP-2222",
//                    IdCliente = "CC-1111",
//                    DescripcionCliente = "Cliente A",
//                    Productos = new List<ProductoM>
//                    {
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0001",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 20,
//                            Ubicacion = "x,y,z"
//                        },
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0002",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 15,
//                            Ubicacion = "x,y,z"
//                        },
//                        new ProductoM
//                        {
//                            IDProducto = "PP-0003",
//                            DescripcionProducto = "Producto testing",
//                            Cantidad = 10,
//                            Ubicacion = "x,y,z"
//                        }
//                    },
//                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
//                    Estado = EstadoOrdenM.Seleccionada,
//                    Prioridad = PrioridadM.Alta
//                },
//            };
//        }
//    }
//}