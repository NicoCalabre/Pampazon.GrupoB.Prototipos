namespace Pampazon.GrupoB.Prototipos
{
    public class OrdenDeEntrega
    {
        public string IdOrdenEntrega { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public string IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaOrdenEntrega{ get; set; }
        public EstadoOrden EstadoEntrega { get; set; }
        public string Prioridad { get; set; }

    }
}