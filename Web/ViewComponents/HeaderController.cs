using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents;

[ViewComponent(Name = "Header")]
public class HeaderComponent : BaseViewComponent
{
    public new readonly IConfiguration Configuration;

    public HeaderComponent(IConfiguration configuration) : base(configuration)
    {
        Configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.FromResult<IViewComponentResult>(View());
    }
}