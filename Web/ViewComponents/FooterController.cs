using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents;

[ViewComponent(Name = "Footer")]
public class FooterComponent : BaseViewComponent
{
    public new readonly IConfiguration Configuration;

    public FooterComponent(IConfiguration configuration) : base(configuration)
    {
        Configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.FromResult<IViewComponentResult>(View());
    }
}