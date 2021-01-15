using Supersearcher.Domain.Interfaces;
using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;
using Supersearcher.Statistics;
using System.Collections;

namespace Supersearcher.Factories
{
    public class SearchFactory
    {
        public static ISearch<TResult, TItem> Create<TImplementation, TResult, TItem>(SearchCreateOptions<TImplementation, TResult, TItem> options)
            where TItem : SearchResultItemBase
            where TResult : SearchResultBase<TItem>
            where TImplementation : ISearch<TResult, TItem>, new()
        {
            if (options.UseStatistics)
            {
                return new StatisticsCollectorProxy<TImplementation, TResult, TItem>();
            }
            else
            {
                return new TImplementation();
            }
        }
    }
}
