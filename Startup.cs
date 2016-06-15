using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
  public Startup(IHostingEnvironment env) {
    var builder = new ConfigurationBuilder();
    Configuration = builder.Build();
  }

  public IConfigurationRoot Configuration { get; }

  public void ConfigureServices(IServiceCollection services) {
    services.AddMvc();
  }

  public void Configure(IApplicationBuilder app) {
    app.UseMvc();
  }
}