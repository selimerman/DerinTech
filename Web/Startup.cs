using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.ResponseCompression;
using System.Globalization;
using System.IO.Compression;
using System.Text;
using Microsoft.Extensions.Options;

namespace Web
{
    public class Startup
    {
        public static string? WebRootPath { get; private set; }

        public static string? ImageFormat = "png";

        private IHostEnvironment? HostEnvironment { get; set; }

        public Startup(IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            Configuration = configuration;
            HostEnvironment = hostEnvironment;
            WebRootPath = HostEnvironment.ContentRootPath;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddSession(options =>
            {
                options.Cookie.Name = "WebSession";
                options.IdleTimeout = TimeSpan.FromHours(6);
                options.Cookie.IsEssential = true;
            });

            
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("tr-TR")
                };
                options.DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            
            services.AddMemoryCache();
            services.AddDistributedMemoryCache();
            services.AddMvc().AddSessionStateTempDataProvider();
            

            services.AddDistributedMemoryCache();

            var secretKey = Encoding.ASCII.GetBytes("ES3ErD7en0ES3ErD7890ES3ErD7en0EE3ES3ErD7en0ES3ErD7890ES3ErD7en0EE3");


            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/login";
                options.LogoutPath = "/logout";
                options.AccessDeniedPath = "/unauthorized";
            });

            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Optimal);

            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.Providers.Add<BrotliCompressionProvider>();
                options.EnableForHttps = true;
            });

            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.SmallestSize;
            });

            services.Configure<BrotliCompressionProvider>(options =>
            {

            });
            
            services.AddDataProtection()
            .UseCryptographicAlgorithms(
                new AuthenticatedEncryptorConfiguration()
                {
                    EncryptionAlgorithm = EncryptionAlgorithm.AES_256_CBC,
                    ValidationAlgorithm = ValidationAlgorithm.HMACSHA256
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDefaultFiles();

            app.UseSession();

            app.Use(async (context, next) =>
            {
                List<string> extentions = new List<string>() { ".js", ".css", ".png", ".webp", ".jpg", ".ico", "gif" };
                string path = context.Request.Path;
                foreach (var item in extentions)
                {
                    if (path.EndsWith(item))
                    {
                        TimeSpan maxAge = new TimeSpan(7, 0, 0, 0);
                        context.Response.Headers.Append("Cache-Control", "max-age=" + maxAge.TotalSeconds.ToString("0"));
                    }
                    else
                    {
                        context.Response.Headers.Append("Cache-Control", "no-cache");
                        context.Response.Headers.Append("Cache-Control", "private, no-store");
                    }
                }
                await next();
            });


            app.UseResponseCompression();
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.Use(async (context, next) =>
            {
                var jwToken = context.Session.GetString("JWToken");
                if (!string.IsNullOrEmpty(jwToken))
                {
                    context.Request.Headers.Add("Authorization", "Bearer " + jwToken);
                }
                await next();
            });
            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                
                endpoints.MapControllerRoute(name: "seo", pattern: "{controller}-{action}");
                endpoints.MapControllerRoute(name: "seo", pattern: "{controller}-{action}-{id}");
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "areadefaultroute", pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "arearoute", pattern: "{area:exists}/{controller=exists}/{action=exists}/{id?}");
                endpoints.MapControllerRoute(name: "PageNotFound", pattern: "PageNotFound", defaults: new { area = "", controller = "Error", action = "PageNotFound" });
                endpoints.MapFallback(context =>
                {
                    context.Response.Redirect("/PageNotFound");
                    return Task.CompletedTask;
                });
            });

            WebRootPath = HostEnvironment.ContentRootPath;

        }

        public static string MapPath(string path, string basePath = null)
        {
            if (string.IsNullOrEmpty(basePath))
            {
                basePath = WebRootPath;
            }
            path = path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
            return Path.Combine(basePath, path);
        }
    }
}