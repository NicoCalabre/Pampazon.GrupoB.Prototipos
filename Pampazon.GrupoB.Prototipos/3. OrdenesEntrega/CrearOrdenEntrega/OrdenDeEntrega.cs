namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.CrearOrdenEntrega
{
    public class OrdenEntrega
    {
        public string IDOrdenEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }

        //public static string DetalleOrdenEntrega(OrdenEntrega ordenEntregaDetallar)
        //{
        //    string ordenesPreparacionIds = null;
            
        //    foreach (var ordenPreparacion in ordenEntregaDetallar.OrdenesPreparacion)
        //    {
        //        ordenesPreparacionIds = ordenesPreparacionIds + " , " + ordenPreparacion.IDOrdenPreparacion;
        //    }
            
        //    return ordenEntregaDetallar.IDOrdenEntrega + " ; " + ordenEntregaDetallar.FechaCreacion + " ; " + ordenesPreparacionIds;
        //}


    }


}