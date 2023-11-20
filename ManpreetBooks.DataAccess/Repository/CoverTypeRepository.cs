using ManpreetBooks.DataAccess.Repository.IRepository;
using ManpreetBooks.Models;
using ManpreetBookStore.DataAccess.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManpreetBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository

    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType covertype)
        {

            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.id == covertype.id);
            if (objFromDb != null)

            {
                objFromDb.Name = covertype.Name;

            }
            throw new System.NotImplementedException();
        }
    }
}
