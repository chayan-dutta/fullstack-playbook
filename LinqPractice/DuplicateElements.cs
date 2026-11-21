namespace LinqPractice;


/// <summary>
/// Provides methods to identify duplicate elements in an array.
/// </summary>
public class DuplicateElements
{
    /// <summary>
    /// Finds all duplicate elements in an array using LINQ.
    /// GroupBy() returns groups of elements where each group contains
    /// identical values. Each group is an IGrouping<TKey, TElement>,
    /// which provides:
    /// - Key: The distinct element used to create the group.
    /// - Elements: All occurrences of that element in the group.
    ///
    /// Where() filters groups having more than one element.
    /// Select() extracts the Key (duplicate value) from each group.
    /// </summary>
    /// <param name="arr">The input array of integers.</param>
    /// <returns>An array containing distinct duplicate elements.</returns>
    public static int[] DuplicateElementsUsingLINQ(int[] arr)
    {
        return [.. arr
            .GroupBy(g => g)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)];
    }
}
