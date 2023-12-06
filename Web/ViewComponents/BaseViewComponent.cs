using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Web.ViewComponents;

public abstract class BaseViewComponent : ViewComponent
{
    public readonly IConfiguration Configuration;

    protected BaseViewComponent(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public string GetToken()
    {
        return HttpContext.Session.GetString("SeedToken").ToString();
    }
    public string GetSession()
    {
        if (string.IsNullOrEmpty(HttpContext.Session.GetString("SeedSession")))
        {
            HttpContext.Session.SetString("SeedSession", HttpContext.Session.Id);
        }
        return HttpContext.Session.GetString("SeedSession");
    }
    public void SetSession()
    {
        HttpContext.Session.SetString("SeedSession", HttpContext.Session.Id);
    }
    public string CreateDirectory(string path)
    {
        string result;
        try
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            result = path;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return result;
    }
    public List<string> UploadFiles(IFormFileCollection? fileList, string path)
    {
        var result = new List<string>();
        if (fileList == null) return result;
        foreach (var postedFile in fileList)
        {
            var fileName = Path.GetFileName(postedFile.FileName);
            using var stream = new FileStream(Path.Combine(path, fileName), FileMode.Create);
            postedFile.CopyTo(stream);
            result.Add(fileName);
        }
        return result;
    }
    public string GetApiBaseUrl()
    {
        return Configuration.GetSection("BaseSettings")?["ApiBaseUrl"];
    }
    public string GetLogo()
    {
        return Configuration.GetSection("BaseSettings")?["LogoUrl"];
    }
}