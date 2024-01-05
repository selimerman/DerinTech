using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ViewComponents
{
    [ViewComponent(Name = "Slider")]
    public class SliderComponent : BaseViewComponent
    {
        public new readonly IConfiguration Configuration;

        public SliderComponent(IConfiguration configuration) : base(configuration)
        {
            Configuration = configuration;
        }

        private SliderViewModel GetSliderModel()
        {
            return new SliderViewModel
            {
                SliderItems = new List<SliderItem>
                {
                    new SliderItem
                    {
                        PageTitle = " SİBER GÜVENLİK ÜRÜNLERİMİZ",
                        Description = "Dijital Dünyada Güvende Kalın",
                        Image = "img/slides/3.jpg",
                        Id = "1",
                    },
                    new SliderItem
                    {
                        PageTitle = "SİBER GÜVENLİK ÜRÜNLERİMİZ",
                        Description = "İhtiyaçlarınıza Özel Çözümler Sunuyoruz.",
                        Image = "img/slides/4.jpg",
                        Id = "2",
                    }
                }
            };
        }

        public IViewComponentResult Invoke()
        {
            var sliderModel = GetSliderModel();
            return View(sliderModel);
        }
    }
}
