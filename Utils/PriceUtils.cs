public static class PriceUtils
{
    public static void RoundPrice(Product product)
    {
        product.Price = Math.Round(product.Price, 2);
    }

    public static string FormatPrice(Product product)
    {
        return product.Price.ToString("F2");
    }
}