//
// Startup.cs
//
// Author:
//       Dannys Janssen
//
// Copyright (c) 2017 Dannys Janssen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace Cmis.Service
{
    using System;
	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Logging;
	using Cmis.Infrastructure;
	using Cmis.Interface;

    /// <summary>
    /// Startup class for CMIS Web API service.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Cmis.Service.Startup"/> class.
        /// </summary>
        /// <param name="env">Hosting environment.</param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            // initialize local application services from configuration
            var cmisConfigSection = Configuration.GetSection("Cmis");
            var configurationStoreTypeString = cmisConfigSection != null ? cmisConfigSection.GetValue<string>("ConfigurationStoreClass") : "Cmis.Interface.CmisMockupConnector, CmisInterface";
            var configurationStoreType = !string.IsNullOrWhiteSpace(configurationStoreTypeString) ? Type.GetType(configurationStoreTypeString) : Type.GetType("Cmis.Interface.CmisMockupConnector, CmisInterface");

			// Add application services
			if (configurationStoreType != null)
            {
                services.AddSingleton(typeof(ICmisConnector), configurationStoreType);
			}
            else
            {
                // Fallback, when no configuration store 
                services.AddSingleton(typeof(ICmisConnector), typeof(CmisMockupConnector));
            }
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
#pragma warning disable RECS0154 // Parameter is never used
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
#pragma warning restore RECS0154 // Parameter is never used
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
