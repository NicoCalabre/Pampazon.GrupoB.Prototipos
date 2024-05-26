namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion
{
    public class CrearOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<Producto> Productos { get; set; }

        public OrdenSeleccion OrdenSeleccion { get; set; }
        public PrioridadOrden Prioridad { get; set; }

        public CrearOrdenSeleccionModelo()
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




            };

            OrdenesPreparacion = new List<OrdenPreparacion>
            {
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1112",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4533",
                    DescripcionCliente = "Pepsi",
                    Prioridad = PrioridadOrden.Media,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "PE-1043",
                            Cantidad = 50
                        },
                        new Producto
                        {
                            IDProducto = "PE-1044",
                            Cantidad = 30
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1113",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4534",
                    DescripcionCliente = "Fanta",
                    Prioridad = PrioridadOrden.Alta,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "FA-1045",
                            Cantidad = 25
                        },
                        new Producto
                        {
                            IDProducto = "FA-1046",
                            Cantidad = 15
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1114",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4535",
                    DescripcionCliente = "Sprite",
                    Prioridad = PrioridadOrden.Baja,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "SP-1047",
                            Cantidad = 60
                        },
                        new Producto
                        {
                            IDProducto = "SP-1048",
                            Cantidad = 40
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1115",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4536",
                    DescripcionCliente = "7Up",
                    Prioridad = PrioridadOrden.Media,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "UP-1049",
                            Cantidad = 10
                        },
                        new Producto
                        {
                            IDProducto = "UP-1050",
                            Cantidad = 20
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1116",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4537",
                    DescripcionCliente = "DrPepper",
                    Prioridad = PrioridadOrden.Alta,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "DP-1051",
                            Cantidad = 35
                        },
                        new Producto
                        {
                            IDProducto = "DP-1052",
                            Cantidad = 25
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1117",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4538",
                    DescripcionCliente = "MountainDew",
                    Prioridad = PrioridadOrden.Baja,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "MD-1053",
                            Cantidad = 70
                        },
                        new Producto
                        {
                            IDProducto = "MD-1054",
                            Cantidad = 50
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1118",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4539",
                    DescripcionCliente = "Mirinda",
                    Prioridad = PrioridadOrden.Media,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "MR-1055",
                            Cantidad = 40
                        },
                        new Producto
                        {
                            IDProducto = "MR-1056",
                            Cantidad = 30
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1119",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4540",
                    DescripcionCliente = "Aquafina",
                    Prioridad = PrioridadOrden.Alta,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "AQ-1057",
                            Cantidad = 55
                        },
                        new Producto
                        {
                            IDProducto = "AQ-1058",
                            Cantidad = 45
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1120",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4541",
                    DescripcionCliente = "Gatorade",
                    Prioridad = PrioridadOrden.Baja,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "GT-1059",
                            Cantidad = 65
                        },
                        new Producto
                        {
                            IDProducto = "GT-1060",
                            Cantidad = 35
                        }
                    }
                },
                new OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1121",
                    Estado = EstadoOrden.Pendiente,
                    IdCliente = "CC-4542",
                    DescripcionCliente = "Lipton",
                    Prioridad = PrioridadOrden.Media,
                    Productos = new List<Producto>
                    {
                        new Producto
                        {
                            IDProducto = "LP-1061",
                            Cantidad = 75
                        },
                        new Producto
                        {
                            IDProducto = "LP-1062",
                            Cantidad = 85
                        }
                    }
                }
            };
            
        }
    }
}