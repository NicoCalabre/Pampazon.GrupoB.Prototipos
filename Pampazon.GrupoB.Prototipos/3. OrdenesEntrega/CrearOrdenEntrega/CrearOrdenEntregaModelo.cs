using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.CrearOrdenEntrega
{
    public class CrearOrdenEntregaModelo
    {

        // Propiedad para almacenar las órdenes de preparación
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacionSeleccionadas { get; set; }
        public List<OrdenEntrega> OrdenesEntrega { get; set; }
        public List<Producto> Productos { get; set; }

        public CrearOrdenEntregaModelo()
        {
            OrdenesEntrega = new List<OrdenEntrega>();
            OrdenesPreparacion = new List<OrdenPreparacion>();
            OrdenesPreparacionSeleccionadas = new List<OrdenPreparacion>();
            Productos = new List<Producto>();

            foreach (var oe in ArchivoOrdenesEntrega.OrdenesEntrega)
            {
                var oeModelo = new OrdenEntrega()
                {
                    FechaCreacion = oe.FechaCreacion,
                    IDOrdenEntrega = oe.IDOrdenEntrega,
                    OrdenesPreparacion = new List<OrdenPreparacion>() // Asegúrate de inicializar la lista
                };

                foreach (var op in oe.IDsOrdenesPreparacion)
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
                                    //Cantidad = prodArchivo.Cantidad,
                                    Cantidad = prod.Cantidad,
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

                        oeModelo.OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista de la orden de selección
                    }
                }

                OrdenesEntrega.Add(oeModelo); // Agrega la orden de selección a la lista principal
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

            foreach (var opSeleccionada in ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Seleccionada)).ToList())
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
                OrdenesPreparacionSeleccionadas.Add(opPreparacionModelo); // Agrega la orden de selección a la lista 
            }
        }

        public string obtenerNuevoIDOrdenEntrega()
        {
            // Ver si la orden que voy a cargar no es la primera
            if (OrdenesEntrega.Count > 0)
            {
                // Ordena la lista por IDOrdenEntrega en orden descendente
                OrdenesEntrega.Sort((a, b) => b.IDOrdenEntrega.CompareTo(a.IDOrdenEntrega));

                // Obtiene el último IDOrdenEntrega
                // Al estar ordenado de forma descendente, esta en el index [0]
                string ultimoID = OrdenesEntrega[0].IDOrdenEntrega;

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

        public void AltaOrdenEntrega(OrdenEntrega ordenEntregaAgregar)
        {
            //string testOrdenEntrega = OrdenEntrega.DetalleOrdenEntrega(ordenEntregaAgregar);
            //convertimos la orden de seleccion que nos da este formulario en la orden de seleccion que necesita el archivo/entidad
            Archivos.OrdenEntrega nuevaOrdenEntregaArchivo = new();
            List<string> ordenesPreparacionIds = new();

            nuevaOrdenEntregaArchivo.IDOrdenEntrega = ordenEntregaAgregar.IDOrdenEntrega;
            nuevaOrdenEntregaArchivo.FechaCreacion  = ordenEntregaAgregar.FechaCreacion;

            foreach (var ordenPreparacion in ordenEntregaAgregar.OrdenesPreparacion)
            {
                ordenesPreparacionIds.Add(ordenPreparacion.IDOrdenPreparacion.ToString());
            }

            nuevaOrdenEntregaArchivo.IDsOrdenesPreparacion = ordenesPreparacionIds;


            ArchivoOrdenesEntrega.AgregarOrdenEntrega(nuevaOrdenEntregaArchivo);

            //new OrdenesEntrega.DespachoOrdenEntrega.OrdenEntrega
            //{
            //    IDOrdenEntrega = obtenerNuevoIDOrdenEntrega(),
            //    FechaCreacion = DateTime.Now,
            //AgregarOrdenEntrega();
            //return null;
        }

        public void CambiarEstadoOrdenSeleccionada(string idOrdenPreparacion)
        {
            ArchivoOrdenesPreparacion.CambiarEstadoOrdenPreparacion(idOrdenPreparacion, Archivos.EstadoOrden.Preparada);

            OrdenesPreparacionSeleccionadas.Clear();

            foreach (var opSeleccionada in ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Seleccionada)).ToList())
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
                OrdenesPreparacionSeleccionadas.Add(opPreparacionModelo); // Agrega la orden de selección a la lista 
            }

        }

    }
}