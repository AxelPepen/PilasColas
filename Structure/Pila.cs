namespace pilasycolas.Structure
{
    public class Pila<T>
    {
        private readonly List<T> elementos = new();

        public void IngresarPila(T elemento)
        {
            elementos.Add(elemento);
        }

        public T SalirPila()
        {
            if (EstaVacia())
                return default!;
            var last = elementos[^1];
            elementos.RemoveAt(elementos.Count - 1);
            return last;
        }

        public T Cima()
        {
            return EstaVacia() ? default! : elementos[^1];
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public void MostrarPila()
        {
            if (EstaVacia())
            {
                Console.WriteLine("El historial está vacío.");
            }
            else
            {
                Console.WriteLine("Historial de navegación:");
                for (int i = elementos.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine("  " + elementos[i]);
                }
            }
        }

        public int Cantidad()
        {
            return elementos.Count;
        }
    }
}
