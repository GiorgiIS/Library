using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NJsonSchema;
using NSwag.AspNetCore;
using Library.Application;
using Library.Repository.EF;
using Library.Repository.Implementations;
using Library.Repository.Interfaces;
using AutoMapper;
using Library.Common.Api;
using Library.Interfaces.Services;
using Library.Services;
using Microsoft.AspNetCore.Http;

namespace Library.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var connectionString = Configuration["ConnectionStrings:Default"];
            services.AddDbContext<LibraryDbContext>(options => options.UseSqlServer(connectionString));

            var assemblies = typeof(AutomapperProfile).Assembly;
            services.AddAutoMapper(assemblies);

            services.RegisterServicesAndRepositorys();

            services.AddOpenApiDocument(); // add OpenAPI v3 document
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(appBuilder =>
                {
                    appBuilder.Run(async context => {
                        context.Response.StatusCode = 500;
                        await context.Response.WriteAsync("Unexpected error occured. Please try again later.");
                    });
                });

                //app.UseHsts();
            }

            //app.UseHttpsRedirection();

            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseReDoc();

            app.UseMvc();
        }
    }
}
