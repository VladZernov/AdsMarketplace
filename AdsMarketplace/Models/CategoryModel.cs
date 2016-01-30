using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdsMarketplace.Domain.Entities;

namespace AdsMarketplace.WebUI.Models
{
    public class CategoryModel
    {
        public CategoryModel(TopCategory topcategory)
        {
            this.TopCategoryId = topcategory.TopCategoryId;
            this.TopCategoryName = topcategory.TopCategoryName;
            this.Description = topcategory.Description;
            this.Categories = topcategory.Categories;
        }
        public int TopCategoryId { get; set; }

        public string TopCategoryName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}