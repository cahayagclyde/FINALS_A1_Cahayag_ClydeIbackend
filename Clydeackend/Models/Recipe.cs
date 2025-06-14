namespace Clydeackend.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Steps { get; set; }
        public string ImageUrl { get; set; }
    
}
}