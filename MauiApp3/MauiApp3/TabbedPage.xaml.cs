using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace MauiApp3
{
    public partial class TabbedPage : Microsoft.Maui.Controls.TabbedPage
    {
        public TabbedPage()
        {
            InitializeComponent();
            On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.ToolbarPlacement.Bottom);
        }
    }

}
