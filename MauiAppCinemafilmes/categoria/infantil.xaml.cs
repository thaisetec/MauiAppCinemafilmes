namespace MauiAppCinemafilmes.categoria;

public partial class Infantil : ContentPage
{
	public Infantil()
	{
		InitializeComponent();
	}

    private void btninf1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.infantil1());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btninf2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.infantil2());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btninf3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.infantil3());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btninf4_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.infantil4());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }
}