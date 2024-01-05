using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class SliderViewModel
    {
        public List<SliderItem> SliderItems { get; set; }

        public SliderViewModel()
        {
            SliderItems = new List<SliderItem>(); 
        }
    }

    public class SliderItem
    {
        public string? PageTitle { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? Id { get; set; }
    }
}



