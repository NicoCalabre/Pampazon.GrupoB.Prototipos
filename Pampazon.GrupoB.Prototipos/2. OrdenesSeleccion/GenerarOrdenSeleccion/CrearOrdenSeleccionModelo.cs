using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion
{
    public class CrearOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacionPendientes { get; set; }
        public List<Producto> Productos { get; set; }
        public CrearOrdenSeleccionModelo()
        {
            OrdenesSeleccion = new();
            OrdenesPreparacion = new();
            OrdenesPreparacionPendientes = new();
            Productos = new();

            //CargarListaOrdenesSeleccion();

            foreach (var os in ArchivoOrdenesSeleccion.OrdenesSeleccion)
            {
                var osModelo = new OrdenSeleccion()
                {
                    FechaCreacion = os.FechaCreacion,
                    IDOrdenSeleccion = os.IDOrdenSeleccion,
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
                            Prioridad = (PrioridadOrden)opArchivo.Prioridad,
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

                        osModelo.OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista de la orden de selección
                    }
                }

                OrdenesSeleccion.Add(osModelo); // Agrega la orden de selección a la lista principal
            }

            //Levantamos únicamente las ordenes de preparacion pendientes
            foreach (var opPendiente in ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Pendiente)).ToList())
            {
                var opPreparacionModelo = new OrdenPreparacion()
                {
                    FechaOrdenRecepcion = opPendiente.FechaOrdenRecepcion,
                    IDOrdenPreparacion = opPendiente.IDOrdenPreparacion,
                    IdCliente = opPendiente.IDOrdenPreparacion,
                    DescripcionCliente = opPendiente.DescripcionCliente,
                    Estado = (EstadoOrden)opPendiente.Estado,
                    Prioridad = (PrioridadOrden)opPendiente.Estado,
                    Productos = new List<Producto>()
                };

                foreach (var prod in opPendiente.Productos)
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
                OrdenesPreparacionPendientes.Add(opPreparacionModelo); // Agrega la orden de selección a la lista 
            }

        }

        public void AltaOrdenSeleccion(OrdenSeleccion ordenAAgregar)
        {
            //convertimos la orden de seleccion que nos da este formulario en la orden de seleccion que necesita el archivo/entidad
            Archivos.OrdenSeleccion nuevaOrdenSeleccionArchivo = new();
            List<string> ordenesPreparacionIds = new();

            nuevaOrdenSeleccionArchivo.IDOrdenSeleccion = ordenAAgregar.IDOrdenSeleccion;
            nuevaOrdenSeleccionArchivo.FechaCreacion    = ordenAAgregar.FechaCreacion;

            foreach(var ordenPreparacion in ordenAAgregar.OrdenesPreparacion)
            {
                ordenesPreparacionIds.Add(ordenPreparacion.IDOrdenPreparacion.ToString());
            }
            nuevaOrdenSeleccionArchivo.IDsOrdenesPreparacion = ordenesPreparacionIds;


            ArchivoOrdenesSeleccion.AgregarOrdenSeleccion(nuevaOrdenSeleccionArchivo);


        }


        public void CambiarEstadoOrdenSeleccionada(string idordenpreparacion)
        {
            //En este metodo actualizamos el estado de una orden de preparación y luego de esto actualizamos las listas de orden de preparacion del archivo
            // y de esta pantalla
            ArchivoOrdenesPreparacion.CambiarEstadoOrdenPreparacion(idordenpreparacion,Archivos.EstadoOrden.Seleccionada);

            OrdenesPreparacionPendientes.Clear();

            foreach (var opPendiente in ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Pendiente)).ToList())
            {
                var opPreparacionModelo = new OrdenPreparacion()
                {
                    FechaOrdenRecepcion = opPendiente.FechaOrdenRecepcion,
                    IDOrdenPreparacion = opPendiente.IDOrdenPreparacion,
                    IdCliente = opPendiente.IDOrdenPreparacion,
                    DescripcionCliente = opPendiente.DescripcionCliente,
                    Estado = (EstadoOrden)opPendiente.Estado,
                    Prioridad = (PrioridadOrden)opPendiente.Estado,
                    Productos = new List<Producto>()
                };

                foreach (var prod in opPendiente.Productos)
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
                OrdenesPreparacionPendientes.Add(opPreparacionModelo); // Agrega la orden de selección a la lista 
            }

        }

        public string obtenerNuevoIDOrdenSeleccion()
        {
            //Con este metodo tomamos la ultima orden disponible y en base a esa generamos un id nuevo para ordenes nuevas

            // Ver si la orden que voy a cargar no es la primera
            if (OrdenesSeleccion.Count > 0)
            {
                // Ordena la lista por IDOrdenSeleccion en orden descendente
                OrdenesSeleccion.Sort((a, b) => b.IDOrdenSeleccion.CompareTo(a.IDOrdenSeleccion));

                // Obtiene el último IDOrdenSeleccion
                // Al estar ordenado de forma descendente, esta en el index [0]
                string ultimoID = OrdenesSeleccion[0].IDOrdenSeleccion;

                // Con el substring agarro los numeros del ID, no me importan las letras
                // Con el int.Parse lo convierto a numero para poder sumarle 1
                int IDNumeros = int.Parse(ultimoID.Substring(3));
                //int IDNumeros = int.Parse(new string(ultimoID.Where(char.IsDigit).ToArray()));

                //input.Where(char.IsDigit)

                //Obtengo el siguiente numero ID
                int NuevoNumero = IDNumeros + 1;

                //Ahora concateno la parte de letras del ID con la parte numerica transformada
                //Substring (0,3) me trae el "AA-" y despues el NumeroNuevo son los "0000"
                
                //dependiendo de cual es el último numero de orden lo pasamos por este condicional para ver cuantos ceros le agregamos a la orden para mantener
                //el formato
                string numeroid = "";

                if (NuevoNumero<=9)
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

                string nuevoID = ultimoID.Substring(0,3) + numeroid;

                // Devuelve el nuevo ID como cadena
                return nuevoID;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor predeterminado (por ejemplo, "1")
                return "OS-0001";
            }
        }
    }

}