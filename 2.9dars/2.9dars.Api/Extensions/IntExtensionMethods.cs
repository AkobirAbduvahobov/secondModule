namespace _2._9dars.Api.Extensions;

public static class IntExtensionMethods
{
    public static int GetRooms(this int number)
    {
        return Convert.ToString(number).Length;
    }

    public static void DecreaseValue(this ref int number, int value)
    {
        number += value;
    }
}
