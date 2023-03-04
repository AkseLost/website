namespace website.Site.Data.Models
{
    public class Images
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public double Price { get; set; }

        // TODO: в събота ще си направим връзката с картинката с която сме свалили и ще вържем с контролери да можем да видим в web browser
        public string Image { get; set; }

        //dali sa ni nalichni productite
        public int InStock { get; set; }

        public int CategoryId { get; set; }



        public Images(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
