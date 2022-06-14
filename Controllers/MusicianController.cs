using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Kolokwium2.Models;
using Kolokwium2.Services;
using Kolokwium2.DTOs;

namespace Kolokwium2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class  MusicianController : Controller
    {
        private readonly IRepoService _service;

        public MusicianController(IRepoService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            return Ok
            (
                await _service.GetMusicianById(id)
                .Select(e =>
                    new MusicianGet
                    {
                        IdMusician = e.IdMusician,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        NickName = e.NickName ,
                    
                    // Tracks = e.Musician_Track.Select(e => new Tracks
                    // {
                    //     IdTrack = e.IdTrack,
                    //     Nazwa = e.TrackName,
                    //     Duration = e.Duration

                    // }).ToList()
                }).ToListAsync()
            );

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();


        }
    }

}