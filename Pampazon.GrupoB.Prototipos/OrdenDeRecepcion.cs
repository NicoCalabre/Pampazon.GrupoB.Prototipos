using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos
{
    public class OrdenDeRecepcion
    {
        public string IdOrdenRecepcion { get; set; }
        public string IdCliente { get; set; }
        public string DescripcionCliente { get; set; }
        public string IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaOrdenRecepcion { get; set; }
        public EstadoOrden EstadoRecepcion { get; set; }
        public string Prioridad { get; set; }
    }
}
