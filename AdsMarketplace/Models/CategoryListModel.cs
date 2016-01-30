using System;
using System.Collections.Generic;
using AdsMarketplace.Domain.Entities;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdsMarketplace.WebUI.Models
{
    public class CategoryListModel
    {
        public IEnumerable<TopCategory> TopCategories { get; set; }
    }
}