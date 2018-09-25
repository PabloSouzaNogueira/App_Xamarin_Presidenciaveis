using CommonServiceLocator;
using Presidenciaveis.Domain.Candidatos;
using Presidenciaveis.Infra.Data.Repository;
using Presidenciaveis.Services;
using Presidenciaveis.Views;
using System;
using Unity;
using Unity.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Presidenciaveis
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var unityContainer = new UnityContainer();

            unityContainer.RegisterType<ICandidatoRepository, CandidatoRepository>();

            unityContainer.RegisterType<ICandidatoService, CandidatoService>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(unityContainer));

            MainPage = new NavigationPage(new CandidatosPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
