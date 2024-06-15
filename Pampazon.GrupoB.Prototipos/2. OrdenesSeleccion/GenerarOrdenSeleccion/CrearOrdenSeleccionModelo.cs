using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion
{
    public class CrearOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }

        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        //public List<Producto> Productos { get; set; }

        //public OrdenSeleccion OrdenSeleccion { get; set; }
        //public PrioridadOrden Prioridad { get; set; }

        public CrearOrdenSeleccionModelo()
        {
            OrdenesSeleccion = new List<OrdenSeleccion>((IEnumerable<OrdenSeleccion>)ArchivoOrdenesSeleccion.OrdenesSeleccion);
            OrdenesPreparacion = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
        }

        public void AltaOrdenSeleccion(Archivos.OrdenSeleccion ordenAAgregar)
        {
            //Agrego la orden al listado de OrdenesSeleccion
            ArchivoOrdenesSeleccion.AgregarOrdenSeleccion(ordenAAgregar);
        }

        public string obtenerNuevoIDOrdenSeleccion()
        {
            // Ver si la orden que voy a cargar no es la primera
            if (OrdenesSeleccion.Count > 0)
            {
                // Ordena la lista por IDOrdenSeleccion en orden descendente
                OrdenesSeleccion.Sort((a, b) => b.IDOrdenSeleccion.CompareTo(a.IDOrdenSeleccion));

                // Obtiene el último IDOrdenSeleccion
                // Al estar ordenado de forma descendente, esta en el index [0]
                string ultimoID = OrdenesSeleccion[0].IDOrdenSeleccion;

                // Con el substring agarro los numeros del ID, no me importan las letras
                // Con el int.Parse lo convierto a numero para poder sumarle 1
                int IDNumeros = int.Parse(ultimoID.Substring(3));

                //Obtengo el siguiente numero ID
                int NuevoNumero = IDNumeros + 1;

                //Ahora concateno la parte de letras del ID con la parte numerica transformada
                //Substring (0,3) me trae el "AA-" y despues el NumeroNuevo son los "0000"
                string nuevoID = ultimoID.Substring(0, 3) + NuevoNumero.ToString();

                // Devuelve el nuevo ID como cadena
                return nuevoID;
            }
            else
            {
                // Si la lista está vacía, devuelve un valor predeterminado (por ejemplo, "1")
                return "OS-0001";
            }
        }
    }
}