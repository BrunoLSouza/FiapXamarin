using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace FIAP.NET15.XF.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            AppName.Text = AppInfo.Name;
            AppVersion.Text = AppInfo.VersionString;
            AppBuild.Text = AppInfo.BuildString;
        }
    }
}