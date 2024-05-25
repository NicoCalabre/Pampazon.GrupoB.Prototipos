namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    internal class OrdenDespacho
    {
        public string IDOrdenDespacho { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenEntrega> OrdenesEntrega { get; set; }
    }
}