using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class HomeproductViewModel
    {
        public List<HomeproductItem> HomeproductItems { get; set; }

        public HomeproductViewModel()
        {
            HomeproductItems = new List<HomeproductItem>();
        }
    }

    public class HomeproductItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public List<homeOzellikItem>? HomeOzellikItems { get; set; }
    }

    public class homeOzellikItem
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
