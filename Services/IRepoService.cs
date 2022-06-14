using Kolokwium2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public interface IRepoService
    {
        IQueryable<Musician> GetMusicianById(int id);
        List <Track> GetTracks();
        //IQueryable<Track> GetAllTracksByMusicianName(string musicianName);

    }
}