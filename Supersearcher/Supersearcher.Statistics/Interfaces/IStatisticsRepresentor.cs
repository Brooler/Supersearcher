using Supersearcher.Statistics.Models;
using System.Threading.Tasks;

namespace Supersearcher.Statistics.Interfaces
{
    public interface IStatisticsRepresentor
    {
        Task<StatisticsModel> PrepareStatistics();
    }
}
