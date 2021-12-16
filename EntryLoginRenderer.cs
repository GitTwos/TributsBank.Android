using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppSorriaBank.CustomControl;
using AppSorriaBank.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryLogin), typeof(EntryLoginRenderer))]
namespace AppSorriaBank.Droid
{
    public class EntryLoginRenderer : EntryRenderer
    {
        public EntryLoginRenderer(Context context) : base(context)
        {
        }

        [Obsolete]
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {   // perform initial setup
                // lets get a reference to the native control
                //var nativeEditText = (global::Android.Widget.EditText)Control;
                //// do whatever you want to the textField here!
                //nativeEditText.SetBackgroundColor(global::Android.Graphics.Color.Black);
                //nativeEditText.SetTextColor(global::Android.Graphics.Color.White);
                //nativeEditText.SetHighlightColor(global::Android.Graphics.Color.White);

                var qtd = Control.PaddingLeft + 72;
                Control.SetPaddingRelative(qtd, 0, 0, 0);
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Rgb(255, 255, 255));
                else
                    Control.Background.SetColorFilter(Android.Graphics.Color.Rgb(255, 255, 255), PorterDuff.Mode.SrcAtop);

                //nativeEditText.BackgroundTintList = ColorStateList.ValueOf(global::Android.Graphics.Color.White);
                //nativeEditText.Background.SetColorFilter(global::Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
                //Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Neris-Light.otf");
                //nativeEditText.TextSize = 14f;
                //nativeEditText.Typeface = font;
            }
        }
    }
}