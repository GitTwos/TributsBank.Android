using Android.App;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using AppSorriaBank;
using AppSorriaBank.Droid;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Toolbar = AndroidX.AppCompat.Widget.Toolbar;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(NavigationPageRendererDroid))]
namespace AppSorriaBank.Droid
{
    [System.Obsolete]
    public class NavigationPageRendererDroid : Xamarin.Forms.Platform.Android.AppCompat.NavigationPageRenderer
    {
        public Toolbar toolbar;
        public Activity context;

        protected override Task<bool> OnPushAsync(Page view, bool animated)
        {
            var retVal = base.OnPushAsync(view, animated);

            context = (Activity)Xamarin.Forms.Forms.Context;
            toolbar = context.FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Droid.Resource.Id.toolbar);

            if (toolbar != null)
            {
                if (toolbar.NavigationIcon != null)
                {
                    toolbar.NavigationIcon = Android.Support.V4.Content.ContextCompat.GetDrawable(context, Resource.Drawable.setaBrancaVoltar);
                    toolbar.SetNavigationIcon(Resource.Drawable.setaBrancaVoltar);
                }
            }
            return retVal;
        }
    }
}