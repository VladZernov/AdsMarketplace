using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdsMarketplace.Domain.Abstract;
using AdsMarketplace.Domain.Entities;
using AdsMarketplace.WebUI.Models;

namespace AdsMarketplace.WebUI.Controllers
{
    public class AdvertisementController : Controller
    {
        private IAdvertisementRepository repository;
        public AdvertisementController(IAdvertisementRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            AdvertisementModel model = new AdvertisementModel
            {
                Advertisements = repository.Advertisements
            };
            return View(model);
        }
    }
}