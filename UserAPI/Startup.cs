using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using MassTransit.Util;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Steeltoe.Discovery.Client;
using Steeltoe.Discovery.Eureka;

namespace UserAPI
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
            services.AddControllers();
            //discovery
            services.AddDiscoveryClient(Configuration);
            services.AddMemoryCache();
            services.AddHealthChecks();
            services.AddSingleton<IHealthCheckHandler, ScopedEurekaHealthCheckHandler>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            //authentication
            services.AddAuthentication("Bearer")
             .AddJwtBearer("Bearer", options =>
             {
                 options.Authority = "https://localhost:44350";
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateAudience = false
                 };
             });

            

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                                   builder => builder.SetIsOriginAllowed(hostName => true)
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials()
                                  );
            });

            //communication pattern
            //services.AddMassTransit(x =>
            //{
            //    x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config =>
            //    {
            //        config.UseHealthCheck(provider);
            //        config.Host(new Uri($"rabbitmq://{Configuration["RabbitMQHostName"]}"), h =>
            //        {
            //            h.Username("guest");
            //            h.Password("guest");
            //        });
            //    }));
            //});
            //services.AddMassTransitHostedService();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, Microsoft.AspNetCore.Hosting.IApplicationLifetime lifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseDiscoveryClient();
            //app.UseMvc();
            app.UseHealthChecks("/info");

            //communication
            //var bus = app.ApplicationServices.GetService<IBusControl>();
            //var busHandle = TaskUtil.Await(() =>
            //{
            //    return bus.StartAsync();
            //});
            //lifetime.ApplicationStopping.Register(() =>
            //{
            //    busHandle.Stop();
            //});

        }
    }
}
