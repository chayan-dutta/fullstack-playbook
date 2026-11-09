using LinqPractice;

int[] numbers = { 10, 5, 20, 15, 30, 25, 40, 35, 50 };

int[] result = FilterAndTransform.FilterAndTransformGivenArray(numbers);

Console.WriteLine("Filtered and transformed numbers:");

foreach (int number in result)
{
    Console.WriteLine(number);
}