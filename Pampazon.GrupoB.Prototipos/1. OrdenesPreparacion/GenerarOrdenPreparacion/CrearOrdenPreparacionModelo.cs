using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos._1._OrdenesPreparacion.GenerarOrdenPreparacion
{

    public class CrearOrdenPreparacionModelo
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        public List<Producto> Productos { get; set; }
        public List<Cliente> Clientes { get; set; }

        public CrearOrdenPreparacionModelo()
        {
            OrdenesPreparacion = new();
            Productos = new();
            Clientes = ArchivoCliente.Clientes.Select(c => new Cliente(c)).ToList();

            foreach (var op in ArchivoOrdenesPreparacion.OrdenesPreparacion)
            {
                var opModelo = new OrdenPreparacion()
                {
                    IDOrdenPreparacion = op.IDOrdenPreparacion,
                    IdCliente = op.IdCliente,
                    DescripcionCliente = Clientes.FirstOrDefault(c => c.IDCliente == op.IdCliente)?.DescripcionCliente,
                    FechaOrdenRecepcion = op.FechaOrdenRecepcion,
                    Estado = (EstadoOrden)op.Estado,
                    Prioridad = (PrioridadOrden)op.Prioridad,
                    Productos = new List<Producto>()
                };

                foreach (var prod in op.Productos)
                {
                    var prodArchivo = ArchivoProductos.Productos.FirstOrDefault(producto => producto.IDProducto == prod.IdProducto.ToString());

                    if (prodArchivo != null) //que el producto exista
                    {
                        var prodModelo = new Producto()
                        {
                            IDProducto = prodArchivo.IDProducto,
                            IdCliente = prodArchivo.IdCliente,
                            Cantidad = prodArchivo.Cantidad,
                            DescripcionProducto = prodArchivo.DescripcionProducto,
                            Ubicaciones = new List<ProductoDetalleStock>() //inicializar la lista
                        };

                        foreach (var ubi in prodArchivo.Ubicaciones)
                        {
                            var ubiModelo = new ProductoDetalleStock()
                            {
                                Ubicacion = ubi.Ubicacion,
                                Cantidad = ubi.Cantidad
                            };
                            prodModelo.Ubicaciones.Add(ubiModelo); // Agrega la ubicación a la lista del producto
                        }

                        opModelo.Productos.Add(prodModelo); // Agrega el producto a la lista de la orden de preparación
                    }
                }

                OrdenesPreparacion.Add(opModelo); // Agrega la orden de preparación a la lista principal
            }
        }

        public List<string> ObtenerIdClientesUnicos()
        {
            return ArchivoProductos.Productos
                .Select(p => p.IdCliente)
                .Distinct()
                .ToList();
        }

        public List<Cliente> ObtenerClientesUnicos()
        {
            return Clientes.Distinct().ToList();
        }

        public void LlenarComboBoxClientes(ComboBox comboBoxClientes)
        {
            // Obtén los IDs únicos de los clientes
            var idClientesUnicos = ObtenerIdClientesUnicos();

            // Asigna la lista de IDs al DataSource del ComboBox
            comboBoxClientes.DataSource = idClientesUnicos;

            // Establece el índice seleccionado a -1 para que no haya nada seleccionado
            comboBoxClientes.SelectedIndex = -1;
        }

        public void AgregarOrden(OrdenPreparacion nuevaOrden)
        {
            // Agrega la nueva orden de preparación a la lista
            OrdenesPreparacion.Add(nuevaOrden);
        }


        public void AltaOrdenPreparacion(OrdenPreparacion ordenAAgregar)
        {
            Archivos.OrdenPreparacion nuevaOrdenPreparacionArchivo = new()
            {
                IDOrdenPreparacion = ordenAAgregar.IDOrdenPreparacion,
                IdCliente = ordenAAgregar.IdCliente,
                DescripcionCliente = ordenAAgregar.DescripcionCliente,
                FechaOrdenRecepcion = ordenAAgregar.FechaOrdenRecepcion,
                Estado = (Archivos.EstadoOrden)ordenAAgregar.Estado,
                Prioridad = (Archivos.PrioridadOrden)ordenAAgregar.Prioridad,
                Productos = new List<Archivos.OrdenDetalle>()
            };

            foreach (var producto in ordenAAgregar.Productos)
            {
                var nuevaOrdenDetalleArchivo = new Archivos.OrdenDetalle
                {
                    IdProducto = producto.IDProducto,
                    Cantidad = producto.Cantidad
                };

                nuevaOrdenPreparacionArchivo.Productos.Add(nuevaOrdenDetalleArchivo);
            }

            // Agregar la nueva orden de preparación al archivo/entidad
            ArchivoOrdenesPreparacion.AgregarOrdenPreparacion(nuevaOrdenPreparacionArchivo);
        }
    }
 }