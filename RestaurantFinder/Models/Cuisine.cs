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
}