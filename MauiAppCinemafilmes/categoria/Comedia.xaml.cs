namespace MauiAppCinemafilmes.categoria;

public partial class Comedia : ContentPage
{
	public Comedia()
	{
		InitializeComponent();
	}

    private void btncomed1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.comedia1());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btncomed2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.comedia2());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btncomed3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.comedia3());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btncomed4_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.comedia4());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }
}