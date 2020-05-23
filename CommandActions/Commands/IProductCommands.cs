using Infrastructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommandActions.Commands
{
    public interface IProductCommands
    {
        Task<Product> AddProduct(Product product);
        Task<Product> DeleteProduct(Product product);
        Task<Product> GetProduct(long id);
        Task<IEnumerable<Product>> GetProducts();
        void UpdateProduct(Product product);
        bool ProductExists(long id);
    }
}