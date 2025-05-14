namespace ProductFactory;

public class ProductFactory
{
    public event EventHandler<ProductEventArgs>? productCreatedEvent;

    public T CreateProduct<T>(params object[] args) where T : IProduct
    {
        T product = (T)Activator.CreateInstance(typeof(T), args);
        productCreatedEvent?.Invoke(this, new ProductEventArgs(product));
        return product;
    }
}