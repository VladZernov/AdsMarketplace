using System.Collections.Generic;
using AdsMarketplace.Domain.Entities;
using AdsMarketplace.Domain.Abstract;

namespace AdsMarketplace.Domain.Concrete
{
    public class EFAdvertisementRepository : IAdvertisementRepository
    {
        AdsContext context = new AdsContext();

        public IEnumerable<Advertisement> Advertisements
        {
            get { return context.Advertisements; }
        }

    }
}