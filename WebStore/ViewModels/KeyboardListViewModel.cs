using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
namespace WebStore.ViewModels
{
    public class KeyboardListViewModel
    {
        public IEnumerable<Keyboard> Keyboards { get; set; }
        public string CurrentCategory { get; set; }
    }
}
