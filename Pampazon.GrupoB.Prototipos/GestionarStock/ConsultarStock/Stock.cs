namespace Pampazon.GrupoB.Prototipos.GestionarStock.ConsultarStock
{
    public class Stock
    {
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public string IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaStock { get; set; }
        public EstadoOrden Estado { get; set; }
        public string Prioridad { get; set; }

        public int Posicion { get; set; }
        public int EspacioDisponible { get; set; }



    }
}