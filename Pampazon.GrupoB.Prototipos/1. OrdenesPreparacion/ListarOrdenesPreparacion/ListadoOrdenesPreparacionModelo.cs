using Pampazon.GrupoB.Prototipos;

namespace Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion
{
    public class ListadoOrdenesPreparacionModelo
    {

        public List<OrdenDePreparacion> GenerarEjemplos()
        {
            var ordenes = new List<OrdenDePreparacion>
    {
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP001",
            IdCliente = "C001",
            DescripcionCliente = "Cliente 1",
            FechaOrdenRecepcion = new DateTime(2024, 5, 1),
            EstadoRecepcion = EstadoOrden.Pendiente,
            Prioridad = PrioridadA.Alta
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP002",
            IdCliente = "C002",
            DescripcionCliente = "Cliente 2",
            FechaOrdenRecepcion = new DateTime(2024, 5, 2),
            EstadoRecepcion = EstadoOrden.EnSeleccion,
            Prioridad = PrioridadA.Media
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP003",
            IdCliente = "C003",
            DescripcionCliente = "Cliente 3",
            FechaOrdenRecepcion = new DateTime(2024, 5, 3),
            EstadoRecepcion = EstadoOrden.Seleccionada,
            Prioridad = PrioridadA.Baja
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP004",
            IdCliente = "C004",
            DescripcionCliente = "Cliente 4",
            FechaOrdenRecepcion = new DateTime(2024, 5, 4),
            EstadoRecepcion = EstadoOrden.Preparada,
            Prioridad = PrioridadA.Alta
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP005",
            IdCliente = "C005",
            DescripcionCliente = "Cliente 5",
            FechaOrdenRecepcion = new DateTime(2024, 5, 5),
            EstadoRecepcion = EstadoOrden.Despachada,
            Prioridad = PrioridadA.Media
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP006",
            IdCliente = "C006",
            DescripcionCliente = "Cliente 6",
            FechaOrdenRecepcion = new DateTime(2024, 5, 6),
            EstadoRecepcion = EstadoOrden.Pendiente,
            Prioridad = PrioridadA.Baja
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP007",
            IdCliente = "C007",
            DescripcionCliente = "Cliente 7",
            FechaOrdenRecepcion = new DateTime(2024, 5, 7),
            EstadoRecepcion = EstadoOrden.EnSeleccion,
            Prioridad = PrioridadA.Alta
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP008",
            IdCliente = "C008",
            DescripcionCliente = "Cliente 8",
            FechaOrdenRecepcion = new DateTime(2024, 5, 8),
            EstadoRecepcion = EstadoOrden.Seleccionada,
            Prioridad = PrioridadA.Media
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP009",
            IdCliente = "C009",
            DescripcionCliente = "Cliente 9",
            FechaOrdenRecepcion = new DateTime(2024, 5, 9),
            EstadoRecepcion = EstadoOrden.Preparada,
            Prioridad = PrioridadA.Baja
        },
        new OrdenDePreparacion
        {
            IdOrdenPreparacion = "OP010",
            IdCliente = "C010",
            DescripcionCliente = "Cliente 10",
            FechaOrdenRecepcion = new DateTime(2024, 5, 10),
            EstadoRecepcion = EstadoOrden.Despachada,
            Prioridad = PrioridadA.Alta
        }
    };

            return ordenes;
        }

    }
}
