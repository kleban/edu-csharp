using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDemo
{
    public class PlaceManager
    {
        private List<Place> places;

        public PlaceManager()
        {
            places = new List<Place>();
            places.Add(new Place { Title = "Eiffel Tower", ImagePath = "img/1.jpg" });
            places.Add(new Place { Title = "Statue of Liberty", ImagePath = "img/2.jpg" });
        }

        public List<Place> GetPlaces()
        {
            return places;
        }

        public void AddPlace(Place newPlace)
        {
            places.Add(newPlace);
        }
    }
}
