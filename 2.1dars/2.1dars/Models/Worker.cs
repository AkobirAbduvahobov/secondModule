namespace _2._1dars.Models;

public static class Worker
{
    public static int GetAmountOfDigits(string text)
    {
        var counter = 0;
        foreach (char character in text)
        {
            if(Char.IsDigit(character) is true)
            {
                counter++;
            }
        }

        return counter;
    }
}
