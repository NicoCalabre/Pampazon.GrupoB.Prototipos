//using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
//using Pampazon.GrupoB.Prototipos.Archivos;


//namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion
//{
//    public class ConsultarListaOrdenesSeleccionModelo
//    {
//        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
//        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
//        public List<Producto> Productos { get; set; }
//        public ConsultarListaOrdenesSeleccionModelo()
//        {
//            //En todo el desarrollo del formulario necesitamos tomar datos. Los mismos los sacamos de estas listas de aquí. Lo que hacemos es ir a buscar
//            //datos a los archivos y los guardamos en estas listas para manipularlo desde el formulario. Siempre que hagamos una modificación, agreguemos
//            //o borremos algún elemento de la lista hay que actualizar tanto el archivo como las listas del modelo. 
//            //OrdenesSeleccion = new List<OrdenSeleccion>((IEnumerable<OrdenSeleccion>)ArchivoOrdenesSeleccion.OrdenesSeleccion);
//            //OrdenesPreparacion = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
//            //Productos = new List<Producto>((IEnumerable<Producto>)ArchivoProductos.Productos);

//            OrdenesSeleccion = new();

//            foreach (var os in ArchivoOrdenesSeleccion.OrdenesSeleccion)
//            {
//                var osModelo = new OrdenSeleccion()
//                {
//                    FechaCreacion = os.FechaCreacion,
//                    IDOrdenSeleccion = os.IDOrdenSeleccion
//                };

//                List<OrdenPreparacion> ordenespreparacion = new();

//                foreach(var op in os.IDsOrdenesPreparacion)
//                {
//                    var opArchivo = ArchivoOrdenesPreparacion.OrdenesPreparacion.FirstOrDefault(orden => orden.IDOrdenPreparacion == op.ToString());

//                    var opModelo = new OrdenPreparacion()
//                    {
//                        IDOrdenPreparacion = opArchivo.IDOrdenPreparacion,
//                        IdCliente = opArchivo.IdCliente,
//                        DescripcionCliente = opArchivo.DescripcionCliente,
//                        FechaOrdenRecepcion = opArchivo.FechaOrdenRecepcion,
//                        Estado = (EstadoOrden)opArchivo.Estado,
//                        Prioridad = (PrioridadOrden)opArchivo.Prioridad
//                    };

//                    foreach (var prod in opArchivo.Productos)
//                    {
//                        //idproducto , cantidad
//                        var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

//                        var pordModelo = new Producto()
//                        {
//                            IDProducto = prodArchivo.IDProducto,
//                            IdCliente = prodArchivo.IdCliente,
//                            Cantidad = prodArchivo.Cantidad,
//                            DescripcionProducto = prodArchivo.DescripcionProducto
//                        };

//                        foreach(var ubi in prodArchivo.Ubicaciones)
//                        {
//                            //var ubiArchivo = prodArchivo.Ubicaciones[0].Ubicacion
//                            var ubiModelo = new ProductoDetalleStock()
//                            {
//                                Ubicacion = ubi.Ubicacion,
//                                Cantidad = ubi.Cantidad
//                            };
//                        }
//                    }
//                    ordenespreparacion.Add(opModelo);
//                }

//                osModelo.OrdenesPreparacion = ordenespreparacion;
//                OrdenesSeleccion.Add(osModelo);
//            }
//        }
//    }
//}

//// public List<OrdenDetalle> Productos { get; set; }
///*
// *     public class OrdenPreparacion
//    {
//        public string IDOrdenPreparacion { get; set; }
//        public string IdCliente { get; set; }
//        public string DescripcionCliente { get; set; }
//        public List<Producto> Productos { get; set; }
//        public DateTime FechaOrdenRecepcion { get; set; }
//        public EstadoOrden Estado { get; set; }
//        public PrioridadOrden Prioridad { get; set; }
//    }*/

///*    public class Producto
//    {
//        public string IDProducto { get; set; }
//        public string IdCliente { get; set; }
//        public string DescripcionProducto { get; set; }
//        public int Cantidad { get; set; }
//        //public string Ubicacion { get; set; }
//        public List<ProductoDetalleStock> Ubicaciones { get; set; }

//    }*/

using Pampazon.GrupoB.Prototipos.Archivos;

///*
///*    public class Producto
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

                OrdenesSeleccion.Add(osModelo); // Agrega la orden de selección a la lista principal
            }
        }
    }
}