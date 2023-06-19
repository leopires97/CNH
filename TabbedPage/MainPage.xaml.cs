
using System.Security.Cryptography;

namespace TabbedPageSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		List<Trator> tratores = new List<Trator>()
		{
			new Trator { Imagem = "farmall.png", Nome="Farmall"},
			new Trator { Imagem = "maxxum.png", Nome = "Maxxum" },
			new Trator { Imagem = "puma.png", Nome = "Puma" },
			new Trator { Imagem = "magnum.png", Nome = "Magnum" },
            new Trator { Imagem = "steiger.png", Nome = "Steiger" }

        };

		listTratores.ItemsSource = tratores;
	}

	public class Trator
	{
		public ImageSource Imagem { get; set; }
        public string Nome { get; set; }
	}

    async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
	{
		await Navigation.PushAsync(new Calculo());
	}

    void listTratores_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
    }
}


