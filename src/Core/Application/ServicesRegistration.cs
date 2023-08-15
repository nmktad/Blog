using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Blog.Application;

public static class ApplicationServicesRegistration {
    public static void ConfigureApplicationServices(this IServiceCollection services) {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
