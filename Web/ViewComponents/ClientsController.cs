using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.ViewComponents;

[ViewComponent(Name = "Clients")]
public class ClientsComponent : BaseViewComponent
{
    public new readonly IConfiguration Configuration;

    public ClientsComponent(IConfiguration configuration) : base(configuration)
    {
        Configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = new List<ClientViewModel>
            {
                new ClientViewModel
                {
                    PageTitle = "- Elon Musk -",
                    Description = "'Gelişim ve büyüme, iş dünyasında rekabet avantajını sürdürmenin anahtarıdır.'",

                },

                 new ClientViewModel
                {
                    PageTitle = "- Sheryl Sandberg -",
                    Description = "'İşini büyütmek için öğrenmeye ve değişime açık ol. Çünkü değişim, büyümenin anahtarıdır.'",

                },

                  new ClientViewModel
                {
                    PageTitle = "- Jack Welch -",
                    Description = "'Başarı, bir işin sürekli olarak gelişmesi ve değişmesiyle mümkündür.'",

                },

                    new ClientViewModel
                {
                    PageTitle = "- Oprah Winfrey -",
                    Description = "'Başarılı olmak için işini büyüt, ancak başkalarının hayatına dokunarak gerçek başarıya ulaşabilirsin.'",

                },


            };

        return View(model);
    }
}