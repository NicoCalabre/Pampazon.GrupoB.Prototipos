using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class ConsultarListaOrdenesSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<Producto> Productos { get; set; }

        public ConsultarListaOrdenesSeleccionModelo()
        {
            OrdenesSeleccion = new();
            OrdenesPreparacion = new();
            Productos = new();

            foreach (var os in ArchivoOrdenesSeleccion.OrdenesSeleccion)
            {
                var osModelo = new OrdenSeleccion()
                {
                    FechaCreacion = os.FechaCreacion,
                    IDOrdenSeleccion = os.IDOrdenSeleccion,
                    OrdenesPreparacion = new List<OrdenPreparacion>() 
                };

                foreach (var op in os.IDsOrdenesPreparacion)
                {
                    var opArchivo = ArchivoOrdenesPreparacion.OrdenesPreparacion.FirstOrDefault(orden => orden.IDOrdenPreparacion == op.ToString());

                    if (opArchivo != null) 
                    {
                        var opModelo = new OrdenPreparacion()
                        {
                            IDOrdenPreparacion = opArchivo.IDOrdenPreparacion,
                            IdCliente = opArchivo.IdCliente,
                            DescripcionCliente = opArchivo.DescripcionCliente,
                            FechaOrdenRecepcion = opArchivo.FechaOrdenRecepcion,
                            Estado = (EstadoOrden)opArchivo.Estado,
                            Prioridad = (PrioridadOrden)opArchivo.Prioridad,
                            Productos = new List<Producto>() 
                        };

                        foreach (var prod in opArchivo.Productos)
                        {
                            var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());
                            


                            if (prodArchivo != null) 
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
                                        CantidadDisponible = ubi.Cantidad
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
        }
    }
}