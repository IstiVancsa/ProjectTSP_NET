using Repository.Interfaces;

namespace Repository.Repositories
{
    public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository()
        {

        }
    }
}
