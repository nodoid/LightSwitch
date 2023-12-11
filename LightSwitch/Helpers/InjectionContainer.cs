using CommunityToolkit.Mvvm.Messaging;
using LightSwitch.Interfaces;
using LightSwitch.Services;
using LightSwitch.ViewModels;

namespace LightSwitch.Helpers
{
    public static class InjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            var i = new ServiceCollection();

            i.AddSingleton<IMessenger>(WeakReferenceMessenger.Default).
            AddSingleton<IBrightnessService, BrightnessService>();

            services = i;

            return services;
        }

        [Obsolete]
        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            services.AddTransient<BrightnessViewModel>();
            return services;
        }
    }
}
