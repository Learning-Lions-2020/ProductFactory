using System;

namespace ProductFactory
{
    public static class ProductFactory
    {
        public static T CreateProduct<T>(params object[] args) where T : IProduct
        {
            T product = (T)Activator.CreateInstance(typeof(T), args);
            product.ShowInfo();
            return product;
        }
    }
}