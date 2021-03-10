namespace RestaurantFinder.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }
        public string Hours { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}