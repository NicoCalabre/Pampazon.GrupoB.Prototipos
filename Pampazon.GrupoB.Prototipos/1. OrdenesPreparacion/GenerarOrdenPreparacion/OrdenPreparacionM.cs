namespace Pampazon.GrupoB.Prototipos
{
    public class OrdenPreparacionM
    {
        public string IDOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public List<ProductoM> Productos { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public EstadoOrdenM Estado { get; set; }
        public PrioridadM Prioridad { get; set; }
    }
}