using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoOrdenesEntrega
    {
        public static ReadOnlyCollection<OrdenEntrega> OrdenesEntrega => ordenesentrega.AsReadOnly();

        private static List<OrdenEntrega> ordenesentrega;

        static ArchivoOrdenesEntrega()
        {
            if (File.Exists(@"Datos\ordenesentrega.json"))
            {
                var contenido = File.ReadAllText(@"Datos\ordenesentrega.json");
                ordenesentrega = JsonConvert.DeserializeObject<List<OrdenEntrega>>(contenido);
                }
            else
            {
                ordenesentrega = new List<OrdenEntrega>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesentrega);
            File.WriteAllText(@"Datos\ordenesentrega.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarOrdenEntrega(OrdenEntrega ordenentrega)
        {
            ordenesentrega.Add(ordenentrega);
        }

    }
}
