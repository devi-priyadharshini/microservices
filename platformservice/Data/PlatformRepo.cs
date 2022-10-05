
using System.Collections.Generic;
using platformservice.Model;
using System.Linq;

namespace platformservice.Data
{

    public class PlatformRepo : IPlatformRepo
    {
        readonly AppDbContext _appDbContext;
        public PlatformRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _appDbContext.Platforms;
        }

        public Platform GetPlatformById(int id)
        {
            return _appDbContext.Platforms.SingleOrDefault(p => p.ID == id);
        }

        public bool CreatePlatform(Platform newPlatform)
        {
            if (newPlatform == null)
                return false;

            _appDbContext.Platforms.Add(newPlatform);
            return _appDbContext.SaveChanges() != 0;
        }
    }
}