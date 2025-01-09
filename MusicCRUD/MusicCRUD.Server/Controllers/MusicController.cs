using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MucisCRUD.Service.DTOs;
using MucisCRUD.Service.Service;

namespace MusicCRUD.Server.Controllers;

[Route("api/music")]
[ApiController]
public class MusicController : ControllerBase
{
    private readonly IMusicService _musicService;

    public MusicController()
    {
        _musicService = new MusicService();
    }

    [HttpPost("addMusic")]
    public Guid AddMusic(MusicDto musicDto)
    {
        var id = _musicService.AddMusic(musicDto);
        return id;
    }

    [HttpGet("getAllMusic")]
    public List<MusicDto> GetAllMusic()
    {
        var music = _musicService.GetAllMusic();
        return music;
    }
}
