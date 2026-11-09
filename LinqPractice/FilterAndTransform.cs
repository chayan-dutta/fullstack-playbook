namespace LinqPractice;

public class FilterAndTransform
{
    /// <summary>
    /// Filters numbers greater than 20, doubles them,
    /// sorts them in ascending order, and returns an array.
    /// </summary>
    /// <param name="array">Input array of integers.</param>
    /// <returns>Filtered, transformed, and sorted integer array.</returns>
    public static int[] FilterAndTransformGivenArray(int[] array)
    {
        return 
            array
            .Where(n => n > 20)
            .Select(n => n * 2)
            .OrderBy(n => n)
            .ToArray();
    }
}
