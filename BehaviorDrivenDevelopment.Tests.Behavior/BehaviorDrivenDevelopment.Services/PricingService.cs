namespace BehaviorDrivenDevelopment.Services;

public interface IPricingService
{
    decimal GetBasketTotalAmount(Basket basket);
}

public class PricingService : IPricingService
{
    public decimal GetBasketTotalAmount(Basket basket)
    {
        if (!basket.Products.Any())
            return 0;

        var basketValue = basket.Products.Sum(i => i.Price);

        if (basket.User.IsLoggedIn)
        {
            return basketValue - (basketValue * 0.05m);
        }

        return basketValue;
    }
}

public class Basket
{
    public User User { get; set; }
    public List<Product> Products { get; set; } = new();
}

public class User
{
    public bool IsLoggedIn { get; set; }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}