using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using AppSorriaBank.CustomControl;
using AppSorriaBank.Droid;
using System.Globalization;

[assembly: ExportRenderer(typeof(EntryFdVerde), typeof(EntryFdVerdeRenderer))]
namespace AppSorriaBank.Droid
{
    public class EntryFdVerdeRenderer : EntryRenderer
    {
        public EntryFdVerdeRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var clId = e.NewElement.ClassId;
                int r = 0;
                int g = 0;
                int b = 0;

                if (clId.IndexOf('#') != -1)
                    clId = clId.Replace("#", "");

                r = int.Parse(clId.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                g = int.Parse(clId.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                b = int.Parse(clId.Substring(4, 2), NumberStyles.AllowHexSpecifier);

                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(20f);
                if (e.NewElement.ClassId != "#ffffff")
                {
                    gradientDrawable.SetStroke(3, Android.Graphics.Color.Rgb(255, 255, 255));
                }
                else
                {
                    gradientDrawable.SetStroke(5, Android.Graphics.Color.Rgb(2, 40, 103));
                }

                gradientDrawable.SetColor(Android.Graphics.Color.Rgb(r, g, b));
                //gradientDrawable.SetColor(Android.Graphics.Color.Rgb(R, G, B));
                Control.SetBackground(gradientDrawable);

                Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight,
                    Control.PaddingBottom);
            }
        }
    }
}