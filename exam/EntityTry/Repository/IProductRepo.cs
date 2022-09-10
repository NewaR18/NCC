using EntityTry.Models;
namespace EntityTry.Repository
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductDetail(int id);
        Product EditProduct(Product p);
        Product DeleteProduct(int id);
    }
}