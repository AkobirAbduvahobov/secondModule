using MucisCRUD.Service.DTOs;

namespace MucisCRUD.Service.Service;

public interface IMusicService
{
    Guid AddMusic(MusicDto musicDto);
    void DeleteMusic(Guid id);
    List<MusicDto> GetAllMusic();
    void UpdateMusic(MusicDto musicDto);

    List<MusicDto> GetAllMusicByAuthorName(string name);
    MusicDto GetMostLikedMusic();
    MusicDto GetMusicByName(string name);
    List<MusicDto> GetAllMusicAboveSize(double minSizeMB);
    List<MusicDto> GetAllMusicBelowSize(double maxSizeMB);
    List<MusicDto> GetTopMostLikedMusic(int count);
    List<MusicDto> GetLowMostLikedMusic(int count);
    List<MusicDto> GetMusicByDescriptionKeyword(string keyword);
    List<MusicDto> GetMusicWithLikesInRange(int minLikes, int maxLikes);

    /// <summary>
    /// This method returns collection of Author unique names.
    /// Author unique is author who created only single music.
    /// </summary>
    /// <returns></returns>
    List<string> GetAllUniqueAuthors();
    double GetTotalMusicSizeByAuthor(string authorName);
}