
using Arrays;

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
