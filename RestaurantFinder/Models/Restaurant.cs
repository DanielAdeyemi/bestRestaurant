using System.ComponentModel;

namespace RestaurantFinder.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }
        public string Hours { get; set; }
        [DisplayName("Number of Employees")]
        public int NumberOfEmployees { get; set; }
        public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; }
    }
}