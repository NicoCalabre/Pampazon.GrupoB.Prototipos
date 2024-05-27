namespace Pampazon.GrupoB.Prototipos
{
    public class CrearOrdenPreparacionModelo
    {

        // Propiedad para almacenar las órdenes de preparación
        public List<ProductoM> ProductoM { get; set; }
        public CrearOrdenPreparacionModelo()
        {
            // Inicializa la lista de órdenes de preparación
            ProductoM = new List<ProductoM>
            {
               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" },
               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" },
               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" },
               new ProductoM{ IDProducto = "PP-0002", DescripcionProducto = "Producto testing", Cantidad = 5, Ubicacion = "x,y,z" }
            };
        }
    }
}