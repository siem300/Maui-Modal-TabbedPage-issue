using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using System.Runtime.CompilerServices;

namespace MauiApp3;

public partial class ModalTabbedPage : Microsoft.Maui.Controls.TabbedPage
{
	public ModalTabbedPage()
	{
		InitializeComponent();
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.ToolbarPlacement.Bottom);
    }
}