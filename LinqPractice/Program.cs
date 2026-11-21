using LinqPractice;

int[] numbers = { 10, 5, 20, 15, 30, 25, 40, 35, 50, 40, 50, 15, 15 };

int[] result = FilterAndTransform.FilterAndTransformGivenArray(numbers);

Console.WriteLine("Filtered and transformed numbers:");

foreach (int number in result)
{
    Console.WriteLine(number);
}

// Remove duplicates
int[] duplicates = DuplicateElements.DuplicateElementsUsingLINQ(numbers);

Console.WriteLine("Duplicate elements are:");

foreach (int d in duplicates)
{
    Console.WriteLine(d);
}