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
        _musicRepository.DeleteMusic(id);
    }

    public List<MusicDto> GetAllMusic()
    {
        var music = _musicRepository.GetAllMusic();
        var musicDtos = music.Select(mu => ConvertToMusicDto(mu)).ToList();
        return musicDtos;
    }

    public void UpdateMusic(MusicDto musicDto)
    {
        var music = ConvertToMusicEntity(musicDto);
        _musicRepository.UpdateMusic(music);
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

    public List<MusicDto> GetAllMusicByAuthorName(string name)
    {
        var music = GetAllMusic();
        var resMusic = music.Where(mu => mu.AuthorName.ToLower() == name.ToLower()).ToList();

        return resMusic;
    }

    public MusicDto GetMostLikedMusic()
    {
        var music = GetAllMusic();
        var amountLikes = music.Max(mu => mu.QuentityLikes);
        var mostLikedMusic = music.FirstOrDefault(mu => mu.QuentityLikes == amountLikes);

        if (mostLikedMusic == null)
        {
            throw new NullReferenceException("Storage is empty");
        }

        return mostLikedMusic;
    }

    public MusicDto GetMusicByName(string name)
    {
        var music = GetAllMusic();
        var musicByName = music.FirstOrDefault(mu => mu.Name.ToLower() == name.ToLower());

        if (musicByName == null)
        {
            throw new NullReferenceException("Storage is empty");
        }

        return musicByName;
    }

    public List<MusicDto> GetAllMusicAboveSize(double minSizeMB)
    {
        var music = GetAllMusic();
        var musicAboveSize = music.Where(mu => mu.MB > minSizeMB).ToList();

        return musicAboveSize;
    }

    public List<MusicDto> GetAllMusicBelowSize(double maxSizeMB)
    {
        var music = GetAllMusic();
        var musicBelowSize = music.Where(mu => mu.MB < maxSizeMB).ToList();

        return musicBelowSize;
    }

    public List<MusicDto> GetTopMostLikedMusic(int count)
    {
        var music = GetAllMusic();
        var topMostLikedMusic = music.OrderByDescending(mu => mu.QuentityLikes)
                                     .ThenBy(mu => mu.Name)
                                     .Take(count)
                                     .ToList();

        return topMostLikedMusic;
    }

    public List<MusicDto> GetLowMostLikedMusic(int count)
    {
        var music = GetAllMusic();
        var lowMostLikedMusic = music.OrderByDescending(mu => mu.QuentityLikes)
                                     .ThenBy(mu => mu.Name)
                                     .TakeLast(count)
                                     .ToList();

        return lowMostLikedMusic;
    }

    public List<MusicDto> GetMusicByDescriptionKeyword(string keyword)
    {
        var music = GetAllMusic();
        var res = music.Where(mu => mu.Description.ToLower().Contains(keyword.ToLower()))
                       .ToList();

        return res;
    }

    public List<MusicDto> GetMusicWithLikesInRange(int minLikes, int maxLikes)
    {
        var music = GetAllMusic();
        var res = music.Where(mu => minLikes <= mu.QuentityLikes && mu.QuentityLikes <= maxLikes)
                       .ToList();

        return res;
    }

    public List<string> GetAllUniqueAuthors()
    {
        var music = GetAllMusic();

        var names = new List<string>(); 
        foreach (var mus in music)
        {
            var count = music.Count(mu => mu.AuthorName == mus.AuthorName);

            if(count == 1) names.Add(mus.AuthorName);
        }

        return names;
    }

    public double GetTotalMusicSizeByAuthor(string authorName)
    {
        var music = GetAllMusic();
        var res = music.Where(mu => mu.AuthorName.ToLower() == authorName.ToLower())
                       .Sum(m => m.MB);

        return res;
    }
}
