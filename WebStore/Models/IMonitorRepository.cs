using System.Collections.Generic;

namespace WebStore.Models
{
    public interface IMonitorRepository
    {
        IEnumerable<Monitor> GetAllMonitor { get; }
        IEnumerable<Monitor> GetMonitorsOnSale { get; }
        Monitor GetMonitorById(int MonitorId);
    }
}
