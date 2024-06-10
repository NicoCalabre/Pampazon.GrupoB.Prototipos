using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoOrdenesDespacho
    {
        public static ReadOnlyCollection<OrdenDespacho> OrdenesDespacho => ordenesdespacho.AsReadOnly();

        private static List<OrdenDespacho> ordenesdespacho;

        static ArchivoOrdenesDespacho()
        {
            if (File.Exists(@"Datos\ordenesdespacho.json"))
            {
                var contenido = File.ReadAllText(@"Datos\ordenesdespacho.json");
                ordenesdespacho = JsonConvert.DeserializeObject<List<OrdenDespacho>>(contenido);
                }
            else
            {
                ordenesdespacho = new List<OrdenDespacho>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesdespacho);
            File.WriteAllText(@"Datos\ordenesdespacho.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarOrdenDespacho(OrdenDespacho ordendespacho)
        {
            ordenesdespacho.Add(ordendespacho);
        }

    }
}
