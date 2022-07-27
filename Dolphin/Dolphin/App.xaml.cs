using Common;
using Dolphin.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Service;
using System;
using System.Windows;
using ViewModel;

namespace Dolphin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {

            var services = ConfigureServices();
            Ioc.Default.ConfigureServices(services);


            this.InitializeComponent();
        }

        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        ///public IServiceProvider Services { get; }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IProjectManageService, ProjectManageService>();
            services.AddSingleton<IApplicationConfigService, ApplicationConfigService>();



            //ViewModel
            services.AddSingleton<MainWindowViewModel>();
            services.AddScoped<IProjectSelectionViewModel, ProjectSelectionViewModel>();
            

            return services.BuildServiceProvider();
        }

    }
}
