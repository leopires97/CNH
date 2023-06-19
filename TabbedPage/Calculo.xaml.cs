namespace TabbedPageSample;

public partial class Calculo : ContentPage
{
    public Calculo()
    {
        InitializeComponent();
    }

    async void onButtonClicked(object sender, EventArgs args)
    {
        calcular();
    }

    async void calcular()
    {
        await DisplayAlert("Alert", "deu certo", "ok");
    }
}

