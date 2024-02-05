namespace MauiApp3;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ModalTabbedPage());
    }
}