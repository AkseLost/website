namespace website.Site.Data.Models
{
    public class category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public IEnumerable<Images> FoodProducts { get; set; }
    }
}
