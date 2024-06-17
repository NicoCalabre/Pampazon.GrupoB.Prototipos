using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
using Pampazon.GrupoB.Prototipos.Archivos;


namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class ConsultarListaOrdenesSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        //public List<OrdenDetalle> OrdenesDetalles { get; set; }
        public List<Producto> Productos { get; set; }
        //public List<ProductoDetalleStock> ProductosDetallesStock { get; set; }
        public ConsultarListaOrdenesSeleccionModelo()
        {
            OrdenesSeleccion = new List<OrdenSeleccion>((IEnumerable<OrdenSeleccion>)ArchivoOrdenesSeleccion.OrdenesSeleccion);
            OrdenesPreparacion = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
            Productos = new List<Producto>((IEnumerable<Producto>)ArchivoProductos.Productos);
            //OrdenesDetalles = new List<OrdenDetalle>((IEnumerable<OrdenDetalle>)ArchivoOrdenesDetalles.OrdenesDetalles);
            //Productos = new List<Producto>((IEnumerable<Producto>)ArchivoProductos.Productos);
            //ProductosDetallesStock = new List<ProductoDetalleStock>((IEnumerable<ProductoDetalleStock>)ArchivoProductosDetallesStock.ProductosDetallesStock);

        }
    }
}