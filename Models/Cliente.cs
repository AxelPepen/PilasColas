
namespace pilasycolas
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Cliente(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Nombre} (ID: {Id})";
        }
    }
}
