using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using SwaggerDemo.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace SwaggerDemo
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
	        services.AddDbContext<TodoContext>(opt =>
		        opt.UseInMemoryDatabase("TodoList"));
            services.AddCors(
                options => options.AddPolicy(
                    "AllowAll", 
                    builder => builder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin()
                        .AllowCredentials()));
			services.AddMvc();

	        services.AddSwaggerGen(c =>
	        {
		        c.SwaggerDoc("v1", new Info { Title = "Todo API", Version = "v1" });

		          c.IncludeXmlComments(System.String.Format(@"{0}\SwaggerDemo.xml",
			          System.AppDomain.CurrentDomain.BaseDirectory));

				c.DescribeAllEnumsAsStrings();
			});
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowAll");
            app.UseMvc();
	        app.UseStaticFiles();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");

			});
			app.UseSwagger();
		}
    }
}
