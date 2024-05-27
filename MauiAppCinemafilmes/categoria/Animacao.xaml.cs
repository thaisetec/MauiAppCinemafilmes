namespace MauiAppCinemafilmes.categoria;

public partial class Animacao : ContentPage
{
	public Animacao()
	{
		InitializeComponent();
	}

    private void btnanim1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.anim1());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }
    }

    private void btnanim2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.anim2());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btnanim3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.anim3());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

private void btnanim4_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.anim4());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }
}