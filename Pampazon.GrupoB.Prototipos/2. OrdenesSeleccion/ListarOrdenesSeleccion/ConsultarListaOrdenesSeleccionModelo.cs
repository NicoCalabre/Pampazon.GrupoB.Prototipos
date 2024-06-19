using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;
using Pampazon.GrupoB.Prototipos.Archivos;


namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion
{
    public class ConsultarListaOrdenesSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<Producto> Productos { get; set; }
        public ConsultarListaOrdenesSeleccionModelo()
        {
            //En todo el desarrollo del formulario necesitamos tomar datos. Los mismos los sacamos de estas listas de aquí. Lo que hacemos es ir a buscar
            //datos a los archivos y los guardamos en estas listas para manipularlo desde el formulario. Siempre que hagamos una modificación, agreguemos
            //o borremos algún elemento de la lista hay que actualizar tanto el archivo como las listas del modelo. 
            OrdenesSeleccion = new List<OrdenSeleccion>((IEnumerable<OrdenSeleccion>)ArchivoOrdenesSeleccion.OrdenesSeleccion);
            OrdenesPreparacion = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
            Productos = new List<Producto>((IEnumerable<Producto>)ArchivoProductos.Productos);
        }
    }
}