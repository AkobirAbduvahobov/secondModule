using MusicCRUD.DataAccess.Entity;
using System.Text.Json;

namespace MusicCRUD.Repository.Services;

public class MusicRepository : IMusicRepository
{
    private readonly string _filePath;
    private readonly string _directoryPath;
    private List<Music> _music;
    public MusicRepository()
    {
        _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Music.json");
        _directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Data");

        if(!Directory.Exists(_directoryPath))
        {
            Directory.CreateDirectory(_directoryPath);
        }

        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath, "[]");
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
        var musicJson = File.ReadAllText(_filePath);
        var musicList = JsonSerializer.Deserialize<List<Music>>(musicJson);
        return musicList;
    }

    public Music GetMusicById(Guid id)
    {
        var music = _music.FirstOrDefault(x => x.Id == id);
        if (music == null)
        {
            throw new Exception($"Music with id {id} not found");
        }

        return music;
    }

    public void UpdateMusic(Music music)
    {
        var musicFromDb = GetMusicById(music.Id);
        var index = _music.IndexOf(musicFromDb);
        _music[index] = music;
        SaveData();
    }

    private void SaveData()
    {
        var musicJson = JsonSerializer.Serialize(_music);
        File.WriteAllText(_filePath, musicJson);
    }
}

