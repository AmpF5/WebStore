using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebStore.Models
{
    public class HeadphonesRepository : IHeadphonesRepository
    {
        private readonly AppDbContext _appDbContext;
        public HeadphonesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Headphones> GetAllHeadphones
        {
            get
            {
                return _appDbContext.Headphones.Include(c => c.Category);
            }
        }

        public IEnumerable<Headphones> GetHeadphonesOnSale
        {
            get
            {
                return _appDbContext.Headphones.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Headphones GetHeadphonesById(int headphonesId)
        {
            return _appDbContext.Headphones.FirstOrDefault(c => c.HeadphonesId == headphonesId);
        }
    }
}
