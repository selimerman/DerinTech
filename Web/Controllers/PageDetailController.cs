using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class PageDetailController : Controller
    {
        private readonly ILogger<PageDetailController> _logger;

        public PageDetailController(ILogger<PageDetailController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)
        {
            if (id == null || id == 0 || id == 1)
            {
                var pageModel = new PageViewModel
                {
                    PageItems = new List<PageItem>
                    {
                        new PageItem
                        {
                            PageTitle = "Sizin İçin Buradayız",
                            Description =
                                "<p>Derintech Bilişim, siber güvenlik alanında sunduğu ürünlerle işinizi en üst düzeye çıkarmanıza yardımcı olur. Güvenliğinizi sağlamak, siber tehditlere karşı korunmak için özel olarak tasarlanmış yerli yazılımlar ve çözümlerimizle tanışınmanızı sağlar.Derintech Bilişim ile siber güvenlik önlemlerinizde güçlü bir adım atın, iş süreçlerinizi koruyun ve online dünyada güvenle faaliyet gösterin.</p>\n                        <p>Hemen iletişime geçin, siber güvenlikle güçlendirilmiş iş çözümlerimizle işinizi büyütmenin avantajlarına birlikte adım atalım!</p>"
                        },
                        new PageItem
                        {
                            PageTitle = "Neden Bizi Tercih Etmelisiniz?",
                            Description =
                                " <p>Derintech Bilişim olarak, siber güvenliğinizi en üst düzeye çıkaran çözümlerle işinizi güçlendiriyoruz. Öncü teknoloji ve güvenlik yazılımları ile iş süreçlerinizi optimize ediyoruz.Siz değerleri müşterilerimizde bizleri tercih ederek işletmenizi dijital dünyada siber tehditlere karşı güvende tutun, dijital dönüşümle tanışın öne çıkın. Hemen iletişime geçin, siber güvenlikle güçlendirilmiş iş çözümlerimizle işinizi büyütmenin avantajlarına birlikte adım atalım!.</p>\n <p>Hemen iletişime geçin, siber güvenlikle güçlendirilmiş iş çözümlerimizle işinizi büyütmenin avantajlarına birlikte adım atalım!.</p>",
                           },
                        new PageItem
                        {
                            PageTitle = "Bizim Çözümlerimiz",
                            PageProperties = new List<PageProperty>
                            {
                                new PageProperty
                                {
                                    PropertyTitle = "Siber Güvenlik",
                                    PropertyDescription =
                                        "Değerli iş ortaklarımızın geliştirmiş olduğu yerli ve milli yazılımlar ile dijital dünyada güvende kalın"
                                },
                                new PageProperty
                                {
                                    PropertyTitle = "Performans Artırma",
                                    PropertyDescription =
                                        " Değerli iş ortaklarımızın geliştirmiş olduğu yerli ve milli yazılımlar ile dijital dünyada güvende kalın"
                                },
                                new PageProperty
                                {
                                    PropertyTitle = "Marka Koruma",
                                    PropertyDescription =
                                        "Değerli iş ortaklarımızın geliştirmiş olduğu yerli ve milli yazılımlar ile dijital dünyada güvende kalın"
                                },
                                new PageProperty
                                {
                                    PropertyTitle = "Sürekli Sızma Testi ve Sürekli İzleme",
                                    PropertyDescription =
                                        " Değerli iş ortaklarımızın geliştirmiş olduğu yerli ve milli yazılımlar ile dijital dünyada güvende kalın"
                                }
                            }
                        },
                        new PageItem
                        {
                            PageTitle = "Uzmanlık Alanlarımız",
                            Description = "",
                            PageProperties = new List<PageProperty>
                            {
                                new PageProperty
                                {
                                    PropertyTitle = "Siber Güvenlik",
                                    PropertyColor = "green",
                                    PropertyValue = 40
                                },
                                new PageProperty
                                {
                                    PropertyTitle = "Marka Koruma",
                                    PropertyColor = "red",
                                    PropertyValue = 50
                                },
                                new PageProperty
                                {
                                    PropertyTitle = "Servis Bakım",
                                    PropertyColor = "blue",
                                    PropertyValue = 60
                                },
                                new PageProperty
                                {
                                    PropertyTitle = "Sürekli Sızma Testi",
                                    PropertyValue = 70,
                                    PropertyColor = "orange"
                                }
                            }
                        }
                    }
                };
                return View(pageModel);
            }
            else if (id == 2)
            {

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}