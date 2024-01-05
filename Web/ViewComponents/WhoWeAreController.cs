using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ViewComponents
{
    [ViewComponent(Name = "WhoWeAre")]
    public class WhoWeAreComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;

        public WhoWeAreComponent(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new List<WhoWeAreItem>
            {
                new WhoWeAreItem
                {
                    PageTitle = "BİZ KİMİZ ?",
                    Description = "Derintech Bilişim, siber güvenliğinizi en üst düzeye çıkaran çözümlerle işinizi güçlendiriyor. Öncü teknoloji ve güvenlik yazılımları ile iş süreçlerinizi optimize edin. Siber tehditlere karşı güvende olun,dijital dönüşümle tanışın ve online dünyada öne çıkın. Hemen iletişime geçin, siber güvenlikle güçlendirilmiş iş çözümlerimizle işinizi büyütmenin avantajlarına birlikte adım atalım!",
                    Image = "img/dddd.jpg"
                },
            
            };

            return View(model);
        }
    }
}
