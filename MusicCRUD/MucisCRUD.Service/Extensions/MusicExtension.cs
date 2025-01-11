using MucisCRUD.Service.DTOs;

namespace MucisCRUD.Service.Extensions;

public static class MusicExtension
{
    public static double GetMusicKB(this MusicDto musicDto)
    {
        return musicDto.MB * 1024;
    }

    public static int GetQuentityLikes(this List<MusicDto> musicDtos)
    {
        return musicDtos.Sum(mu => mu.QuentityLikes);
    }
}
