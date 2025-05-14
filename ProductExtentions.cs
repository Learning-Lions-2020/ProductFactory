namespace ProductFactory
{
    public static class ProductExtensions
    {
        public static bool IsMoreExpensiveThan(this IProduct product1, IProduct product2)
        {
            if (product1 == null || product2 == null)
                throw new ArgumentNullException("Products cannot be null");
            return product1.Price > product2.Price;
        }
    }
}