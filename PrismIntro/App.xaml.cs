using System.Diagnostics;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using PrismIntro.ViewModels;
using PrismIntro.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace PrismIntro
{
    public partial class App : PrismApplication
    {
       
        public App(IPlatformInitializer intializer = null):base(intializer){ }

        protected override async void OnInitialized()//Need for Prism to intialize component.
        {
            Debug.WriteLine($"****{this.GetType().Name}.{nameof(OnInitialized)}");
            InitializeComponent();
            await NavigationService.NavigateAsync("PrismIntroPage");


        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry) //One of first called.
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(RegisterTypes)}");

            containerRegistry.RegisterForNavigation<RegisterPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<PrismIntroPage, IntroToPrismsPageViewModel>();
           
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
