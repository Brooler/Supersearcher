using Supersearcher.Statistics.Interfaces;
using Supersearcher.Statistics.Models;
using System.Threading.Tasks;

namespace Supersearcher.Statistics
{
    public class StatisticsRepresentor : IStatisticsRepresentor
    {
        public Task<StatisticsModel> PrepareStatistics()
        {
            //TODO: Prepare Statistics model (using singleton in our case)
            throw new System.NotImplementedException();
        }
    }
}
