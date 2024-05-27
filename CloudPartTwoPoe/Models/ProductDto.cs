using System.ComponentModel.DataAnnotations;

namespace CloudPartTwoPoe.Models
{
	public class ProductDto
	{
		[Required]
		public string Name { get; set; }

		[Required]
		[Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
		public int Price { get; set; }

		[Required]
		public string Category { get; set; }

		[Required]
		public string Availability { get; set; }
	}
}
