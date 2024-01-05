using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;
using static Web.Models.ProductViewModel;

namespace Web.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly ILogger<ProductDetailController> _logger;

        public ProductDetailController(ILogger<ProductDetailController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int productId)
        {
            var model = new ProductLst();
            {

                model.PageTitle = "İş Ortaklarımız";
                model.Products = new List<Product>();
            };
           
            model.Products.Add(new Product
            {
                Id = 1,
                Description = "TR7 APPLICATIONAPPLICATION SECURITY PLATFORM",
                PageName = "TR7Page",
                ImageUrl = "/img/works/tr7logo.jpg",
                Category = "Siber Güvenlik",
                CategoryTag = "Siber",
                Detay = "TR7, güçlü donanım, esnek sanal cihaz ve üyelik sistemi (subscription) ile üç ana başlık altında kapsamlı bir çözüm sunar. Donanım çözümü, yüksek performans ve ölçeklenebilirlik vadederken, sanal cihaz çözümü bulut ortamlarında ideal bir çözüm sunar. Üyelik sistemi çözümü ise işletmelerin ihtiyaçlarına göre ölçeklenebilir ve uygun maliyetli bir çözüm sunmaktadır.\n\n TR7, web uygulamalarını SQL injection, XSS, DDoS saldırıları gibi çeşitli siber tehditlere karşı etkili bir koruma sağlamaktadır. Aynı zamanda, web uygulamalarının performansını artırarak kullanılabilirliği en üst düzeye çıkarmaktadır.\n\n     Türkiye'nin siber güvenlik alanındaki önemli gelişmelerinden biri olan TR7, yerli ve milli bir çözüm olmasıyla Türkiye'nin siber güvenlik konusundaki dışa bağımlılığını azaltmaya katkı sağlamaktadır. Türkiye genelinde ve yurt dışında birçok kurum tarafından tercih edilen TR7, siber güvenlik alanında güvenilir bir çözüm sunmaktadır. Web sitenizi TR7 ile tanıştırın ve güvenlikte yeni bir döneme adım atın!",
                
                Ozellikleri = new List<OzellikItem> {
                    new OzellikItem
                {
                    Title = "Milli Teknoloji",
                    Image = "code",
                    Description = "TR7, Türkiye'nin siber güvenlik alanında önemli bir gelişmedir. Yerli ve milli bir çözüm olması, Türkiye'nin siber güvenlik alanındaki dışa bağımlılığını azaltacaktır."
                },
                    new OzellikItem
                {
                    Title = "Yüksek Performans",
                    Image = "plus",
                    Description = "TR7 siz değerli müşterilerimize yüksek performans ve ölçeklenebilirlik hizmeti sunar."
                },
                    new OzellikItem
                {
                    Title = "Saldırılara Karşı Koruma",
                    Image = "shield",
                    Description = "Dijital dünyada karşı karşıya kalabileceğiniz tüm çeşitli saldırılara karşı koruma sağlar."
                },
                    new OzellikItem
                {
                    Title = "Performans Artışı",
                    Image = "magic",
                    Description = "Web uygulamalarının performansını ve kullanılabilirliğini artırır."
                } }




            });
           
            model.Products.Add(new Product
            {
                Id = 2,
                Description= "AttackFlow",
                PageName = "AtackFlowPage",
                ImageUrl = "/img/works/atack.jpg",
                Category = "Siber Güvenlik",
                CategoryTag = "Siber",
                Detay = " AttackFlow, yazılım geliştiricilerin yazılımlarında potansiyel güvenlik açıklarını tespit etmelerine yardımcı olmak için tasarlanmış bir araçtır. AttackFlow, yazılım geliştirme sürecine entegre olarak çalışır ve geliştiricilere, kodunu gerçek zamanlı olarak analiz etme ve güvenlik açıklarını düzeltme olanağı sunar.AttackFlow, yazılım geliştiricilerin yazılım güvenliklerini geliştirmelerine yardımcı olmak için önemli bir araçtır. AttackFlow, yazılım geliştirme sürecine entegre olarak kullanılarak, geliştiricilerin güvenlik açıklarını daha erken tespit etmelerine ve düzeltmelerine yardımcı olur. Bu, yazılımların güvenliğini artırmaya ve siber saldırılara karşı korunmasına yardımcı olur.",

                 Ozellikleri = new List<OzellikItem> {
                    new OzellikItem
                {
                    Title = "Gerçek Zamanlı Analiz",
                    Image = "check",
                    Description = "AttackFlow, kodunu gerçek zamanlı olarak analiz eder ve güvenlik açıklarını geliştiricinin önüne getirir. Bu, geliştiricilerin güvenlik açıklarını erken tespit etmelerine ve düzeltmelerine yardımcı olur."
                },
                    new OzellikItem
                {
                    Title = "Kolay Kullanım",
                    Image = "smile-o",
                    Description = "AttackFlow, kullanımı kolay bir ara yüze sahiptir. Bu, geliştiricilerin AttackFlow'u kullanmayı öğrenmelerini ve kullanmaya başlamalarını kolaylaştırır."
                },
                    new OzellikItem
                {
                    Title = "Saldırılara Karşı Koruma",
                    Image = "shield",
                    Description = "Dijital dünyada karşı karşıya kalabileceğiniz tüm çeşitli saldırılara karşı koruma sağlar."
                },
                    new OzellikItem
                {
                    Title = "Geniş Kapsam",
                    Image = "magic",
                    Description = "AttackFlow, çeşitli güvenlik açıklarını tespit edebilir. Bu, geliştiricilerin yazılımlarının güvenliğini artırmalarına yardımcı olur."
                } }
            });



            model.Products.Add(new Product
            {
                Id = 3,
                Description = "Forestall Active Directory Security Assessment",
                PageName = "ForestallPage",
                ImageUrl = "/img/works/forestall.jpg",
                Category = "Active Directory",
                CategoryTag = "ActiveDirectory",
                Detay = "Forestall Active Directory Security Assessment Forestall Bilişim Arge ve Danışmanlık Hizmetleri tarafından geliştirilmiş bir Active Directory güvenlik değerlendirme hizmetidir. Active Directory Security Assessment, işletmelerin Active Directory ortamlarındaki güvenlik açıklarını ve riskleri tespit etmek için tasarlanmıştır. Active Directory Security Assessment, işletmelerin Active Directory güvenliklerini iyileştirmelerine yardımcı olmak için önemli bir araçtır. Active Directory Security; güvenlik açıklarını tespit etmek ve düzeltmek. Riskleri azaltmak uyumluluk gereksinimlerini karşılamak için kullanılır.",
                
                Ozellikleri = new List<OzellikItem> {
                    new OzellikItem
                {
                    Title = "Gerçek Zamanlı Analiz",
                    Image = "check",
                    Description = "AttackFlow, kodunu gerçek zamanlı olarak analiz eder ve güvenlik açıklarını geliştiricinin önüne getirir. Bu, geliştiricilerin güvenlik açıklarını erken tespit etmelerine ve düzeltmelerine yardımcı olur."
                },
                    new OzellikItem
                {
                    Title = "Kolay Kullanım",
                    Image = "smile-o",
                    Description = "AttackFlow, kullanımı kolay bir ara yüze sahiptir. Bu, geliştiricilerin AttackFlow'u kullanmayı öğrenmelerini ve kullanmaya başlamalarını kolaylaştırır."
                },
                    new OzellikItem
                {
                    Title = "Saldırılara Karşı Koruma",
                    Image = "shield",
                    Description = "Dijital dünyada karşı karşıya kalabileceğiniz tüm çeşitli saldırılara karşı koruma sağlar."
                },
                    new OzellikItem
                {
                    Title = "Geniş Kapsam",
                    Image = "magic",
                    Description = "AttackFlow, çeşitli güvenlik açıklarını tespit edebilir. Bu, geliştiricilerin yazılımlarının güvenliğini artırmalarına yardımcı olur."
                } }

            });

            model.Products.Add(new Product
            {
                Id = 4,
                PageName = "BrandefansePage",
                Description = "Brandefense",
                ImageUrl = "/img/works/brand.jpg",
                Category = "Koruma",
                CategoryTag = "Koruma",
                Detay = "Brandefense, işletmelerin siber güvenlik ihtiyaçlarını karşılamak için tasarlanmış, tam kapsamlı bir çözümdür. İşletmeler için kritik öneme sahip olan siber güvenlik konusunda Brandefense, sunduğu çeşitli özelliklerle işletmelerin güvenlik stratejilerini güçlendirmelerine yardımcı olmaktadır.\n                    Siber tehditlere karşı koruma sağlamak, işletmelerin dijital varlıklarını güvende tutmada kritik bir rol oynar. Brandefense, güçlü bir savunma mekanizması ile işletmelerin siber saldırılara karşı direncini artırır.\n                    Marka koruması, işletmelerin itibarını ve müşteri güvenini sürdürmeleri açısından önemlidir. Brandefense, marka itibarını koruma ve marka itibarıyla ilgili siber tehditleri önleme konusunda etkili bir çözüm sunar.\n                    Güvenlik açıklarının tespiti ve düzeltilmesi, işletmelerin siber saldırılara karşı daha dirençli hale gelmelerini sağlar. Brandefense, sistematik bir şekilde güvenlik açıklarını belirler ve bu açıkları kapatma sürecini kolaylaştırır.\n                    Risk azaltma, işletmelerin siber güvenlik stratejilerini oluştururken dikkate almaları gereken önemli bir faktördür. Brandefense, işletmelerin maruz kaldığı riskleri analiz eder ve etkili önlemler alarak bu riskleri minimize etmeye yardımcı olur.\n                    Uyumluluk gereksinimlerini karşılamak, özellikle regülasyonlara ve standartlara uymak isteyen işletmeler için kritiktir. Brandefense, çeşitli uyumluluk gereksinimlerini karşılamak için tasarlanmış ve bu alanda işletmelere destek sağlamaktadır.\n                    Brandefense, işletmelerin siber güvenlik konusundaki karmaşık ihtiyaçlarını karşılamak için güvenilir, yenilikçi ve ölçeklenebilir bir çözümdür. Güçlü özellikleri ve kullanıcı dostu arayüzü ile Brandefense, işletmelerin siber güvenlik stratejilerini güçlendirmelerine yardımcı olur.",

                Ozellikleri = new List<OzellikItem> {
                    new OzellikItem
                {
                    Title = "Tehdit İstihbaratı",
                    Image = "exclamation-triangle",
                    Description = "Brandefense, işletmelerin siber tehditlere karşı korunmasına yardımcı olmak için tehdit istihbaratı verileri sunmaktadır. Bu veriler, işletmelerin olası tehditleri önceden tespit etmelerine ve buna göre önlem almalarına yardımcı olmaktadır."
                },
                    new OzellikItem
                {
                    Title = "Sürekli Sızma Testi ve Sürekli İzleme",
                    Image = "eye",
                    Description = "Brandefense, işletmelere sürekli sızma testi hizmetleriyle güvenlik açıklarını tespit etme ve sürekli izleme hizmetleriyle ağlarını ve sistemlerini şüpheli aktiviteler açısından izleme imkanı sunmaktadır."
                },
                    new OzellikItem
                {
                    Title = "Marka Koruma",
                    Image = "shield",
                    Description = "Brandefense, işletmelerin markalarını korumalarına yardımcı olmak için marka koruma hizmetleri sunmaktadır. Bu hizmetler, işletmelerin markalarının internet ortamında kullanılmasını izlemelerine, markalarını ihlal eden içerikleri tespit etmelerine ve buna göre önlem almalarına yardımcı olmaktadır."
                },
                    new OzellikItem
                {
                    Title = "VIP Koruma",
                    Image = "user",
                    Description = "Brandefense, VIP kişilerin güvenliğini korumak için VIP koruma hizmetleri sunmaktadır. Bu hizmetler, VIP kişilerin kişisel bilgilerinin ve verilerinin korunmasına yardımcı olmaktadır."
                } }


            });
            var item = model.Products.FirstOrDefault(c => c.Id == productId);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}