namespace pilasycolas
{
    public class COla<T>
    {
        private readonly LinkedList<T> elementos = new();

        public void IngresarCola(T elemento)
        {
            elementos.AddLast(elemento);
        }

        public T SalirCola()
        {
            if (EstaVacia())
                return default!;
            var first = elementos.First.Value;
            elementos.RemoveFirst();
            return first;
        }

        public T Frente()
        {
            return EstaVacia() ? default! : elementos.First.Value;
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public void MostrarCola()
        {
            if (EstaVacia())
            {
                Console.WriteLine("No hay clientes esperando.");
            }
            else
            {
                Console.WriteLine("Clientes en espera:");
                foreach (var elemento in elementos)
                {
                    Console.WriteLine("  " + elemento);
                }
            }
        }

        public int Cantidad()
        {
            return elementos.Count;
        }
    }
}
