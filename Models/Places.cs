using System.Collections.Generic;
using System;

namespace FavoritePlaces.Models
{
    public class Place
    {
        private string _city;
        private int _stayTime;
        private string _image;
        private static List<Place> _instances = new List<Place> {};

        public Place (string city, int stayTime, string image)
        {
            _city = city;
            _stayTime = stayTime;
            _image = image;
        }

        public string GetCity()
        {
            return _city;
        }
        public void SetCity(string newCity)
        {
            _city = newCity;
        }
        public int GetStayTime()
        {
          return _stayTime;
        }
        public void SetStayTime(int newStayTime)
        {
          _stayTime = newStayTime;
        }
        public string GetImage()
        {
            return _image;
        }
        public void SetImage(string newImage)
        {
            _image = newImage;
        }

        public void Save()
        {
            _instances.Add(this);
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static List<Place> GetAll()
        {
          return _instances;
        }
    }
}
