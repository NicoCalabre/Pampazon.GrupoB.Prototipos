namespace Pampazon.GrupoB.Prototipos
{
    public class OrdenDeSeleccion
    {
        public string IdOrdenSeleccion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public string IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaOrdenSeleccion { get; set; }
        public EstadoOrden EstadoSeleccion { get; set; }
        public string Prioridad { get; set; }
    }
}