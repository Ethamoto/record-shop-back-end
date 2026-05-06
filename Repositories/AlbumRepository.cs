using RecordShopBackEnd.Data;
using RecordShopBackEnd.Models;
using static RecordShopBackEnd.Repositories.AlbumRepository;

namespace RecordShopBackEnd.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly AppDbContext _context;

        public AlbumRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Album> GetAllAlbums()
        {
            return _context.Albums.ToList();
        }

        public List<Album> GetAlbumsByArtist(string artist)
        {
            return _context.Albums
                .Where(album => album.Artist == artist)
                .ToList();
        }



        public interface IAlbumRepository
        {
            List<Album> GetAllAlbums();

            List<Album> GetAlbumsByArtist(string artist);
        }
    }
    
}
