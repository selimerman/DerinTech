
using System.ComponentModel.DataAnnotations;
namespace Web.Models
{
    public class ProductViewModel
    {
        public class ProductLst
        {
            public string? PageTitle { get; set; }
            public List<Product> Products { get; set; }
        }
        public class Product
        {
            public int Id { get; set; }
            public string? Description { get; set; }
            public string? PageName { get; set; }
            public string? PageUrl { get; set; }
            public string? ImageUrl { get; set; }
            public string? Category { get; set; }
            public string? CategoryTag { get; set; }
            public string? Detay { get; set; }
            public List<OzellikItem>? Ozellikleri { get; set; }
          

        }
        public class OzellikItem
        {
            public string Title { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
        }
    }
}
