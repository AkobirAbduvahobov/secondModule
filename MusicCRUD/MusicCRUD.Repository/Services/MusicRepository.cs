using MusicCRUD.DataAccess.Entity;
using System.Text.Json;

namespace MusicCRUD.Repository.Services;

public class MusicRepository : IMusicRepository
{
    private readonly string _path;
    private List<Music> _music;
    public MusicRepository()
    {
        _path = Path.Combine(Directory.GetCurrentDirectory(), "Music.json");

        if(!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]"); 
        }

        _music = GetAllMusic();
    }

    public Guid AddMusic(Music music)
    {
        _music.Add(music);
        SaveData();
        return music.Id;
    }

    public void DeleteMusic(Guid id)
    {
        var music = GetMusicById(id);
        _music.Remove(music);
        SaveData();
    }

    public List<Music> GetAllMusic()
    {
        var musicJson = File.ReadAllText(_path);
        var musicList = JsonSerializer.Deserialize<List<Music>>(musicJson);
        return musicList;
    }

    public Music GetMusicById(Guid id)
    {
        var music = _music.FirstOrDefault(x => x.Id == id);
        if(music == null)
        {
            throw new Exception($"Music with id {id} not found");
        }

        return music;
    }

    public void UpdateMusic(Music music)
    {
        throw new NotImplementedException();
    }

    private void SaveData()
    {
        var musicJson = JsonSerializer.Serialize(_music);
        File.WriteAllText(_path, musicJson);
    }
}

