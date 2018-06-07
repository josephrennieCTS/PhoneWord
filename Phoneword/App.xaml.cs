using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Phoneword
{
    public partial class App : Application //Application Class
    {
        public static IList<string> PhoneNumbers { get; set; }

        public App()
        {
            
            InitializeComponent();//Function used to start up app when icon is tapped
            PhoneNumbers = new List<string>(); //A list created to store phoneNumbers that have been previously entered
            MainPage = new NavigationPage(new MainPage()); //configures the first page opened when the app starts (mainPage)
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