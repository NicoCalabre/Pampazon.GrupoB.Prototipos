using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos.Archivos
{
    public static class ArchivoProductos
    {
        public static ReadOnlyCollection<Producto> Productos => productos.AsReadOnly();

        private static List<Producto> productos;

        static ArchivoProductos()
        {
            if (File.Exists(@"Datos\productos.json"))
            {
                var contenido = File.ReadAllText(@"Datos\productos.json");
                productos = JsonConvert.DeserializeObject<List<Producto>>(contenido);
                }
            else
            {
                productos = new List<Producto>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(productos);
            File.WriteAllText(@"Datos\productos.json", contenido);
        }

        //TODAS LAS OPERACIONES QUE MODIFIQUEN UNA PERSONA

        public static void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

    }
}
