using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Zee.AspNetCore.AdminLTE3.Web.Areas.Identity.IdentityHostingStartup))]
namespace Zee.AspNetCore.AdminLTE3.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}