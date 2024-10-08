using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MobilePrintinatorMaui;
using MobilePrintinatorTester.ViewModels;
using MobilePrintinatorTester.ContentPages;

namespace MobilePrintinatorTester
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMobilePrintinator()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            var services = builder.Services;

            services.AddSingleton<SettingsViewModel>(serviceProvider => new SettingsViewModel());
            services.addView<Settings, SettingsViewModel>();

            services.AddSingleton<TestingViewModel>(serviceProvider => new TestingViewModel());
            services.addView<Testing, TestingViewModel>();

            return builder.Build();
        }

        private static void addView<TView, TViewModel>(this IServiceCollection services)
            where TView : ContentPage, new()
        {
            services.AddSingleton<TView>(serviceProvider => new TView()
            {
                BindingContext = serviceProvider.GetRequiredService<TViewModel>()
            });
        }
    }
}
