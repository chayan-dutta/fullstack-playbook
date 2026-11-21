namespace Fundamentals;

/// <summary>
/// Provides methods to find the second-largest element in an array.
/// </summary>
public class SecondLargest
{
    /// <summary>
    /// Finds the second-largest distinct element in an array without sorting.
    /// </summary>
    /// <param name="arr">The input array of integers.</param>
    /// <returns>The second-largest distinct element.</returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the array is null, contains fewer than two elements,
    /// or does not contain at least two distinct elements.
    /// </exception>
    public static int SecondLargestWithoutSorting(int[] arr)
    {
        if (arr == null || arr.Length < 2)
            throw new ArgumentException("Array must contain at least two elements.");

        int largest = int.MinValue;
        int sl = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                sl = largest;
                largest = num;
            }
            else if (num > sl && num < largest)
            {
                sl = num;
            }
        }

        if (sl == int.MinValue)
            throw new ArgumentException("Array must contain at least two distinct elements.");

        return sl;
    }
}

