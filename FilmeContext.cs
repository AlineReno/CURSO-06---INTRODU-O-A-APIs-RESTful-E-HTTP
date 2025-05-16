
namespace FilmesAPI.Controllers
{
    public class FilmeContext
    {
        public object Filmes { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}