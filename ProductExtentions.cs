public static class ProductExtensions
{
    public static bool IsMoreExpensiveThan(this IProduct product1, IProduct product2)
    {
        if (product1 == null || product2 == null)
            throw new ArgumentNullException("Products cannot be null");
        return product1.Price > product2.Price;
    }

    public static int CountVowels(this string str)
    {
        if (str == null)
            return 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return str.ToLower().Count(c => vowels.Contains(c));
    }
}