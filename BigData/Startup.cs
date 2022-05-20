using AutoMapper;
using BigData.Domain.DTos;
using BigData.Domain.Entities;
using BigData.Domain.Interfaces;
using BigData.Repository.Context;
using BigData.Repository.Repositories;
using BigData.Service.Interfaces;
using BigData.Service.Mappers;
using BigData.Service.Services;
using BigData.Service.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BigData
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

            services.AddControllers().AddFluentValidation(); 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BigData", Version = "v1" });
            });
            services.AddApiVersioning(setup =>
            {
                setup.DefaultApiVersion = new ApiVersion(1, 0);
                setup.AssumeDefaultVersionWhenUnspecified = true;
                setup.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(setup =>
            {
                setup.GroupNameFormat = "'v'VVV";
                setup.SubstituteApiVersionInUrl = true;
            });

            #region DI

            services.AddDbContext<BigDataContext>(options => options.UseNpgsql(Configuration.GetValue<string>("ConnectionStrings:BigData")));

            #region DI Service

            services.AddScoped<IPessoaService, PessoaService>();

            #endregion

            #region DI Repository

            services.AddScoped<IPessoaRepository, PessoaRepository>();

            #endregion

            #region DI Validators

            services.AddTransient<IValidator<PessoaDto>, PessoaValidator>();

            #endregion

            #region AutoMappers

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PessoaDto, Pessoa>();
                cfg.AddProfile<PessoaMapper>();
            });
            services.AddSingleton(configuration.CreateMapper());
            //var mapper = configuration.CreateMapper();

            #endregion

            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BigData v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
