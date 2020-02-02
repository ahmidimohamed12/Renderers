using System;
using testRenderers.Droid;
using testRenderers.Controls;
using Xamarin.Forms;
using Android.Graphics;
using Xamarin.Forms.Platform.Android;
using Android.Content;

[assembly: ExportRenderer(typeof(LabelCol), typeof(iconeRen))]
namespace testRenderers.Droid
{
    public class iconeRen : LabelRenderer
    {
        public iconeRen(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}
