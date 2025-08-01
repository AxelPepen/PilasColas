namespace pilasycolas
{
    public static class Menu
    {
        private static readonly GestorHistorial navegador = new();

        public static void MenuNavegador()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n=== SIMULADOR DE HISTORIAL DE NAVEGADOR ===");
                Console.WriteLine("1. Visitar nueva pagina");
                Console.WriteLine("2. Regresar a la página anterior");
                Console.WriteLine("3. Ver historial de navegación");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la URL: ");
                        string url = Console.ReadLine();
                        Console.Write("Ingrese el título de la página: ");
                        string titulo = Console.ReadLine();
                        navegador.VisitarPagina(url, titulo);
                        break;
                    case 2:
                        navegador.RegresarPagina();
                        break;
                    case 3:
                        navegador.MostrarHistorial();
                        break;
                    case 0:
                        Console.WriteLine("Regresando al menú principal...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 0);
        }

        public static void MenuBanco()
        {
            var banco = new GestorCola();
            int opcion, id = 1;
            do
            {
                Console.WriteLine("\n=== SIMULADOR DE BANCO ===");
                Console.WriteLine("1. Agregar cliente a la cola");
                Console.WriteLine("2. Atender al siguiente cliente");
                Console.WriteLine("3. Ver cliente en atención");
                Console.WriteLine("4. Ver clientes en espera");
                Console.WriteLine("0. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del cliente: ");
                        string nombre = Console.ReadLine();
                        banco.AgregarCliente(id++, nombre);
                        break;
                    case 2:
                        banco.AtenderSiguienteCliente();
                        break;
                    case 3:
                        banco.MostrarClienteActual();
                        break;
                    case 4:
                        banco.MostrarColaClientes();
                        break;
                    case 0:
                        Console.WriteLine("Regresando al menú principal...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
