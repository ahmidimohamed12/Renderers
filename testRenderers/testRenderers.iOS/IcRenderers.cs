using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using testRenderers.iOS;
using testRenderers.Controls;
using UIKit;

[assembly: ExportRenderer(typeof(LabelCol), typeof(IcRenderers))]
namespace testRenderers.iOS
{
    public class IcRenderers : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.Red;
            }
        }
    }
}
