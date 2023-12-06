using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents;

[ViewComponent(Name = "WhoWeAre")]
public class WhoWeAreComponent : BaseViewComponent
{
    public new readonly IConfiguration Configuration;

    public WhoWeAreComponent(IConfiguration configuration) : base(configuration)
    {
        Configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.FromResult<IViewComponentResult>(View());
    }
}