using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.ShoppingCart;

[Route("/shopping-cart")]
public class ShoppingCartController : ControllerBase
{
    private readonly IShoppingCartStore _shoppingCartStore;

    public ShoppingCartController(IShoppingCartStore shoppingCartStore)
    {
        _shoppingCartStore = shoppingCartStore;
    }

    [HttpGet("{userId:int}")]
    public ShoppingCart Get(int userId) =>
        _shoppingCartStore.Get(userId);
}