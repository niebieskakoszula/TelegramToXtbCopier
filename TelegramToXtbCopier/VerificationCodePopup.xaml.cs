using CommunityToolkit.Maui.Views;

namespace TelegramToXtbCopier;

public partial class VerificationCodePopup : Popup
{
	public VerificationCodePopup()
	{
		InitializeComponent();
	}

    private async void OnConfirmButtonClicked(object sender, EventArgs e)
    {
        await CloseAsync(CodeEntry.Text);
    }

    private async void OnCancelButtonClicked(object sender, EventArgs e)
    {
        await CloseAsync(null);
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(e.NewTextValue.Length == 5 && e.NewTextValue.All(char.IsDigit))
        {
            ConfirmButton.IsEnabled = true;
        }
        else
        {
            ConfirmButton.IsEnabled = false;
        }
    }
}