using System.Collections.Generic;
using AdsMarketplace.Domain.Entities;
using AdsMarketplace.Domain.Abstract;

namespace AdsMarketplace.Domain.Concrete
{
    class EFCategoryRepository : ICategoryRepository
    {
        AdsContext context = new AdsContext();

        public IEnumerable<TopCategory> TopCategories
        {
            get { return context.TopCategories; }
        }
    }
}
