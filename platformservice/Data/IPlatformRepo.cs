using System.Collections.Generic;
using platformservice.Model;
using System.Linq;

namespace platformservice.Data
{

    public interface IPlatformRepo
    {
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        bool CreatePlatform(Platform newPlatform);
    }
}