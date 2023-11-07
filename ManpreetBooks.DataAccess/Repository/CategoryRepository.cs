using ManpreetBooks.DataAccess.Repository.IRepository;
using ManpreetBooks.Models;
using ManpreetBookStore.DataAccess.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManpreetBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {

            var objFromDb = _db.Categories.FirstOrDefault(s => s.id == category.Id);
            if(objFromDb != null)

            {
                objFromDb.Name = category.Name;
         
            }
            throw new System.NotImplementedException();
        }
    }
}
