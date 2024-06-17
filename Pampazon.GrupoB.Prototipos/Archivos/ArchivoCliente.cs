using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoCliente
    {
        public static ReadOnlyCollection<Cliente> Clientes => clientes.AsReadOnly();

        private static List<Cliente> clientes;

        static ArchivoCliente()
        {
            if (File.Exists(@"Datos\clientes.json"))
            {
                var contenido = File.ReadAllText(@"Datos\clientes.json");
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(contenido);
                }
            else
            {
                clientes = new List<Cliente>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(clientes);
            File.WriteAllText(@"Datos\clientes.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

    }
}
