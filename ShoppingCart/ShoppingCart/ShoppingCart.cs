namespace ShoppingCart.ShoppingCart;

public class ShoppingCart
{
    private readonly HashSet<ShoppingCartItem> _items = new();

    public int UserId { get; }
    public IEnumerable<ShoppingCartItem> Items => _items;

    public ShoppingCart(int userId)
    {
        UserId = userId;
    }

    public void AddItems(IEnumerable<ShoppingCartItem> items)
    {
        foreach (var item in items)
        {
            _items.Add(item);
        }
    }

    public void RemoveItems(int[] productCatalogIds) =>
        _items.RemoveWhere(i => productCatalogIds.Contains(i.ProductCatalogueId));
}