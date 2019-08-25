namespace Inventory.API.Resources
{
    public class ProductsQueryResource : QueryResource
    {
        public int? CategoryId { get; set; }
    }
}