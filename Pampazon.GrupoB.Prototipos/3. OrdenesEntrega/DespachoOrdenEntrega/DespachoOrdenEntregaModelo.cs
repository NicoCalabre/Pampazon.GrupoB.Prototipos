
using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    public class DespachoOrdenEntregaModelo
    {
        public List<OrdenEntrega> OrdenesEntrega { get; set; }
        public List<OrdenEntrega> OrdenesEntregaEstadoPreparada { get; set; }
        public List<OrdenDespacho> OrdenesDespacho { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<Producto> Productos { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacionEstadoPreparadas { get; set; }

        public DespachoOrdenEntregaModelo()
        {
            OrdenesEntrega                      = new();
            OrdenesEntregaEstadoPreparada       = new();
            OrdenesPreparacionEstadoPreparadas  = new();
            OrdenesDespacho = new();
            OrdenesPreparacion = new();
            Productos = new();

            foreach (var os in ArchivoOrdenesEntrega.OrdenesEntrega)
            {
                var osModelo = new OrdenEntrega()
                {
                    FechaCreacion = os.FechaCreacion,
                    IDOrdenEntrega = os.IDOrdenEntrega,
                    OrdenesPreparacion = new List<OrdenPreparacion>() // Asegúrate de inicializar la lista
                };

                foreach (var op in os.IDsOrdenesPreparacion)
                {
                    var opArchivo = ArchivoOrdenesPreparacion.OrdenesPreparacion.FirstOrDefault(orden => orden.IDOrdenPreparacion == op.ToString());

                    if (opArchivo != null) // Asegúrate de que la orden de preparación exista
                    {
                        var opModelo = new OrdenPreparacion()
                        {
                            IDOrdenPreparacion = opArchivo.IDOrdenPreparacion,
                            IdCliente = opArchivo.IdCliente,
                            DescripcionCliente = opArchivo.DescripcionCliente,
                            FechaOrdenRecepcion = opArchivo.FechaOrdenRecepcion,
                            Estado = (EstadoOrden)opArchivo.Estado,
                            Prioridad = (Prioridad)opArchivo.Prioridad,
                            Productos = new List<Producto>() // Asegúrate de inicializar la lista
                        };

                        foreach (var prod in opArchivo.Productos)
                        {
                            var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                            if (prodArchivo != null) // Asegúrate de que el producto exista
                            {
                                var prodModelo = new Producto()
                                {
                                    IDProducto = prodArchivo.IDProducto,
                                    IdCliente = prodArchivo.IdCliente,
                                    Cantidad = prodArchivo.Cantidad,
                                    DescripcionProducto = prodArchivo.DescripcionProducto,
                                    Ubicaciones = new List<ProductoDetalleStock>() // Asegúrate de inicializar la lista
                                };

                                foreach (var ubi in prodArchivo.Ubicaciones)
                                {
                                    var ubiModelo = new ProductoDetalleStock()
                                    {
                                        Ubicacion = ubi.Ubicacion,
                                        Cantidad = ubi.Cantidad
                                    };

                                    prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                                }

                                opModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                            }
                        }

                        osModelo.OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista de la orden de selección
                    }
                }

                OrdenesEntrega.Add(osModelo); // Agrega la orden de selección a la lista principal
            }

            foreach (var os in ArchivoOrdenesDespacho.OrdenesDespacho)
            {
                var osModelo = new OrdenDespacho()
                {
                    FechaCreacion = os.FechaCreacion,
                    IDOrdenDespacho = os.IDOrdenDespacho,
                    OrdenesPreparacion = new List<OrdenPreparacion>() // Asegúrate de inicializar la lista
                };

                foreach (var op in os.IDsOrdenesPreparacion)
                {
                    var opArchivo = ArchivoOrdenesPreparacion.OrdenesPreparacion.FirstOrDefault(orden => orden.IDOrdenPreparacion == op.ToString());

                    if (opArchivo != null) // Asegúrate de que la orden de preparación exista
                    {
                        var opModelo = new OrdenPreparacion()
                        {
                            IDOrdenPreparacion = opArchivo.IDOrdenPreparacion,
                            IdCliente = opArchivo.IdCliente,
                            DescripcionCliente = opArchivo.DescripcionCliente,
                            FechaOrdenRecepcion = opArchivo.FechaOrdenRecepcion,
                            Estado = (EstadoOrden)opArchivo.Estado,
                            Prioridad = (Prioridad)opArchivo.Prioridad,
                            Productos = new List<Producto>() // Asegúrate de inicializar la lista
                        };

                        foreach (var prod in opArchivo.Productos)
                        {
                            var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                            if (prodArchivo != null) // Asegúrate de que el producto exista
                            {
                                var prodModelo = new Producto()
                                {
                                    IDProducto = prodArchivo.IDProducto,
                                    IdCliente = prodArchivo.IdCliente,
                                    Cantidad = prodArchivo.Cantidad,
                                    DescripcionProducto = prodArchivo.DescripcionProducto,
                                    Ubicaciones = new List<ProductoDetalleStock>() // Asegúrate de inicializar la lista
                                };

                                foreach (var ubi in prodArchivo.Ubicaciones)
                                {
                                    var ubiModelo = new ProductoDetalleStock()
                                    {
                                        Ubicacion = ubi.Ubicacion,
                                        Cantidad = ubi.Cantidad
                                    };

                                    prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                                }

                                opModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                            }
                        }

                        osModelo.OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista de la orden de selección
                    }
                }

                OrdenesDespacho.Add(osModelo); // Agrega la orden de selección a la lista principal
            }

            foreach (var op in ArchivoOrdenesPreparacion.OrdenesPreparacion)
            {
                var opModelo = new OrdenPreparacion()
                {
                    IDOrdenPreparacion = op.IDOrdenPreparacion,
                    IdCliente = op.IdCliente,
                    DescripcionCliente = op.DescripcionCliente,
                    FechaOrdenRecepcion = op.FechaOrdenRecepcion,
                    Estado = (EstadoOrden)op.Estado,
                    Prioridad = (Prioridad)op.Prioridad,
                    Productos = new List<Producto>() // Asegúrate de inicializar la lista
                };

                foreach (var prod in op.Productos)
                {
                    var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                    if (prodArchivo != null) // Asegúrate de que el producto exista
                    {
                        var prodModelo = new Producto()
                        {
                            IDProducto = prodArchivo.IDProducto,
                            IdCliente = prodArchivo.IdCliente,
                            Cantidad = prodArchivo.Cantidad,
                            DescripcionProducto = prodArchivo.DescripcionProducto,
                            Ubicaciones = new List<ProductoDetalleStock>() // Asegúrate de inicializar la lista
                        };

                        foreach (var ubi in prodArchivo.Ubicaciones)
                        {
                            var ubiModelo = new ProductoDetalleStock()
                            {
                                Ubicacion = ubi.Ubicacion,
                                Cantidad = ubi.Cantidad
                            };

                            prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                        }

                        opModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                    }
                }

                OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista de la orden de selección
            }

            foreach (var opPreparada in ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Preparada)).ToList())
            {
                var opPreparacionModelo = new OrdenPreparacion()
                {
                    FechaOrdenRecepcion = opPreparada.FechaOrdenRecepcion,
                    IDOrdenPreparacion = opPreparada.IDOrdenPreparacion,
                    IdCliente = opPreparada.IDOrdenPreparacion,
                    DescripcionCliente = opPreparada.DescripcionCliente,
                    Estado = (EstadoOrden)opPreparada.Estado,
                    Prioridad = (Prioridad)opPreparada.Estado,
                    Productos = new List<Producto>()
                };

                foreach (var prod in opPreparada.Productos)
                {
                    var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                    if (prodArchivo != null) // Asegúrate de que el producto exista
                    {
                        var prodModelo = new Producto()
                        {
                            IDProducto = prodArchivo.IDProducto,
                            IdCliente = prodArchivo.IdCliente,
                            //Cantidad = prodArchivo.Cantidad,
                            Cantidad = prod.Cantidad,
                            DescripcionProducto = prodArchivo.DescripcionProducto,
                            Ubicaciones = new List<ProductoDetalleStock>()
                        };

                        foreach (var ubi in prodArchivo.Ubicaciones)
                        {
                            var ubiModelo = new ProductoDetalleStock()
                            {
                                Ubicacion = ubi.Ubicacion,
                                Cantidad = ubi.Cantidad
                            };
                            prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                        }

                        opPreparacionModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                    }

                }
                OrdenesPreparacionEstadoPreparadas.Add(opPreparacionModelo); // Agrega la orden de selección a la lista 
            }

            foreach (var oe in OrdenesEntrega)
            {
                if (oe.OrdenesPreparacion.Any(op => op.Estado.ToString() == "Preparada"))
                {
                    OrdenesEntregaEstadoPreparada.Add(oe);
                }
            }


        }

        public void AltaOrdenDespacho(OrdenDespacho ordenDespachoAgregar)
        {
            //string testOrdenEntrega = OrdenEntrega.DetalleOrdenEntrega(ordenEntregaAgregar);
            //convertimos la orden de Despacho que nos da este formulario en la orden de seleccion que necesita el archivo/entidad
            Archivos.OrdenDespacho nuevaOrdenDespachoArchivo = new();
            List<string> ordenesPreparacionIds = new();

            nuevaOrdenDespachoArchivo.IDOrdenDespacho = ordenDespachoAgregar.IDOrdenDespacho;
            nuevaOrdenDespachoArchivo.FechaCreacion = ordenDespachoAgregar.FechaCreacion;

            foreach (var ordenPreparacion in ordenDespachoAgregar.OrdenesPreparacion)
            {
                if (ordenPreparacion != null)
                {
                    ordenesPreparacionIds.Add(ordenPreparacion.IDOrdenPreparacion.ToString());

                }
            }

            nuevaOrdenDespachoArchivo.IDsOrdenesPreparacion = ordenesPreparacionIds;

            ArchivoOrdenesDespacho.AgregarOrdenDespacho(nuevaOrdenDespachoArchivo);


            OrdenesPreparacion.Clear();
            foreach (var op in ArchivoOrdenesPreparacion.OrdenesPreparacion)
            {
                var opModelo = new OrdenPreparacion()
                {
                    IDOrdenPreparacion = op.IDOrdenPreparacion,
                    IdCliente = op.IdCliente,
                    DescripcionCliente = op.DescripcionCliente,
                    FechaOrdenRecepcion = op.FechaOrdenRecepcion,
                    Estado = (EstadoOrden)op.Estado,
                    Prioridad = (Prioridad)op.Prioridad,
                    Productos = new List<Producto>() // Asegúrate de inicializar la lista
                };

                foreach (var prod in op.Productos)
                {
                    var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                    if (prodArchivo != null) // Asegúrate de que el producto exista
                    {
                        var prodModelo = new Producto()
                        {
                            IDProducto = prodArchivo.IDProducto,
                            IdCliente = prodArchivo.IdCliente,
                            Cantidad = prodArchivo.Cantidad,
                            DescripcionProducto = prodArchivo.DescripcionProducto,
                            Ubicaciones = new List<ProductoDetalleStock>() // Asegúrate de inicializar la lista
                        };

                        foreach (var ubi in prodArchivo.Ubicaciones)
                        {
                            var ubiModelo = new ProductoDetalleStock()
                            {
                                Ubicacion = ubi.Ubicacion,
                                Cantidad = ubi.Cantidad
                            };

                            prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                        }

                        opModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                    }
                }

                OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista de la orden de selección
            }



            OrdenesEntrega.Clear();
            foreach (var os in ArchivoOrdenesEntrega.OrdenesEntrega)
            {
                var osModelo = new OrdenEntrega()
                {
                    FechaCreacion = os.FechaCreacion,
                    IDOrdenEntrega = os.IDOrdenEntrega,
                    OrdenesPreparacion = new List<OrdenPreparacion>() // Asegúrate de inicializar la lista
                };

                foreach (var op in os.IDsOrdenesPreparacion)
                {
                    var opArchivo = ArchivoOrdenesPreparacion.OrdenesPreparacion.FirstOrDefault(orden => orden.IDOrdenPreparacion == op.ToString());

                    if (opArchivo != null) // Asegúrate de que la orden de preparación exista
                    {
                        var opModelo = new OrdenPreparacion()
                        {
                            IDOrdenPreparacion = opArchivo.IDOrdenPreparacion,
                            IdCliente = opArchivo.IdCliente,
                            DescripcionCliente = opArchivo.DescripcionCliente,
                            FechaOrdenRecepcion = opArchivo.FechaOrdenRecepcion,
                            Estado = (EstadoOrden)opArchivo.Estado,
                            Prioridad = (Prioridad)opArchivo.Prioridad,
                            Productos = new List<Producto>() // Asegúrate de inicializar la lista
                        };

                        foreach (var prod in opArchivo.Productos)
                        {
                            var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                            if (prodArchivo != null) // Asegúrate de que el producto exista
                            {
                                var prodModelo = new Producto()
                                {
                                    IDProducto = prodArchivo.IDProducto,
                                    IdCliente = prodArchivo.IdCliente,
                                    Cantidad = prodArchivo.Cantidad,
                                    DescripcionProducto = prodArchivo.DescripcionProducto,
                                    Ubicaciones = new List<ProductoDetalleStock>() // Asegúrate de inicializar la lista
                                };

                                foreach (var ubi in prodArchivo.Ubicaciones)
                                {
                                    var ubiModelo = new ProductoDetalleStock()
                                    {
                                        Ubicacion = ubi.Ubicacion,
                                        Cantidad = ubi.Cantidad
                                    };

                                    prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                                }

                                opModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                            }
                        }

                        osModelo.OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista de la orden de selección
                    }
                }

                OrdenesEntrega.Add(osModelo); // Agrega la orden de selección a la lista principal
            }

            OrdenesEntregaEstadoPreparada.Clear();
            foreach (var oe in OrdenesEntrega)
            {
                if (oe.OrdenesPreparacion.Any(op => op.Estado.ToString() == "Preparada"))
                {
                    OrdenesEntregaEstadoPreparada.Add(oe);
                }
            }

        }

        public void CambiarEstadoOrdenSeleccionada(string idOrdenPreparacion)
        {
            ArchivoOrdenesPreparacion.CambiarEstadoOrdenPreparacion(idOrdenPreparacion, Archivos.EstadoOrden.Despachada);

            OrdenesPreparacionEstadoPreparadas.Clear();

            foreach (var opSeleccionada in ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Preparada)).ToList())
            {
                var opPreparacionModelo = new OrdenPreparacion()
                {
                    FechaOrdenRecepcion = opSeleccionada.FechaOrdenRecepcion,
                    IDOrdenPreparacion = opSeleccionada.IDOrdenPreparacion,
                    IdCliente = opSeleccionada.IDOrdenPreparacion,
                    DescripcionCliente = opSeleccionada.DescripcionCliente,
                    Estado = (EstadoOrden)opSeleccionada.Estado,
                    Prioridad = (Prioridad)opSeleccionada.Estado,
                    Productos = new List<Producto>()
                };

                foreach (var prod in opSeleccionada.Productos)
                {
                    var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                    if (prodArchivo != null) // Asegúrate de que el producto exista
                    {
                        var prodModelo = new Producto()
                        {
                            IDProducto = prodArchivo.IDProducto,
                            IdCliente = prodArchivo.IdCliente,
                            //Cantidad = prodArchivo.Cantidad,
                            Cantidad = prod.Cantidad,
                            DescripcionProducto = prodArchivo.DescripcionProducto,
                            Ubicaciones = new List<ProductoDetalleStock>()
                        };

                        foreach (var ubi in prodArchivo.Ubicaciones)
                        {
                            var ubiModelo = new ProductoDetalleStock()
                            {
                                Ubicacion = ubi.Ubicacion,
                                Cantidad = ubi.Cantidad
                            };
                            prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                        }

                        opPreparacionModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                    }

                }
                OrdenesPreparacionEstadoPreparadas.Add(opPreparacionModelo); // Agrega la orden de selección a la lista 
            }

        }
        public string obtenerNuevoIDOrdenDespacho()
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

                //dependiendo de cual es el último numero de orden lo pasamos por este condicional para ver cuantos ceros le agregamos a la orden para mantener
                //el formato
                string numeroid = "";

                if (NuevoNumero <= 9)
                {
                    numeroid = "000" + NuevoNumero.ToString();

                }
                else if (NuevoNumero > 9 && NuevoNumero <= 99)
                {
                    numeroid = "00" + NuevoNumero.ToString();
                }
                else if (NuevoNumero > 99 && NuevoNumero <= 999)
                {
                    numeroid = "0" + NuevoNumero.ToString();
                }
                else if (NuevoNumero > 999)
                {
                    numeroid = NuevoNumero.ToString();
                }

                string nuevoID = ultimoID.Substring(0, 3) + numeroid;

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

