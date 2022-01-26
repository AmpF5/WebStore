using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
namespace WebStore.ViewModels
{
    public class MouseListViewModel
    {
        public IEnumerable<Mouse> Mice { get; set; }
        public string CurrentCategory { get; set; }
    }
}
