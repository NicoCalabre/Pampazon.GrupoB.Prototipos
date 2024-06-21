using Pampazon.GrupoB.Prototipos;
using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion
{
    public class ListadoOrdenesPreparacionModelo
    {

        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<Producto> Productos { get; set; }

        public ListadoOrdenesPreparacionModelo()
        {
            OrdenesPreparacion = new();
            Productos = new();

            foreach (var op in ArchivoOrdenesPreparacion.OrdenesPreparacion)
            {
                var opModelo = new OrdenPreparacion()
                {
                    IDOrdenPreparacion = op.IDOrdenPreparacion,
                    IdCliente = op.IdCliente,
                    DescripcionCliente = op.DescripcionCliente,
                    FechaOrdenRecepcion = op.FechaOrdenRecepcion,
                    Estado = (EstadoOrden)op.Estado,
                    Prioridad = (PrioridadOrden)op.Prioridad,
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

                OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista principal
            }

        }
    }
}
