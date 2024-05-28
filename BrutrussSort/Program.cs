using BrutrussSort;
using System;

var rand = new Random();
for (long size = 1; size <= int.MaxValue; size++)
{
    var array = new int[size];
    for (var i = 0; i < size; i++)
        array[i] = rand.Next(1000);

    try
    {
        array.Sort();
        Console.WriteLine($"Sorted array of size: {size} --> [ {string.Join(", ", array)} ]");
    }
    catch (StackOverflowException)
    {
        Console.WriteLine($"Stack overflow occurred at size: {size}. You won a cookie.");
        break;
    }
}
Console.WriteLine("Seems like you lost the cookie contest. Did you grew a beard ?");


