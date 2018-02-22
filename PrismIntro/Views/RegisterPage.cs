using System;

using Xamarin.Forms;

namespace PrismIntro.Views
{
    public class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

