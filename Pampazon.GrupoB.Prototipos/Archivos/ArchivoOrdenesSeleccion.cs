using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoOrdenesSeleccion
    {
        public static ReadOnlyCollection<OrdenSeleccion> OrdenesSeleccion => ordenesseleccion.AsReadOnly();

        public static List<OrdenSeleccion> ordenesseleccion;

        static ArchivoOrdenesSeleccion()
        {
            if (File.Exists(@"Datos\ordenesseleccion.json"))
            {
                var contenido = File.ReadAllText(@"Datos\ordenesseleccion.json");
                ordenesseleccion = JsonConvert.DeserializeObject<List<OrdenSeleccion>>(contenido);
            }
            else
            {
                ordenesseleccion = new List<OrdenSeleccion>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesseleccion);
            File.WriteAllText(@"Datos\ordenesseleccion.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarOrdenSeleccion(OrdenSeleccion ordenseleccion)
        {
            ordenesseleccion.Add(ordenseleccion);
        }

    }
}
