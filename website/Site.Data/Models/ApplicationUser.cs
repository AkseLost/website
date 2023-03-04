namespace website.Site.Data.Models
{
    public class ApplicationUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public decimal Balance { get; set; }

        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string City { get; set; }

        public string Country { get; set; }

        public DateTime Member { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
