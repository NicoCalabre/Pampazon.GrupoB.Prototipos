using Pampazon.GrupoB.Prototipos.OrdenesEntrega.CrearOrdenEntrega;
using Pampazon.GrupoB.Prototipos._2._OrdenesSeleccion.ListarOrdenesSeleccion;


namespace Pampazon.GrupoB.Prototipos
{
    public class CrearOrdenEntregaModelo
    {

        // Propiedad para almacenar las órdenes de preparación
        public List<OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<OrdenEntrega> ordenesEntrega { get; set; }
        public CrearOrdenEntregaModelo()
        {
            // Inicializa la lista de órdenes de entrega
            ordenesEntrega = new List<OrdenEntrega>();

            // Inicializa la lista de órdenes de preparación
            OrdenesPreparacion = new List<OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion>
            {
                // Orden 1
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1234",
                    IdCliente = "CC-1118",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        //Ingresar producto 1 en la orden de preparacion
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0000",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 10,
                            Ubicacion = "x,y,z"
                        },
                        //Ingresar producto 2 en la orden de preparacion
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0001",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        }

                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Pendiente,
                    Prioridad = Prioridad.Alta
                },
                // Orden 2
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1111",
                    IdCliente = "CC-5900",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0002",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        }
                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada,
                    Prioridad = Prioridad.Alta
                },
                // Orden 3
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-1235",
                    IdCliente = "CC-5678",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0031",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        },
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0002",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 5,
                            Ubicacion = "x,y,z"
                        }
                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada,
                    Prioridad = Prioridad.Alta
                },
                // Orden 5
                new OrdenesEntrega.CrearOrdenEntrega.OrdenPreparacion
                {
                    IDOrdenPreparacion = "OP-2222",
                    IdCliente = "CC-1111",
                    DescripcionCliente = "Cliente A",
                    Productos = new List<OrdenesEntrega.CrearOrdenEntrega.Producto>
                    {
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0001",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 20,
                            Ubicacion = "x,y,z"
                        },
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0002",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 15,
                            Ubicacion = "x,y,z"
                        },
                        new OrdenesEntrega.CrearOrdenEntrega.Producto
                        {
                            IDProducto = "PP-0003",
                            DescripcionProducto = "Producto testing",
                            Cantidad = 10,
                            Ubicacion = "x,y,z"
                        }
                    },
                    FechaOrdenRecepcion = DateTime.Parse("2024-05-24 10:00 AM"),
                    Estado = OrdenesEntrega.CrearOrdenEntrega.EstadoOrden.Seleccionada,
                    Prioridad = Prioridad.Alta
                },
            };
        }

        internal string AltaOrdenEntrega(OrdenEntrega ordenAAgregar)
        {
            //Obtengo de forma automatica un nuevo IDOrdenEntrega
            //Esto debiera validarse en el modelo o donde?
            string IDorden = obtenerNuevoIDOrdenEntrega();
                            //Obtengo la fecha de hoy
            DateTime FechaOrden = DateTime.Now;

            //Agrego la orden al listado de ordenesEntrega
            ordenesEntrega.Add(ordenAAgregar);

            return null;
        }

        private string obtenerNuevoIDOrdenEntrega()
        {
            // Ver si la orden que voy a cargar no es la primera
            if (ordenesEntrega.Count > 0)
            {
                // Ordena la lista por IDOrdenEntrega en orden descendente
                ordenesEntrega.Sort((a, b) => b.IDOrdenEntrega.CompareTo(a.IDOrdenEntrega));

                // Obtiene el último IDOrdenEntrega
                // Al estar ordenado de forma descendente, esta en el index [0]
                string ultimoID = ordenesEntrega[0].IDOrdenEntrega;

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
                return "OE-0001";
            }
        }
    }
    
}