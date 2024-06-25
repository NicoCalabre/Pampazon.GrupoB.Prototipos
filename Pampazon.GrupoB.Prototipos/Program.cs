using Pampazon.GrupoB.Prototipos.Archivos;

namespace Pampazon.GrupoB.Prototipos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new CrearOrdenSeleccionForm());
            Application.Run(new PaginaPrincipalForm());
            ArchivoOrdenesSeleccion.GrabarDatos();
            ArchivoOrdenesEntrega.GrabarDatos();
            ArchivoOrdenesDespacho.GrabarDatos();
            ArchivoOrdenesPreparacion.GrabarDatos();
            ArchivoProductos.GrabarDatos();

        }
    }
}