using System.Collections.Generic;

namespace WebStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Keyboard> Keyboards { get; set; }

    }
}
