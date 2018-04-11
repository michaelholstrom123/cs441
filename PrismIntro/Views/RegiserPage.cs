using System;

using Xamarin.Forms;

namespace PrismIntro.Views
{
    public class RegiserPage : ContentPage
    {
        public RegiserPage()
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

