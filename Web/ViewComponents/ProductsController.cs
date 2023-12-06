using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents;

[ViewComponent(Name = "Products")]
public class ProductsComponent : BaseViewComponent
{
    public new readonly IConfiguration Configuration;

    public ProductsComponent(IConfiguration configuration) : base(configuration)
    {
        Configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.FromResult<IViewComponentResult>(View());
    }
}