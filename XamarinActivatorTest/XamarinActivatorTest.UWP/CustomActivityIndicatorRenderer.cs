using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinActivatorTest;
using XamarinActivatorTest.UWP;

[assembly: ExportRenderer(typeof(CustomActivityIndicator), typeof(CustomActivityIndicatorRenderer))]

namespace XamarinActivatorTest.UWP
{
    public class CustomActivityIndicatorRenderer : ActivityIndicatorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ActivityIndicator> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                UpdateStatus();
            }
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == nameof(Element.IsRunning))
            {
                UpdateStatus();
            }
        }
        private void UpdateStatus()
        {
            Control.ShowPaused = !Element.IsRunning;
            Control.Opacity = Element.IsRunning ? 1 : 0;
        }
    }
}
