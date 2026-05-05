using RecordShopBackEnd.Models;

namespace RecordShopBackEnd.Services
{
    public class AlbumService: IAlbumService
    {
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
