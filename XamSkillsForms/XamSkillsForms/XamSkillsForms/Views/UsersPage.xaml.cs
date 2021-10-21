using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamSkillsForms.Framework;
using XamSkillsForms.Services;
using XamSkillsForms.ViewModels;

namespace XamSkillsForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsersPage : ContentPage
    {
        protected UsersPageViewModel ViewModel
        {
            get => BindingContext as UsersPageViewModel;
            set => BindingContext = value;
        }
        
        public UsersPage()
        {
            InitializeComponent();
            
            ViewModel = new UsersPageViewModel(
                new UserService(),
                new MessageService());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            ViewModel.Initialize();
        }
    }
}