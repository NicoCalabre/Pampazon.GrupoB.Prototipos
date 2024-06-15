namespace Pampazon.GrupoB.Prototipos.Archivos

{
    public class OrdenEntrega
    {
        public string IDOrdenEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }
        //public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<string> IDsOrdenesPreparacion{ get; set; }

    }


}