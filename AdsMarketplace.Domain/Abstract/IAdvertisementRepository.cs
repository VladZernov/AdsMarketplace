using AdsMarketplace.Domain.Entities;
using System.Collections.Generic;


namespace AdsMarketplace.Domain.Abstract
{
    public interface IAdvertisementRepository
    {
        IEnumerable<Advertisement> Advertisements { get; }
    }
}
