using MusicCRUD.DataAccess.Entity;

namespace MusicCRUD.Repository.Services;

public interface IMusicRepository
{
    Guid AddMusic(Music music);
    void DeleteMusic(Guid id);
    void UpdateMusic(Music music);
    Music GetMusicById(Guid id);
    List<Music> GetAllMusic();
}