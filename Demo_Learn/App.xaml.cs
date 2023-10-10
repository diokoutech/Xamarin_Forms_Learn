using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_Learn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
            Console.WriteLine("On Start");
        }

        protected override void OnSleep()
        {
            Console.WriteLine("On Sleep");
        }

        protected override void OnResume()
        {
            Console.WriteLine("On Resume");
        }
    }
}
