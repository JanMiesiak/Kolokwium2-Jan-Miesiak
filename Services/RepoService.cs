using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.Models;

namespace Kolokwium2.Services
{
    public class RepoService : IRepoService
    {
        private readonly RepositoryContext _repository;

        public RepoService(RepositoryContext repository)
        {
            _repository = repository;
        }
        public IQueryable<Musician> GetMusicianById(int id)
        {
            return _repository.Musician.Where(e => e.IdMusician == id);
        }
        public List<Track> GetTracks()
        {
            return new List<Track>();
        }
        // public IQueryable<Track> GetAllTracksByMusicianName(string musicianName)
        // {
        //     return _repository.Track
        //         .Include(e => e.Musician)
        //         .Where(e => e.Klient.Nazwisko == clientName)
        //         .Include(e => e.ZamowieniaWyrobCukierniczy)
        //         .ThenInclude(e => e.WyrobCukierniczy);
        // }

    }
}