using System.Collections.Generic;

namespace WebStore.Models
{
    public interface IMouseRepository
    {
        IEnumerable<Mouse> GetAllMouse { get; }
        IEnumerable<Mouse> GetMousesOnSale { get; }
        Mouse GetMouseById(int mouseId);
    }
}
