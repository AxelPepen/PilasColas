namespace pilasycolas
{
    public class GestorCola
    {
        private readonly COla<Cliente> colaClientes = new();
        private Cliente clienteActual;

        public void AgregarCliente(int id, string nombre)
        {
            var cliente = new Cliente(id, nombre);
            colaClientes.IngresarCola(cliente);
            Console.WriteLine("Cliente agregado: " + cliente);
        }

        public void AtenderSiguienteCliente()
        {
            if (!colaClientes.EstaVacia())
            {
                clienteActual = colaClientes.SalirCola();
                Console.WriteLine("Atendiendo al cliente: " + clienteActual);
            }
            else
            {
                clienteActual = null;
                Console.WriteLine("No hay clientes para atender.");
            }
        }

        public void MostrarClienteActual()
        {
            if (clienteActual != null)
            {
                Console.WriteLine("Cliente en atención: " + clienteActual);
            }
            else
            {
                Console.WriteLine("No se está atendiendo a ningún cliente.");
            }
        }

        public void MostrarColaClientes()
        {
            colaClientes.MostrarCola();
        }
    }
}
