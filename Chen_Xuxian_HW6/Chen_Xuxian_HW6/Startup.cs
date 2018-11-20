using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chen_Xuxian_HW6.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Chen_Xuxian_HW6
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Server=tcp:fa18chenxuxianhw6.database.windows.net,1433;Initial Catalog=fa18ChenXuxianHW6;Persist Security Info=False;User ID=fa18ChenXuxianHW6;Password=123qweASD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                  name: "default",
                  template: "{controller}/{action}/{id?}",
                  defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
