using pilasycolas.Structure;

namespace pilasycolas
{
    public class GestorHistorial
    {
        private readonly Pila<Pagina> historial = new();

        public void VisitarPagina(string url, string titulo)
        {
            var pagina = new Pagina(url, titulo);
            historial.IngresarPila(pagina);
            Console.WriteLine("Has visitado: " + pagina);
        }

        public void RegresarPagina()
        {
            var paginaAnterior = historial.SalirPila();
            if (paginaAnterior != null)
            {
                Console.WriteLine("Regresaste a la página anterior.");
                if (historial.Cima() != null)
                {
                    Console.WriteLine("Ahora estás en: " + historial.Cima());
                }
                else
                {
                    Console.WriteLine("El historial está vacío.");
                }
            }
            else
            {
                Console.WriteLine("No hay páginas anteriores en el historial.");
            }
        }

        public void MostrarHistorial()
        {
            historial.MostrarPila();
        }
    }
}