using _2._9dars.Api.Models;

namespace _2._9dars.Api.Extensions;

public static class CollectionPhonesExtensionMethods
{
    public static double GetTotalWeight(this List<Phone> phoneList)
    {
        double totalWeight = 0;
        foreach (Phone phone in phoneList)
        {
            totalWeight += phone.Weight;
        }

        return totalWeight;
    }
}
