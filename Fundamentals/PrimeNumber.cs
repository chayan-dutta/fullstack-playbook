namespace Fundamentals;

/// <summary>
/// Provides functionality to check whether a number is prime.
/// </summary>
public static class PrimeNumber
{
    /// <summary>
    /// Determines whether the specified number is a prime number.
    /// </summary>
    /// <param name="number">The integer to check.</param>
    /// <returns>
    /// True if the number is prime; otherwise, false.
    /// </returns>
    public static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
