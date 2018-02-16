using System.Diagnostics;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismIntro.ViewModels;
using PrismIntro.Views;
using Xamarin.Forms;

namespace PrismIntro
{
    public partial class App : PrismApplication
    {
       // public App()
      

       //     MainPage = new PrismIntroPage();
       
        public App(IPlatformInitializer intializer = null):base(intializer){ }

        protected override void OnInitialized()//Need for Prism to intialize component.
        {
            Debug.WriteLine($"****{this.GetType().Name}.{nameof(OnInitialized)}");
            InitializeComponent();

            NavigationService.NavigateAsync(nameof(PrismIntroPage));
        }
        protected override void RegisterTypes(Prism.Ioc.IContainerRegistry containerRegistry) //One of first called.
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(RegisterTypes)}");

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
