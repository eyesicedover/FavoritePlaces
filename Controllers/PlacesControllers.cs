using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FavoritePlaces.Models;

namespace FavoritePlaces.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create()
        {
            string newCity = Request.Form["cityName"];
            string stringNewStayTime = Request.Form["StayTime"];
            int intNewStayTime = int.Parse(stringNewStayTime);
            string newImage = Request.Form["imageLink"];
            Place newPlace = new Place(newCity, intNewStayTime, newImage);
            newPlace.Save();
            List<Place> allPlaces = Place.GetAll();
            return View("Index", allPlaces);
        }

        [HttpPost("/places/clear")]
        public ActionResult Clear()
        {
            Place.ClearAll();
            List<Place> allPlaces = Place.GetAll();
            return View("Index", allPlaces);
        }
    }
}
