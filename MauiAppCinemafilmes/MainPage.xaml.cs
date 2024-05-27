namespace MauiAppCinemafilmes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn00_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categoria.Comedia());

            }catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btn10_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categoria.Terror());

            }catch(Exception ex)
            {
                DisplayAlert("ops" , ex.Message, "OK");
            }

        }

        private void btn20_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Ficcao_cientifica());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn30_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Infantil());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn40_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Guerra());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn50_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Nacional());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn01_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn11_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Drama());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn21_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Suspense());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn31_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Animacao());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn41_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Documentario());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }

        private void btn51_Clicked(object sender, EventArgs e)
        {

            try
            {
                Navigation.PushAsync(new categoria.Romance());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }

        }
    }

}
