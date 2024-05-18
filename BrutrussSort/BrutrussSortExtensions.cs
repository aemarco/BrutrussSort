namespace BrutrussSort;

public static class BrutrussSortExtensions
{
    public static bool Sort(this int[] array, int currentIndex = 0)
    {
        var isSorted = true;
        for (var i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                isSorted = false;
                break;
            }
        }
        if (isSorted)
            return true;

        if (currentIndex >= array.Length - 1)
            return false;

        if (array.Sort(currentIndex + 1))
            return true;

        for (var i = currentIndex + 1; i < array.Length; i++)
        {
            (array[currentIndex], array[i]) = (array[i], array[currentIndex]);
            if (array.Sort(currentIndex + 1))
                return true;
            (array[currentIndex], array[i]) = (array[i], array[currentIndex]);
        }
        return false;
    }
}

