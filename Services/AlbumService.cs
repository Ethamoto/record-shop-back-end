using RecordShopBackEnd.Models;
using static RecordShopBackEnd.Repositories.AlbumRepository;

namespace RecordShopBackEnd.Services
{
    public class AlbumService: IAlbumService
    {
        private readonly IAlbumRepository _albumRepository; 

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public List<Album> GetAlbums() 
        {  
            return new List<Album>(); 
        
        }
    }

     interface IAlbumService
    {
        List<Album> GetAlbums();

        //List<Album> GetAlbumsByID();

        //void AddAlbum();

        //void UpdateAlbum();

        //void DeleteAlbum();
    }
}
