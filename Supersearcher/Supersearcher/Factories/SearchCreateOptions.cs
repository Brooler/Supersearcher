using Supersearcher.Domain.Interfaces;
using Supersearcher.Domain.Models;
using Supersearcher.Domain.Models.ResultItems;

namespace Supersearcher.Factories
{
    public class SearchCreateOptions<TImplementation, TResult, TItem>
            where TItem : SearchResultItemBase
            where TResult : SearchResultBase<TItem>
            where TImplementation : ISearch<TResult, TItem>, new()
    {
        public SearchCreateOptions(bool useStatistics = false)
        {
            UseStatistics = useStatistics;
        }

        public bool UseStatistics { get; set; }
    }
}
