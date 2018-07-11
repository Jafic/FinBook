﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MediatR;
using Project.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Project.API.Application.Service;
using Project.API.Application.Queries;

namespace Project.API
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

            services.AddDbContext<ProjectContext>(options =>
                {
                    options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")
                    //, builder=>
                    //builder.MigrationsAssembly(typeof(ProjectContext).Assembly.GetName().Name)
                    ,b => b.MigrationsAssembly(typeof(Startup).Assembly.GetName().Name)
                    
                    );
                }
            );

            services.AddScoped<IRecommendService, RecommendService>()
                .AddScoped<IProjectQueries, ProjectQueries>();

            //AddMediatR 其实是在 Microsoft.Extension.DependencyInjection.MediatR中，但是是对 IServiceCollection services的扩展，所以需要引入 Microsoft.Extension.DependencyInjection.MediatR
            services.AddMediatR();
            services.AddMvc();
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
