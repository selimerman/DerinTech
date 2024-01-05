
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Web.Models
{
    public class PageViewModel
    {
        public List<PageItem> PageItems { get; set; }
    }
    public class PageItem
    {
        public string? PageTitle { get; set; }
        public string? Description { get; set; }
        public List<PageProperty>? PageProperties { get; set; }
    }

    public class PageProperty
    {
        public string? PropertyTitle { get; set; }
        public string? PropertyDescription { get; set; }
        public string? PropertyColor { get; set; }
        public int? PropertyValue { get; set; }
    }
}
