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

[assembly: ExportRenderer(typeof(WebView), typeof(CoolViewSample.Droid.WebViewRenderer))]
namespace CoolViewSample.Droid
{
    public class WebViewRenderer : Xamarin.Forms.Platform.Android.WebViewRenderer
    {
        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.LoadWithOverviewMode = true;
            Control.Settings.UseWideViewPort = true;
        }
    }
}