using AdsMarketplace.Domain.Entities;
using System.Collections.Generic;

namespace AdsMarketplace.Domain.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<TopCategory> TopCategories { get; }
    }
}
