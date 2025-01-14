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


    [HttpPost("uploadFile")]
    public void UploadFile(IFormFile formFile)
    {
        formFile.OpenReadStream();
    }


    [HttpPost("addMusic")]
    public Guid PostMusic(MusicDto musicDto)
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

    [HttpDelete("deleteMusic")]
    public void DeleteMusic(Guid id)
    {
        _musicService.DeleteMusic(id);
    }

    [HttpPut("updateMusic")]
    public void PutMusic(MusicDto musicDto)
    {
        _musicService.UpdateMusic(musicDto);
    }

    [HttpGet("getAllMusicByAuthorName")]
    public List<MusicDto> GetAllMusicByAuthorName(string name)
    {
        return _musicService.GetAllMusicByAuthorName(name);
    }

    [HttpGet("getMostLikedMusic")]
    public MusicDto GetMostLikedMusic()
    {
        return _musicService.GetMostLikedMusic();
    }

    [HttpGet("getMusicByName")]
    public MusicDto GetMusicByName(string name)
    {
        return _musicService.GetMusicByName(name);
    }

    [HttpGet("getAllMusicAboveSize")]
    public List<MusicDto> GetAllMusicAboveSize(double minSizeMB)
    {
        return _musicService.GetAllMusicAboveSize(minSizeMB);
    }

    [HttpGet("getAllMusicBelowSize")]
    public List<MusicDto> GetAllMusicBelowSize(double maxSizeMB)
    {
        return _musicService.GetAllMusicBelowSize(maxSizeMB);
    }

    [HttpGet("getTopMostLikedMusic")]
    public List<MusicDto> GetTopMostLikedMusic(int count)
    {
        return _musicService.GetTopMostLikedMusic(count);
    }

    [HttpGet("getLowMostLikedMusic")]
    public List<MusicDto> GetLowMostLikedMusic(int count)
    {
        return _musicService.GetLowMostLikedMusic(count);
    }

    [HttpGet("getMusicByDescriptionKeyword")]
    public List<MusicDto> GetMusicByDescriptionKeyword(string keyword)
    {
        return _musicService.GetMusicByDescriptionKeyword(keyword);
    }

    [HttpGet("getMusicWithLikesInRange")]
    public List<MusicDto> GetMusicWithLikesInRange(int minLikes, int maxLikes)
    {
        return _musicService.GetMusicWithLikesInRange(minLikes, maxLikes);
    }

    [HttpGet("getAllUniqueAuthors")]
    public List<string> GetAllUniqueAuthors()
    {
        return _musicService.GetAllUniqueAuthors();
    }

    [HttpGet("getTotalMusicSizeByAuthor")]
    public double GetTotalMusicSizeByAuthor(string authorName)
    {
        return _musicService.GetTotalMusicSizeByAuthor(authorName);
    }
}
