namespace NavigationWhenLocked
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigationClicked(object sender, EventArgs e)
        {
            await Task.Delay(5000);

            await App.Current.MainPage.Navigation.PushAsync(new SecondPage());
        }
    }

}
