using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ViewComponents
{
    [ViewComponent(Name = "Products")]
    public class ProductsComponent : BaseViewComponent
    {
        public new readonly IConfiguration Configuration;

        public ProductsComponent(IConfiguration configuration) : base(configuration)
        {
            Configuration = configuration;
        }

        public IViewComponentResult Invoke()
        {
            var homeProductModel = new HomeproductViewModel
            {
                HomeproductItems = new List<HomeproductItem>
                {
                    new HomeproductItem
                    {
                        Title = "SİZE NASIL YARDIMCI OLABİLİRİZ ?",
                        Description = "Derintech Bilişim, siber güvenlik alanında sunduğu ürünlerle işinizi en üst düzeye çıkarmanıza yardımcı oluyor. Güvenliğinizi sağlamak, siber tehditlere karşı korunmak için özel olarak tasarlanmış yerli yazılımlar ve çözümlerimizle tanışın. Siber güvenlik önlemlerinizde güçlü bir adım atın, iş süreçlerinizi koruyun ve online dünyada güvenle faaliyet gösterin. Hemen iletişime geçin, siber güvenlikle güçlendirilmiş iş çözümlerimizle işinizi büyütmenin avantajlarına birlikte adım atalım!",
                        HomeOzellikItems = new List<homeOzellikItem>
                        {
                            new homeOzellikItem
                            {
                                Title = "Marka koruma",
                                Image = "shield",
                                Description = "Dijitalleşen dünyada siz de markanızı koruma altına alı! Markanızı dijital dünyada koruma altına alın.",
                            },
                            new homeOzellikItem
                            {
                                Title = "VIP Koruma",
                                Image = "user",
                                Description = "VIP kişilerin güvenliği için özel olarak tasarlanmıştır. VIP müşterilerimizin özel bilgilerini güvende tutarak, online ve offline tehditlere karşı güvenliklerini sağlamaktayız.",
                            },
                            new homeOzellikItem
                            {
                                Title = "Active Directory",
                                Image = "sitemap",
                                Description = "İşletmelerin Active Directory ortamlarındaki güvenlik açıklarını ve riskleri tespit etmek için tasarlanmıştır.",
                            },
                            new homeOzellikItem
                            {
                                Title = "AttackFlow",
                                Image = "code",
                                Description = "AttackFlow, yazılım geliştiricilerin projelerindeki güvenlik açıklarını hızla tespit edip düzeltmelerine yardımcı olan bir araçtır. Entegre yapısı sayesinde geliştiricilere anlık analiz ve etkili düzeltme imkanı sunarak yazılım projelerinin güvenliğini artırır.",
                            },
                        }
                    },
                }
            };

            return View(homeProductModel);
        }
    }
}
