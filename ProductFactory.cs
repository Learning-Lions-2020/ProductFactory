namespace ProductFactory;

public delegate void ProductCreated<T>(T product);

public class ProductFactory
{
    private readonly ProductCreated<IProduct> _productCreated;

    public ProductFactory(ProductCreated<IProduct> productCreated)
    {
        _productCreated = productCreated ?? throw new ArgumentNullException(nameof(productCreated));
    }

    public T CreateProduct<T>(params object[] args) where T : IProduct
    {
        T product = (T)Activator.CreateInstance(typeof(T), args);
        _productCreated?.Invoke(product);
        return product;
    }
}