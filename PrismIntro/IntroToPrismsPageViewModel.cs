using System.Diagnostics;
using Prism.Mvvm;

namespace PrismIntro
{
    public class IntroToPrismsPageViewModel : BindableBase
    {
        public IntroToPrismsPageViewModel()
        {
            Debug.WriteLine($"****{this.GetType()}:  ctor");
        }
    }
}