using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace SocialOffice;

public class SocialOfficeWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<SocialOfficeWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
