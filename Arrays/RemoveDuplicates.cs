namespace Arrays;

public class RemoveDuplicates
{

    /// <summary>
    /// Removes duplicate elements using a HashSet
    /// while preserving the original order.
    /// </summary>
    /// <param name="arr">The input integer array.</param>
    /// <returns>An array containing unique elements.</returns>
    public static int[] RemoveDuplicatesOptimized(int[] arr)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        foreach (int item in arr)
        {
            if (seen.Add(item))
            {
                result.Add(item);
            }
        }

        return result.ToArray();
    }

}
