using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Prism.Navigation;
using Prism.Commands;
using PrismIntro.ViewModels;
namespace PrismIntro.ViewModels
{
    public class RegisterPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        public DelegateCommand AddUserCommand { get; set; }


        private string _user;
        public string User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public RegisterPageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine($"****{this.GetType()}:  ctor");
            _navigationService = navigationService;
            AddUserCommand = new DelegateCommand(AddUserCommandPage);
          
         
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");
        }
        private void AddUserCommandPage()
        {
          
        }
      
    }
}