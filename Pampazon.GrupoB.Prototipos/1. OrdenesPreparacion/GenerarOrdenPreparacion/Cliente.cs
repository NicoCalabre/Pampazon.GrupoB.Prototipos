using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pampazon.GrupoB.Prototipos._1._OrdenesPreparacion.GenerarOrdenPreparacion
{
    public class Cliente
    {
        public string IDCliente { get; set; } 
        public string DescripcionCliente {  get; set; }

        public Cliente(Pampazon.GrupoB.Prototipos.Archivos.Cliente archivoCliente)
        {
            IDCliente = archivoCliente.IDCliente;
            DescripcionCliente = archivoCliente.DescripcionCliente;
        }

    }
}
