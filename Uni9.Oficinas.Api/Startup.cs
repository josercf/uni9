using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Uni9.Oficinas.Data.Organization;
using Uni9.Oficinas.Domain.Organization.Repositories;

namespace Uni9.Oficinas.Api
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
            var connectionString = "mongodb://localhost:27017";
            var dbName = "appUni9";
            services.AddMvc();

            services.AddTransient<ISubsidiaryRepository, SubsidiaryRepository>(c =>
           {
               return new SubsidiaryRepository(connectionString, dbName, "organization");
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
