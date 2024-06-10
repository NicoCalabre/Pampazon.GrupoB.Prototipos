using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoEstadoOrden
    {
        public static ReadOnlyCollection<EstadoOrden> EstadosOrdenes => estadosordenes.AsReadOnly();

        private static List<EstadoOrden> estadosordenes;

        static ArchivoEstadoOrden()
        {
            if (File.Exists(@"Datos\estadosordenes.json"))
            {
                var contenido = File.ReadAllText(@"Datos\estadosordenes.json");
                estadosordenes = JsonConvert.DeserializeObject<List<EstadoOrden>>(contenido);
                }
            else
            {
                estadosordenes = new List<EstadoOrden>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(estadosordenes);
            File.WriteAllText(@"Datos\estadosordenes.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarEstadoOrden(EstadoOrden estadoorden)
        {
            estadosordenes.Add(estadoorden);
        }

    }
}
