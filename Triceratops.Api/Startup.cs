using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;
using Triceratops.Api.Models.ActionFilters;
using Triceratops.Api.Services.DbService;
using Triceratops.Api.Services.DbService.Interfaces;
using Triceratops.Api.Services.ServerService;
using Triceratops.Api.WebSockets;
using Triceratops.DockerService;
using Triceratops.Libraries.Helpers;

namespace Triceratops.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
            
            services
                .AddControllersWithViews(o =>
                {
                    o.Filters.Add(new TimedRequestAttribute());
                })
                .AddJsonOptions(o => JsonHelper.UpdateSerialiserOptions(o.JsonSerializerOptions));

            ConfigureDocker(services);

            services.AddSingleton(s => DbServiceFactory.CreateFromEnvironmentVariables());
            services.AddSingleton(s => s.GetRequiredService<IDbService>().Servers);
            services.AddSingleton(s => s.GetRequiredService<IDbService>().Containers);

            services.AddSingleton<IServerService>(s => new ServerService(
                s.GetRequiredService<IDbService>(),
                s.GetRequiredService<ITriceratopsDockerClient>()
            ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapHub<ApiHub>("/ws-api");

                endpoints.MapFallback(context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;

                    return Task.CompletedTask;
                });
            });
        }

        private void ConfigureDocker(IServiceCollection services)
        {
            var dockerDaemonUrl = Environment.GetEnvironmentVariable("DOCKER_DAEMON_URL");

            if (string.IsNullOrWhiteSpace(dockerDaemonUrl))
            {
                throw new Exception($"The environment variable DOCKER_DAEMON_URL must be set for Triceratops to run!");
            }

            services.AddSingleton<ITriceratopsDockerClient>(s => new TriceratopsDockerClient(
                new Uri(dockerDaemonUrl),
                s.GetRequiredService<ILoggerFactory>()
            ));
        }
    }
}
