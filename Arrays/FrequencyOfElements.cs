namespace Arrays;

public class FrequencyOfElements
{
    /// <summary>
    /// Calculates the frequency of each element in the given integer array
    /// using a Dictionary and foreach loop.
    ///
    /// Time Complexity: O(n) average
    /// Space Complexity: O(k), where k is the number of unique elements.
    /// </summary>
    /// <param name="arr">The input integer array.</param>
    /// <returns>
    /// A dictionary containing each unique element as the key
    /// and its frequency as the value.
    /// </returns>
    public static Dictionary<int, int> FrequencyOfElementsInArray(int[] arr)
    {
        Dictionary<int, int> freq = [];

        foreach (int n in arr)
        {
            if (freq.TryGetValue(n, out int value))
                freq[n] = value + 1;
            else
                freq.Add(n, 1);
        }

        return freq;
    }

    /// <summary>
    /// Calculates the frequency of each element in the given integer array
    /// using LINQ GroupBy and ToDictionary.
    ///
    /// Time Complexity: O(n) average
    /// Space Complexity: O(n), including the grouping and dictionary results.
    /// </summary>
    /// <param name="array">The input integer array.</param>
    /// <returns>
    /// A dictionary containing each unique element as the key
    /// and its frequency as the value.
    /// </returns>
    public static Dictionary<int, int> FrequencyOfElementsUsingLinq(int[] array)
    {
        return array
            .GroupBy(n => n)
            .ToDictionary(
                grp => grp.Key,
                grp => grp.Count()
            );
    }

}
