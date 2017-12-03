using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(WebView), typeof(CoolViewSample.iOS.WebViewRenderer))]
namespace CoolViewSample.iOS
{
    public class WebViewRenderer : Xamarin.Forms.Platform.iOS.WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            ScalesPageToFit = true;
            ContentMode = UIKit.UIViewContentMode.ScaleAspectFit;
        }
    }
}