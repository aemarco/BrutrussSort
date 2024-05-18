using BrutrussSort;
using System;

var size = 1;
var rand = new Random();

while (true)
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
        Console.WriteLine($"Stack overflow occurred at size: {size}");
        break;
    }
    size += 1;
}

