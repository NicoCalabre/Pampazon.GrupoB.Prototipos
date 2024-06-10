namespace Pampazon.GrupoB.Prototipos.Archivos

{
    public class OrdenSeleccion
    {
        public string IDOrdenSeleccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
    }
}