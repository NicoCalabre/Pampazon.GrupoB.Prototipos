namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public class OrdenDespacho
    {
        public string IDOrdenDespacho { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
    }
}