using Android.App;
using Android.Widget;
using Android.OS;

namespace MallNavigationApp
{
    [Activity(Label = "MallNavigationApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button showPopupMenu = FindViewById<Button>(Resource.Id.popupButton);
            showPopupMenu.Click += (s, arg) => {
                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.popMenu);
                menu.Show();
            };
        }
    }
}

