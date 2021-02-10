using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsArquitectura.Services.NavigationService;
using XamFormsArquitectura.ViewModels;
using XamFormsArquitectura.Views;

namespace XamFormsArquitectura
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            navigationService.InitializeAsync();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
