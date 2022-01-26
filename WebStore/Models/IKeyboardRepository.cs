using System.Collections.Generic;

namespace WebStore.Models
{
    public interface IKeyboardRepository
    {
        IEnumerable<Keyboard> GetAllKeyboard { get; }
        IEnumerable<Keyboard> GetKeyboardsOnSale { get; }  
        Keyboard GetKeyboardById(int keyboardId);
    }
}
