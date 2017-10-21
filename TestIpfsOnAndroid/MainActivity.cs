using Android.App;
using Android.Widget;
using Android.OS;

namespace TestIpfsOnAndroid
{
    [Activity(Label = "TestIpfsOnAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView view;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            view = FindViewById<TextView>(Resource.Id.txtView);
            view.Text = "Hello";
        }
    }
}

