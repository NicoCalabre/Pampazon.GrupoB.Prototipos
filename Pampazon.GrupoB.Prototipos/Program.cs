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
            //Application.Run(new ConsultarListaOrdenesSeleccionForm());
            Application.Run(new PaginaPrincipalForm());

            ArchivoEstadoOrden.GrabarDatos();
            ArchivoOrdenesEntrega.GrabarDatos();
            ArchivoOrdenesDespacho.GrabarDatos();
            ArchivoOrdenesPreparacion.GrabarDatos();
            ArchivoOrdenesSeleccion.GrabarDatos();
            ArchivoPrioridadOrden.GrabarDatos();
            ArchivoProductos.GrabarDatos();
        }
    }
}