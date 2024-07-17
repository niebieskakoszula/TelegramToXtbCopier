using CommunityToolkit.Maui.Views;

namespace TelegramToXtbCopier
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var popup = new VerificationCodePopup();
            var result = await this.ShowPopupAsync(popup, CancellationToken.None);
            if (result != null)
            {
                CounterBtn.Text = (string)result;
            }
            else
            {
                CounterBtn.Text = "null";
            }
        }
    }

}
