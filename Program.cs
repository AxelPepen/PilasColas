
namespace pilasycolas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1. Simular Historial de Navegador");
                Console.WriteLine("2. Simular Cola de Bancos");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = -1;

                switch (opcion)
                {
                    case 1:
                        Menu.MenuNavegador();
                        break;
                    case 2:
                        Menu.MenuBanco();
                        break;
                    case 0:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}