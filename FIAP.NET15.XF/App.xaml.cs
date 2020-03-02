using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FIAP.NET15.XF.Services;
using FIAP.NET15.XF.Views;

namespace FIAP.NET15.XF
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
