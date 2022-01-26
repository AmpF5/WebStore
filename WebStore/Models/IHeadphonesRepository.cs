using System.Collections.Generic;

namespace WebStore.Models
{
    public interface IHeadphonesRepository
    {
        IEnumerable<Headphones> GetAllHeadphones { get; }
        IEnumerable<Headphones> GetHeadphonesOnSale { get; }
        Headphones GetHeadphonesById(int HeadphonesId);
    }
}
