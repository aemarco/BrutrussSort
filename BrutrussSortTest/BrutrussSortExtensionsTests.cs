using BrutrussSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrutrussSortTest;

[TestClass]
public class BrutrussSortExtensionsTests
{
    [TestMethod]
    public void Test_SortedArray()
    {
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        array.Sort();
        Assert.IsTrue(IsSorted(array));
    }

    [TestMethod]
    public void Test_ReverseSortedArray()
    {
        int[] array = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
        array.Sort();
        Assert.IsTrue(IsSorted(array));
    }

    [TestMethod]
    public void Test_RandomArray()
    {
        int[] array = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3];
        array.Sort();
        Assert.IsTrue(IsSorted(array));
    }


    [TestMethod]
    public void Test_StartingWithSmallest()
    {
        int[] array = [1, 7, 4, 2, 5, 9, 2, 6, 5, 3];
        array.Sort();
        Assert.IsTrue(IsSorted(array));
    }




    private static bool IsSorted(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}