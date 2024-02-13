namespace DemoMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnMultiplyClicked(object sender, EventArgs e)
        {
            int first = int.Parse(firstNumber.Text);
            int second = int.Parse(secondNumber.Text);
            int product = first * second;
            await DisplayAlert("Uitkomst",$"{first} keer {second} is {product}","OK");
        }
    }

}
