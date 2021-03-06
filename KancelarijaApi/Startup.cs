﻿using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using KancelarijaApi.Attributes;
using KancelarijaApi.Interfaces;
using KancelarijaApi.Models;
using KancelarijaApi.Repositories;
using KancelarijaApi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using RrepTest.MyAttributes;
using Swashbuckle.AspNetCore.Swagger;

namespace KancelarijaApi
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

           

            services.AddDbContext<KancelarijApiContext>(options => options.UseSqlServer(Configuration["ConnectionString:KancelarijaApiDB"]));
            services.AddAutoMapper();
            services.AddFiltersService();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                Path.Combine(AppContext.BaseDirectory, xmlFile);
                //   c.IncludeXmlComments(xmlPath);
            });

            services.AddDI();

            //services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            //services.AddScoped<IKancelarijaRepository, KancelarijaRepository>();
            //services.AddScoped<IOsobaRepository, OsobaRepository>();
            //services.AddScoped<IUredjajRepository, UredjajRepository>();
            //services.AddScoped<IOsobaUredjajRepository, OsobaUredjajRepository>();

           


            //add UnitOfWork
            services.AddScoped<IUnitOfWork,UnitOfWork>();

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
