﻿namespace Pampazon.GrupoB.Prototipos._1._OrdenesPreparacion.GenerarOrdenPreparacion
{
    public class OrdenPreparacion
    {
        public string IDOrdenPreparacion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public List<Producto> Productos { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public EstadoOrden Estado { get; set; }
        public PrioridadOrden Prioridad { get; set; }
    }
}