
namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    public class DespachoOrdenEntregaModelo
    {
        public List<OrdenEntrega> OrdenesEntrega { get; set; }
        public List<OrdenDespacho> OrdenesDespacho { get; set; }


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
                    IDOrdenEntrega = "OE-0002",
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
                    IDOrdenEntrega = "OE-0005",
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


        internal string AltaOrdenDespacho(ListView.ListViewItemCollection ordenesPreparacionAAgregar)
        {
            new OrdenDespacho
            {
                IDOrdenDespacho = obtenerNuevoIDOrdenEntrega(),
                FechaCreacion = DateTime.Now,
                OrdenesPreparacion = new List<OrdenPreparacion>()
            };

            foreach (ListViewItem ordenpreparacionAAgregar in ordenesPreparacionAAgregar)
            {
                var nuevaOrdenPreparacion = new OrdenPreparacion
                {
                    //Obtegno el ID de la orden de preparacion
                    IDOrdenPreparacion = ordenpreparacionAAgregar.Text.ToString(),
                    IdCliente = ordenpreparacionAAgregar.SubItems[0].ToString(),
                    //Agregar fecha


                };
            }

            return null;
        }




        private string obtenerNuevoIDOrdenEntrega()
        {
            // Ver si la orden que voy a cargar no es la primera
            if (OrdenesDespacho.Count > 0)
            {
                // Ordena la lista por IDOrdenEntrega en orden descendente
                OrdenesDespacho.Sort((a, b) => b.IDOrdenDespacho.CompareTo(a.IDOrdenDespacho));

                // Obtiene el último IDOrdenEntrega
                // Al estar ordenado de forma descendente, esta en el index [0]
                string ultimoID = OrdenesDespacho[0].IDOrdenDespacho;

                // Con el substring agarro los numeros del ID, no me importan las letras
                // Con el int.Parse lo convierto a numero para poder sumarle 1
                int IDNumeros = int.Parse(ultimoID.Substring(3));

                //Obtengo el siguiente numero ID
                int NuevoNumero = IDNumeros + 1;

                //Ahora concateno la parte de letras del ID con la parte numerica transformada
                //Substring (0,3) me trae el "AA-" y despues el NumeroNuevo son los "0000"
                string nuevoID = ultimoID.Substring(0, 3) + NuevoNumero.ToString();

                // Devuelve el nuevo ID como cadena
                return nuevoID;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor predeterminado (por ejemplo, "1")
                return "OE-0001";
            }
        }
    }
}

