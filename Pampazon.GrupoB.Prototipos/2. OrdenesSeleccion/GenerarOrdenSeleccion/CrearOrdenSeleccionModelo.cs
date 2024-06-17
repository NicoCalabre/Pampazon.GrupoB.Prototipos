using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.GenerarOrdenSeleccion
{
    public class CrearOrdenSeleccionModelo
    {
        public List<OrdenSeleccion> OrdenesSeleccion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacionPendientes { get; set; }
        public List<Producto> Productos { get; set; }
        public CrearOrdenSeleccionModelo()
        {
            OrdenesSeleccion             = new List<OrdenSeleccion>((IEnumerable<OrdenSeleccion>)ArchivoOrdenesSeleccion.OrdenesSeleccion);
            OrdenesPreparacion           = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
            OrdenesPreparacionPendientes = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Pendiente)).ToList());
            Productos                    = new List<Producto>((IEnumerable<Producto>)ArchivoProductos.Productos);
        }
        public void AltaOrdenSeleccion(Archivos.OrdenSeleccion ordenAAgregar)
        {
            //Agrego la orden al listado de OrdenesSeleccion
            ArchivoOrdenesSeleccion.AgregarOrdenSeleccion(ordenAAgregar);
            OrdenesSeleccion = new List<OrdenSeleccion>((IEnumerable<OrdenSeleccion>)ArchivoOrdenesSeleccion.OrdenesSeleccion);
        }

        public void CambiarEstadoOrdenSeleccionada(string idordenpreparacion)
        {
            ArchivoOrdenesPreparacion.CambiarEstadoOrdenPreparacion(idordenpreparacion,Archivos.EstadoOrden.Seleccionada);

            OrdenesPreparacion = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
            OrdenesPreparacionPendientes = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion.Where(orden => (orden.Estado == Archivos.EstadoOrden.Pendiente)).ToList());
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
                //int IDNumeros = int.Parse(new string(ultimoID.Where(char.IsDigit).ToArray()));

                //input.Where(char.IsDigit)

                //Obtengo el siguiente numero ID
                int NuevoNumero = IDNumeros + 1;

                //Ahora concateno la parte de letras del ID con la parte numerica transformada
                //Substring (0,3) me trae el "AA-" y despues el NumeroNuevo son los "0000"
                string numeroid = "";

                if (NuevoNumero<=9)
                {
                    numeroid = "000" + NuevoNumero.ToString();

                }
                else if (NuevoNumero > 9 && NuevoNumero <= 99)
                {
                    numeroid = "00" + NuevoNumero.ToString();
                }
                else if (NuevoNumero > 99 && NuevoNumero <= 999)
                {
                    numeroid = "0" + NuevoNumero.ToString();
                }
                else if (NuevoNumero > 999)
                {
                    numeroid = NuevoNumero.ToString();
                }

                string nuevoID = ultimoID.Substring(0,3) + numeroid;

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