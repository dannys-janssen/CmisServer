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

			// Add application services

			// initialize local application services from configuration
			var cmisConfigSection = Configuration.GetSection("Cmis");
            var connectorClassString = cmisConfigSection != null ? cmisConfigSection.GetValue<string>(Constants.ConnectorClassSetting) : Constants.MockupConnectorClass;
            var connectorType = !string.IsNullOrWhiteSpace(connectorClassString) ? Type.GetType(connectorClassString) : Type.GetType(Constants.MockupConnectorClass);

			if (connectorType != null)
            {
                // add connector from configuration
                services.AddSingleton(typeof(ICmisConnector), connectorType);
			}
            else
            {
                // Fallback, when no connector
                services.AddSingleton(typeof(ICmisConnector), typeof(CmisMockupConnector));
            }

            var repositoryServiceClassString = cmisConfigSection != null ? cmisConfigSection.GetValue<string>(Constants.RepositoryServiceSetting) : Constants.DefaultRepositoryServiceClass;
			var repositoryServiceType = !string.IsNullOrWhiteSpace(repositoryServiceClassString) ? Type.GetType(repositoryServiceClassString) : Type.GetType(Constants.DefaultRepositoryServiceClass);

			if (repositoryServiceType != null)
			{
				// add repository service from configuration
				services.AddSingleton(typeof(ICmisRepositoryService), repositoryServiceType);
			}
			else
			{
				// Fallback, when no repository service
                services.AddSingleton(typeof(ICmisRepositoryService), typeof(CmisRepositoryService));
			}

		}


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));

            if (env.IsDevelopment())
                loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
