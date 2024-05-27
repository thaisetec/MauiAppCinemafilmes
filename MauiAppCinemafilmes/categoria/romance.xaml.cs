namespace MauiAppCinemafilmes.categoria;

public partial class Romance : ContentPage
{
	public Romance()
	{
		InitializeComponent();
	}

    private void btnromance1_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.rom1());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btnromance2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.rom2());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btnromance3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.rom3());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btnromance4_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.rom4());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }
}