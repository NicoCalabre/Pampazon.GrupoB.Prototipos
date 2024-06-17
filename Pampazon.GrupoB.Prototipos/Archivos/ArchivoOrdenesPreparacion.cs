using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoOrdenesPreparacion
    {
        public static ReadOnlyCollection<OrdenPreparacion> OrdenesPreparacion => ordenespreparacion.AsReadOnly();

        private static List<OrdenPreparacion> ordenespreparacion;

        static ArchivoOrdenesPreparacion()
        {
            if (File.Exists(@"Datos\ordenespreparacion.json"))
            {
                var contenido = File.ReadAllText(@"Datos\ordenespreparacion.json");
                ordenespreparacion = JsonConvert.DeserializeObject<List<OrdenPreparacion>>(contenido);
                }
            else
            {
                ordenespreparacion = new List<OrdenPreparacion>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenespreparacion);
            File.WriteAllText(@"Datos\ordenespreparacion.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarOrdenPreparacion(OrdenPreparacion ordenpreparacion)
        {
            ordenespreparacion.Add(ordenpreparacion);
        }

        public static void CambiarEstadoOrdenPreparacion(string idordenpreparacion, EstadoOrden estado)
        {
            //Persona persona = listaPersonas.FirstOrDefault(p => p.Nombre == "Ana");
            OrdenPreparacion ordenpreparacionmodificar = ordenespreparacion.FirstOrDefault(orden => orden.IDOrdenPreparacion == idordenpreparacion);

            ordenpreparacionmodificar.Estado = estado;

        }

    }
}
