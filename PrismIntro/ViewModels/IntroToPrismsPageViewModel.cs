using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Prism.Navigation;
using Prism.Commands;
using Prism.Unity;
using PrismIntro.ViewModels;
using PrismIntro.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismIntro.ViewModels
{

    public class IntroToPrismsPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        INavigationService _navigationService1;


        public DelegateCommand NavToRegisterCommand { get; set; }
        public DelegateCommand LoginPageCommand { get; set; }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private string _userC;
        public string userC
        {
            get { return _userC; }
            set { SetProperty(ref _userC, value); }
        }
        private string _userPass;
        public string userPass
        {
            get { return _userPass; }
            set { SetProperty(ref _userPass, value); }
        }

        private string _resultText;
        public string ResultText
        {
            get { return _resultText; }
            set { SetProperty(ref _resultText, value); }
        }

        public IntroToPrismsPageViewModel(INavigationService navigationService)
        {

            Debug.WriteLine($"****{this.GetType()}:  ctor");


            Title = "Launch Page";
            _navigationService = navigationService;
            _navigationService1 = navigationService;

            NavToRegisterCommand = new DelegateCommand(OnNavToRegisterPage);
            LoginPageCommand = new DelegateCommand(OnNavToMainPage);

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

        private void OnNavToRegisterPage()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavToRegisterPage)}");
            _navigationService.NavigateAsync("RegisterPage");
        }
        private void OnNavToMainPage()
        {
            String Result = DependencyService.Get<IDbDataFetcher>().GetData("SELECT * FROM USERS WHERE password = 'lolatyou'");

            ResultText = Result;

        }

    }
}