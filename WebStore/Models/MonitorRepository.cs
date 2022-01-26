using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebStore.Models 
{
    public class MonitorRepository : IMonitorRepository
    {
        private readonly AppDbContext _appDbContext;
        public MonitorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Monitor> GetAllMonitor
        {
            get
            {
                return _appDbContext.Monitors.Include(c => c.Category);
            }
        }  

        public IEnumerable<Monitor> GetMonitorsOnSale
        {
            get
            {
                return _appDbContext.Monitors.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Monitor GetMonitorById(int monitorId)
        {
            return _appDbContext.Monitors.FirstOrDefault(c => c.MonitorId == monitorId);
        }
    }
}
