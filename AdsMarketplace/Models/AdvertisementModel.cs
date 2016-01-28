using System;
using System.Collections.Generic;
using AdsMarketplace.Domain.Entities;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdsMarketplace.WebUI.Models
{
    public class AdvertisementModel
    {
        public IEnumerable<Advertisement> Advertisements { get; set; }

        //private int _adid { get; set; }
        //private string _itemdescryption { get; set; }
        //private string _imagename { get; set; }
        //private Nullable<decimal> _price { get; set; }
        //private string _itemname { get; set; }
        //private string _dealtypename { get; set; }
        //private string _statusname { get; set; }
        //private ICollection<Category> _categories { get; set; }
        //private string _conditionname { get; set; }
        //private string _firstname { get; set; }
        //private string _lastname { get; set; }
        //private string _phone { get; set; }
        //private string _city { get; set; }
        //public Advertisement( Domain.Entities.Advertisement advertisement)
        //{
        //    this._adid = advertisement.AdId;
        //    this._itemdescryption = advertisement.ItemDescription;
        //    this._imagename = advertisement.ImageName;
        //    this._price = advertisement.Price;
        //    this._itemname = advertisement.ItemName;
        //    this._categories = advertisement.Categories;
        //    this._dealtypename = advertisement.DealType.DealTypeName;
        //    this._statusname = advertisement.Status.StatusName;
        //    this._conditionname = advertisement.Condition.ConditionName;
        //    this._firstname = advertisement.User.FirstName;
        //    this._lastname = advertisement.User.LastName;
        //    this._phone = advertisement.User.Phone;
        //    this._city = advertisement.User.City;
        //}

        //[Display(Name = "Наименование:")]
        //public string Name
        //{
        //    get
        //    {
        //        return _itemname;
        //    }

        //    set
        //    {
        //        _itemname = value;
        //    }
        //}

        //[Display(Name = "Цена:")]
        //public decimal? Price
        //{
        //    get
        //    {
        //        return _price;
        //    }

        //    set
        //    {
        //        _price = value;
        //    }
        //}

        //public string ItemDescription
        //{
        //    get
        //    {
        //        return _itemdescryption;
        //    }

        //    set
        //    {
        //        _itemdescryption = value;
        //    }
        //}

        //public string DealType
        //{
        //    get
        //    {
        //        return _dealtypename;
        //    }

        //    set
        //    {
        //        _dealtypename = value;
        //    }
        //}

        //public string Status
        //{
        //    get
        //    {
        //        return _statusname;
        //    }

        //    set
        //    {
        //        _statusname = value;
        //    }
        //}

        //public string Condition
        //{
        //    get
        //    {
        //        return _conditionname;
        //    }

        //    set
        //    {
        //        _conditionname = value;
        //    }
        //}
    }
}



