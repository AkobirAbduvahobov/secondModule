using System.Runtime.CompilerServices;
using System.Text;

namespace _2._9dars.Api.Extensions;

public static class StringBuilderExtensionMethods
{
    public static int GetCountDigits(this StringBuilder sb)
    {
        var countDigit = 0;
        for (var i = 0; i < sb.Length; i++)
        {
            if(char.IsDigit(sb[i]))
            {
                countDigit++;
            }
        }

        return countDigit;
    }
}
