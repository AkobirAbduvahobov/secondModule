using MucisCRUD.Service.DTOs;
using MusicCRUD.DataAccess.Entity;
using MusicCRUD.Repository.Services;

namespace MucisCRUD.Service.Service;

public class MusicService : IMusicService
{
    private readonly IMusicRepository _musicRepository;

    public MusicService()
    {
        _musicRepository = new MusicRepository();
    }

    public Guid AddMusic(MusicDto musicDto)
    {
        var music = ConvertToMusicEntity(musicDto);
        var idRes = _musicRepository.AddMusic(music);
        return idRes;
    }

    public void DeleteMusic(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<MusicDto> GetAllMusic()
    {
        var music = _musicRepository.GetAllMusic();
        var musicDtos = music.Select(mu => ConvertToMusicDto(mu)).ToList(); 
        return musicDtos;
    }

    private Music ConvertToMusicEntity(MusicDto musicDto)
    {
        return new Music()
        {
            Id = musicDto.Id ?? Guid.NewGuid(),
            Name = musicDto.Name,
            MB = musicDto.MB,
            AuthorName = musicDto.AuthorName,
            Description = musicDto.Description,
            QuentityLikes = musicDto.QuentityLikes,
        };
    }

    private MusicDto ConvertToMusicDto(Music music)
    {
        return new MusicDto()
        {
            Id = music.Id,
            Name = music.Name,
            MB = music.MB,
            AuthorName = music.AuthorName,
            Description = music.Description,
            QuentityLikes = music.QuentityLikes,
        };
    }
}
