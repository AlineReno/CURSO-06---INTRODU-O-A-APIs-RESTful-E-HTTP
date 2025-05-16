namespace FilmesAPI.Controllers
{
    public class Filme
    {
        public int Id { get; internal set; }
        public object Titulo { get; internal set; }
        public object Genero { get; internal set; }
        public object Duracao { get; internal set; }
        public object Diretor { get; internal set; }
    }
}