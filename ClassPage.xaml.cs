using Microsoft.Maui.Controls;

namespace dxclusive
{
    public partial class ClassPage : ContentPage
    {
        public ClassPage()
        {
            InitializeComponent();
        }

        // Navigate back to the previous page
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Navigates back to the previous page
        }

        // Handle class button clicks
        private async void OnClassButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string selectedClass = button.Text; // Get the text of the clicked button

                // Example: Display the selected class
                await DisplayAlert("Class Selected", $"You selected: {selectedClass}", "OK");

                // Example: Navigate to another page (optional, replace with your logic)
                // await Navigation.PushAsync(new DetailPage(selectedClass));
            }
        }
    }
}
