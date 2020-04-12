using Android.App;
using Android.OS;

namespace NovodApp.Droid
{
    [Activity(Label = "SplashScreen", Theme = "@style/MyTheme", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
        }
    }
}