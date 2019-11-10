using System.Collections.Generic;
using BookAccounting.FilterBuilder;

namespace BookAccounting.CustomControls
{
    public interface IFilterProvider
    {
        IEnumerable<FilterStatement> GetFilters();
    }
}