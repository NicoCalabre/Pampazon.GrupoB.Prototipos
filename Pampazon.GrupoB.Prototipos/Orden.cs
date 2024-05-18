namespace Pampazon.GrupoB.Prototipos
{
    internal class Orden
    {
        public string ID { get; set; }
        public string IdProducto { get; set; }
        public string IdCliente { get; set; }

        public Orden(string id, string idproducto, string idcliente)
        {
            ID = id;
            IdProducto = idproducto;
            IdCliente = idcliente;
        }

        public virtual void MostrarDetalle()
        {
            Console.WriteLine($"Orden ID: {ID}, IdProducto: {IdProducto}, IdCliente: {IdCliente}");
        }


    }
}