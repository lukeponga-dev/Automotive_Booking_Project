using System;
using Automotive_Booking_Project.Areas.Identity.Data;
using Automotive_Booking_Project.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Automotive_Booking_Project.Areas.Identity.IdentityHostingStartup))]
namespace Automotive_Booking_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Automotive_Booking_IdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Automotive_Booking_IdentityDbContextConnection")));

                services.AddDefaultIdentity<Automotive_Booking_ProjectUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Automotive_Booking_IdentityDbContext>();
            });
        }
    }
}