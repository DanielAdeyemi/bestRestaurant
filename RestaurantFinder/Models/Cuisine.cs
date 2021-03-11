using System.Collections.Generic;

namespace RestaurantFinder.Models
{
    public class Cuisine
    {
        public string Name { get; set; }
        public int CuisineId { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

        public Cuisine()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }
    }

    public enum Name
        {
            Thai,
            Chinese,
            American,
            Mexican,
            French,
            Spanish,
            Russian,
            Polish,
            Japanese,
            Indian
        }
}