using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using Xamarin.Forms;

namespace PushN
{
    public class App : Application
    {

        
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new NewsShow());
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Padding = 20,
                    Children = {
                        new Label { Text="Hello Xamarin Push Notification"}
                    }
                }
            };
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
