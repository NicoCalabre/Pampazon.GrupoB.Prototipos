using Pampazon.GrupoB.Prototipos;
using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos
{
    public class CrearOrdenPreparacionModelo
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<Producto> Productos { get; set; }
        public List<Cliente> Clientes { get; set; }
        public CrearOrdenPreparacionModelo()
        {
            OrdenesPreparacion = new List<OrdenPreparacion>((IEnumerable<OrdenPreparacion>)ArchivoOrdenesPreparacion.OrdenesPreparacion);
            Productos = new List<Producto>((IEnumerable<Producto>)ArchivoProductos.Productos);
            Clientes = new List<Cliente>((IEnumerable<Cliente>)ArchivoCliente.Clientes);
        }
    }
}

//// Inicializa la lista de productos
//ProductoM = new List<ProductoM>
//            {
//               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" },
//               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" },
//               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" },
//               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" }
//            };

//// Inicializa la lista de ordenes de preparación
//Ordenes = new List<OrdenPreparacionM>
//            {

//             new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP001",
//                IdCliente = "C001",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P001", DescripcionProducto = "Producto 1", Cantidad = 5, Ubicacion = "A1" },
//                    new ProductoM { IDProducto = "P002", DescripcionProducto = "Producto 2", Cantidad = 2, Ubicacion = "B1" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-1),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Alta
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP002",
//                IdCliente = "C002",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P003", DescripcionProducto = "Producto 3", Cantidad = 1, Ubicacion = "A2" },
//                    new ProductoM { IDProducto = "P004", DescripcionProducto = "Producto 4", Cantidad = 4, Ubicacion = "B2" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-2),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Media
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP003",
//                IdCliente = "C003",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P005", DescripcionProducto = "Producto 5", Cantidad = 3, Ubicacion = "A3" },
//                    new ProductoM { IDProducto = "P006", DescripcionProducto = "Producto 6", Cantidad = 6, Ubicacion = "B3" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-3),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Baja
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP004",
//                IdCliente = "C004",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P007", DescripcionProducto = "Producto 7", Cantidad = 7, Ubicacion = "A4" },
//                    new ProductoM { IDProducto = "P008", DescripcionProducto = "Producto 8", Cantidad = 8, Ubicacion = "B4" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-4),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Alta
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP005",
//                IdCliente = "C005",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P009", DescripcionProducto = "Producto 9", Cantidad = 9, Ubicacion = "A5" },
//                    new ProductoM { IDProducto = "P010", DescripcionProducto = "Producto 10", Cantidad = 10, Ubicacion = "B5" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-5),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Media
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP006",
//                IdCliente = "C006",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P011", DescripcionProducto = "Producto 11", Cantidad = 11, Ubicacion = "A6" },
//                    new ProductoM { IDProducto = "P012", DescripcionProducto = "Producto 12", Cantidad = 12, Ubicacion = "B6" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-6),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Baja
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP007",
//                IdCliente = "C007",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P013", DescripcionProducto = "Producto 13", Cantidad = 13, Ubicacion = "A7" },
//                    new ProductoM { IDProducto = "P014", DescripcionProducto = "Producto 14", Cantidad = 14, Ubicacion = "B7" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-7),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Alta
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP008",
//                IdCliente = "C008",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P015", DescripcionProducto = "Producto 15", Cantidad = 15, Ubicacion = "A8" },
//                    new ProductoM { IDProducto = "P016", DescripcionProducto = "Producto 16", Cantidad = 16, Ubicacion = "B8" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-8),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Media
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP009",
//                IdCliente = "C009",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P017", DescripcionProducto = "Producto 17", Cantidad = 17, Ubicacion = "A9" },
//                    new ProductoM { IDProducto = "P018", DescripcionProducto = "Producto 18", Cantidad = 18, Ubicacion = "B9" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-9),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Baja
//            },
//            new OrdenPreparacionM
//            {
//                IDOrdenPreparacion = "OP010",
//                IdCliente = "C010",
//                Productos = new List<ProductoM>
//                {
//                    new ProductoM { IDProducto = "P019", DescripcionProducto = "Producto 19", Cantidad = 19, Ubicacion = "A10" },
//                    new ProductoM { IDProducto = "P020", DescripcionProducto = "Producto 20", Cantidad = 20, Ubicacion = "B10" }
//                },
//                FechaOrdenRecepcion = DateTime.Now.AddDays(-10),
//                Estado = EstadoOrdenM.Preparada,
//                Prioridad = PrioridadM.Alta
//            }

//            };