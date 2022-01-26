using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebStore.Models
{
    public class KeyboardRepository : IKeyboardRepository
    {
        private readonly AppDbContext _appDbContext;
        public KeyboardRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Keyboard> GetAllKeyboard 
        {
            get
            {
                return _appDbContext.Keyboards.Include(c => c.Category);
            }
        }

        public IEnumerable<Keyboard> GetKeyboardsOnSale
        {
            get
            {
                return _appDbContext.Keyboards.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Keyboard GetKeyboardById(int keyboardId)
        {
            return _appDbContext.Keyboards.FirstOrDefault(c => c.KeyboardId == keyboardId);
        }
    }
}
