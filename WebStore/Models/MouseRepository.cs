using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebStore.Models
{
    public class MouseRepository : IMouseRepository
    {
        private readonly AppDbContext _appDbContext;
        public MouseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Mouse> GetAllMouse
        { 
            get
            {
                return _appDbContext.Mice.Include(c => c.Category);
            }
        }
        
        public IEnumerable<Mouse> GetMiceOnSale
        {
            get
            {
                return _appDbContext.Mice.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public IEnumerable<Mouse> GetMousesOnSale => throw new System.NotImplementedException();

        public Mouse GetMouseById(int mouseId)
        {
            return _appDbContext.Mice.FirstOrDefault(c => c.MouseId == mouseId);
        }
    }
}
