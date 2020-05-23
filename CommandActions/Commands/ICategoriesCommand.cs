using Infrastructure.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommandActions.Commands
{
    public interface ICategoriesCommand
    {
        Task<Category> AddCategory(Category category);
        bool CategoryExists(long id);
        Task<Category> DeleteCategory(Category category);
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetCategory(long id);
        void UpdateCategory(Category category);
    }
}