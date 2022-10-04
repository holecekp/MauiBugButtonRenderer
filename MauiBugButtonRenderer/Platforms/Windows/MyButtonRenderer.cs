using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Compatibility.Platform.UWP;
using Microsoft.Maui.Controls.Platform;
using Microsoft.UI.Xaml.Controls;

namespace MauiBugButtonRenderer.Platforms.Windows
{
    public class MyButtonRenderer: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Microsoft.Maui.Controls.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                UpdateTooltip(Element as MyButton);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }

        private void UpdateTooltip(MyButton button)
        {
            string tooltip = "Test";
            if (Control != null && !String.IsNullOrEmpty(tooltip))
                ToolTipService.SetToolTip(Control, tooltip);
        }
    }
}
