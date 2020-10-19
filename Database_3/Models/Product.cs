using System.ComponentModel.DataAnnotations;

namespace Database_3.Models
{
	public class Product
	{
		[Key]
		public int ProId { get; set; }

		[Required]
		public string ProName { get; set; }

		[Required]
		public int Price { get; set; }

	}
}