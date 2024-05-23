using Pampazon.GrupoB.Prototipos;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
using Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion;

namespace Pampazon.GrupoB.Prototipos.OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class OrdenDeSeleccion
    {
        public string IDOrdenSeleccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
    }
}