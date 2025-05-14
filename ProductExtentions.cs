namespace ProductFactory
{
    public static class ProductExtensions
    {
        public static bool IsMoreExpensiveThan(this IProduct product1, IProduct product2)
        {
            return product1.Price > product2.Price;
        }
    }
}