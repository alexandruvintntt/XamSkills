using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSkillsForms.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamSkillsForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UsersPage();
        }
    }
}