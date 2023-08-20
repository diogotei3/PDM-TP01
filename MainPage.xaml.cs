using Windows.Services.Store;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, EventArgs e)
        {

            if (id.Text == "admin" && password.Text == "senha@dmin")
                DisplayAlert("Logado com sucesso!", "", "ok");
            else
                DisplayAlert("Não autorizado!", "Digite o login de adminstrador", "ok");
        }

        private void OnClear(object sender, EventArgs e)
        {
            id.Text = "";
            password.Text = "";
        }

        private void OnCredits(object sender, EventArgs e) 
        {
            DisplayAlert("Realizado por", "Diogo Santos Teixeira\nGuilherme Ferreira", "ok");
        }
    }
}