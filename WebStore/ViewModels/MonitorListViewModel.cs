using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;
namespace WebStore.ViewModels
{
    public class MonitorListViewModel
    {
        public IEnumerable<Monitor> Mice { get; set; }
        public string CurrentCategory { get; set; }
    }
}
