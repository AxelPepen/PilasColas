

namespace pilasycolas
{
    public class Pagina
    {
        public string Url { get; set; }
        public string Titulo { get; set; }

        public Pagina(string url, string titulo)
        {
            Url = url;
            Titulo = titulo;
        }

        public override string ToString()
        {
            return $" {Titulo} - {Url}";
        }
    }
}
