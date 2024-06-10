using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoPrioridadOrden
    {
        public static ReadOnlyCollection<PrioridadOrden> PrioridadesOrdenes => prioridadesordenes.AsReadOnly();

        private static List<PrioridadOrden> prioridadesordenes;

        static ArchivoPrioridadOrden()
        {
            if (File.Exists(@"Datos\prioridadesordenes.json"))
            {
                var contenido = File.ReadAllText(@"Datos\prioridadesordenes.json");
                prioridadesordenes = JsonConvert.DeserializeObject<List<PrioridadOrden>>(contenido);
                }
            else
            {
                prioridadesordenes = new List<PrioridadOrden>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(prioridadesordenes);
            File.WriteAllText(@"Datos\prioridadesordenes.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarPrioridadOrden(PrioridadOrden prioridadorden)
        {
            prioridadesordenes.Add(prioridadorden);
        }

    }
}
