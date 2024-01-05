using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.ViewComponents
{
    [ViewComponent(Name = "Footer")]
    public class FooterComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;

        public FooterComponent(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new List<FooterViewModel>
            {
                new FooterViewModel
                {
                    Contactaddresstitle = "İletişim Adresi",
                    addresstitle = "DERİNTECH BİLİŞİM TİC. LTD. ŞTİ.",
                    address = "2224. Cad. No:1 TeknoPark Ankara <br> Yenimahalle / ANKARA",
                    phone = "0 (554) 416 62 62",
                    email = "av_mehmetsari@hotmail.com",
                    fasttravel = "Hızlı Erişim Ekranı",
                    about = "Hakkımızda",
                    Portfolio = "Portfolio",
                    concat = "İletişim",
                    missiontitle = "Misyon ve Vizyonumuz",
                    mission = "Misyon ve Vizyonumuz"
                }
            };

            return View(model);
        }
    }
}
