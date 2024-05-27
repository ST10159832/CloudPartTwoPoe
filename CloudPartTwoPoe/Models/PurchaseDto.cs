using System.ComponentModel.DataAnnotations;

namespace CloudPartTwoPoe.Models
{
    public class PurchaseDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string ItemPurchased { get; set; }
    }
}
