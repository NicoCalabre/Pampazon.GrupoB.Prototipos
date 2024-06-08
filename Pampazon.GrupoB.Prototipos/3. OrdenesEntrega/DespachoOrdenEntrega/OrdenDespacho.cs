namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    public class OrdenDespacho
    {
        public string IDOrdenDespacho { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
    }
}