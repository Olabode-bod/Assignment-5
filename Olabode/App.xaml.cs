using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Olabode
{
    public partial class App : Application
    {
        public NavigationPage AboutPage { get; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
