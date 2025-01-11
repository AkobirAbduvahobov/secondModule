using MusicCRUD.DataAccess.Entity;

namespace MusicCRUD.Repository.Services;

public interface IMusicRepository
{
    /// <summary>
    /// This method add new music to our storage.
    /// It gets as argument Music music and returns id.
    /// </summary>
    /// <param name="music"></param>
    /// <returns></returns>
    Guid AddMusic(Music music);

    /// <summary>
    /// This method removes music from storage.
    /// </summary>
    /// <param name="id"></param>
    void DeleteMusic(Guid id);

    void UpdateMusic(Music music);
    Music GetMusicById(Guid id);
    List<Music> GetAllMusic();
}