
using Arrays;
using Fundamentals;

int[] arr = { 1, 2, 33, 2, 44, 2, 5, 6, 33, 55, 55, 9, 10, 11 };

// Using Dictionary
var frequency = FrequencyOfElements.FrequencyOfElementsInArray(arr);

Console.WriteLine("Frequency using Dictionary:");
foreach (var item in frequency)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

// Using LINQ
var freq = FrequencyOfElements.FrequencyOfElementsUsingLinq(arr);

Console.WriteLine("\nFrequency using LINQ:");
foreach (var item in freq)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

// Second Largest Element without using soe=rting
int[] arr2= {20, 67, 78, 12, 99, 87, 55};

int secondLargest = SecondLargest.SecondLargestWithoutSorting(arr2);

Console.WriteLine($"Second largest number is {secondLargest}");
