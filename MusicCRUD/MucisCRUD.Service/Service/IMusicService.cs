using MucisCRUD.Service.DTOs;

namespace MucisCRUD.Service.Service;

public interface IMusicService
{
    Guid AddMusic(MusicDto musicDto);
    void DeleteMusic(Guid id);  
    List<MusicDto> GetAllMusic();
}