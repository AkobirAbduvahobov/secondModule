namespace _2._6dars.Api.HMWRK;

public class ShoppingCart
{
    private List<Product> _products;

    public ShoppingCart()
    {
        _products = new List<Product>();
    }

    public Product AddProduct(Product product)
    {
        _products.Add(product);
        return product;
    }

    public double GetTotalPrice()
    {
        var totalPrice = 0d;

        foreach (var product in _products)
        {
            totalPrice += product.Price * product.Stock;
        }

        return totalPrice;
    }
}
