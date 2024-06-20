namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion
{
    public class Producto
    {
        public string IDProducto { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        //public string Ubicacion { get; set; }
        public List<ProductoDetalleStock> Ubicaciones { get; set; }

    }
}