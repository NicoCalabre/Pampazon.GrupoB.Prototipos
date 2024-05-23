using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos
{
    internal class OBJETOS_REFERENCIA
    {
    /*
        Orden de Preparacion

        public class OrdenDePreparacion
        {
            public string IDOrdenPreparacion { get; set; }
            public string IdCliente { get; set; }
            public string DescripcionCliente { get; set; }
            public List<Producto> Productos { get; set; }
            public DateTime FechaOrdenRecepcion { get; set; }
            public EstadoRecepcion Estado { get; set; }
            public Prioridad Prioridad { get; set; }
        }

        public class Producto
        {
            public string IDProducto { get; set; }
            public string DescripcionProducto { get; set; }
            public int Cantidad { get; set; }
            public string Ubicacion { get; set; }
        }

        public enum Prioridad
        {
            Baja,
            Media,
            Alta
        }

        public enum EstadoOrden
        {
            Pendiente,
            EnSeleccion,
            Seleccionada,
            Preparada,
            Despachada
        }

        Crear una ordenPreparacion

        var orden = new OrdenPreparacion
                {
                    IDOrdenPreparacion = 1,
                    IdCliente = 123,
                    DescripcionCliente = "Cliente ABC",
                    Productos = new List<Producto>
                    {
                        new Producto { IDProducto = 101, DescripcionProducto = "Producto A", Cantidad = 5, Ubicacion = "Almacén 1" },
                        new Producto { IDProducto = 102, DescripcionProducto = "Producto B", Cantidad = 3, Ubicacion = "Almacén 2" }
                    },
                    FechaOrdenRecepcion = DateTime.Now,
                    Estado = EstadoRecepcion.EnSeleccion,
                    Prioridad = Prioridad.Media
                };

        Orden de Seleccion --> Aca solo les paso los productos que necesito y las coordenadas donde estan
				            --> Las ordenes de preparacion que entran a la orden de seleccion tienen que actualizar su estado a EnSeleccion
				            --> no veo necesario tener IdCliente, DescripcionCliente, EstadoOrden y Prioridad en la OrdenDeSeleccion

        public class OrdenDeSeleccion
        {
            public string IDOrdenSeleccion { get; set; }
            public DateTime FechaCreacion { get; set; }
            public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        }

        ##Aca tendria que actualizar el estado de las ordenes de preparacion que estan en la seleccion

        Orden de Entrega --> Aca les paso las ordenes de preparacion que estan preparadas para ser entregadas

        public class OrdenDeEntrega
        {
            public string IDOrdenEntrega { get; set; }
            public DateTime FechaCreacion { get; set; }
            public List<OrdenPreparacion> OrdenesPreparacion { get; set; }
        }
        */
    }
}
