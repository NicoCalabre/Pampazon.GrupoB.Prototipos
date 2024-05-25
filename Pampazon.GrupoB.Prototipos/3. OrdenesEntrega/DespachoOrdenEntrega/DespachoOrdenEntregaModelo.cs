namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    public class DespachoOrdenEntregaModelo
    {
        public List<OrdenEntrega> OrdenesEntrega { get; set; }


        public DespachoOrdenEntregaModelo()
        {
            // Inicializa la lista de órdenes de preparación
            OrdenesEntrega = new List<OrdenEntrega>
            {
                // Orden Entrega 1
                new OrdenEntrega
                {
                    IDOrdenEntrega = "OE-0001",
                    FechaCreacion = DateTime.Now,
                    OrdenesPreparacion = new List<OrdenPreparacion>
                    {
                        //Orden Preparacion 1
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },
                       
                        //Orden Preparacion 2
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },
                        //Orden Preparacion 3
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },


                    }

                },

                // Orden Entrega 1
                new OrdenEntrega
                {
                    IDOrdenEntrega = "OE-0001",
                    FechaCreacion = DateTime.Now,
                    OrdenesPreparacion = new List<OrdenPreparacion>
                    {
                        //Orden Preparacion 1
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },
                       
                        //Orden Preparacion 2
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },
                        //Orden Preparacion 3
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },


                    }

                },

                // Orden Entrega 1
                new OrdenEntrega
                {
                    IDOrdenEntrega = "OE-0001",
                    FechaCreacion = DateTime.Now,
                    OrdenesPreparacion = new List<OrdenPreparacion>
                    {
                        //Orden Preparacion 1
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },
                       
                        //Orden Preparacion 2
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },
                        //Orden Preparacion 3
                        new OrdenPreparacion
                        {
                            IDOrdenPreparacion = "OP-0000",
                            IdCliente = "CC-0000",
                            DescripcionCliente = "Cliente testing",
                            Productos = new List<Producto>
                            {
                                //Ingresar producto 1 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0000",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 10,
                                    Ubicacion = "x,y,z"
                                },
                                //Ingresar producto 2 en la orden de preparacion
                                new Producto
                                {
                                    IDProducto = "PP-0001",
                                    DescripcionProducto = "Producto testing",
                                    Cantidad = 5,
                                    Ubicacion = "x,y,z"
                                }
                            },
                            FechaOrdenRecepcion = DateTime.Now,
                            Estado = EstadoOrden.Seleccionada,
                            Prioridad = Prioridad.Alta

                        },


                    }

                }

            };
        }

        internal string AltaOrdenEntrega(OrdenEntrega ordenAAgregar)
        {
            throw new NotImplementedException();
        }
    }
}
