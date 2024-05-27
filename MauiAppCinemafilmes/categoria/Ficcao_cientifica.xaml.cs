namespace MauiAppCinemafilmes.categoria;

public partial class Ficcao_cientifica : ContentPage
{
	public Ficcao_cientifica()
	{
		InitializeComponent();
	}

    private void btnfic1_Clicked(object sender, EventArgs e)
    {

        try
        {
            Navigation.PushAsync(new filmes.fic1());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    

   

   

    private void btnfic2_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.fic2());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }
    }

    private void btnfic3_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.fic3());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }

    private void btnfic4_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new filmes.fic4());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }
}