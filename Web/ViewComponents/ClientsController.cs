using Microsoft.AspNetCore.Mvc;

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
        return await Task.FromResult<IViewComponentResult>(View());
    }
}