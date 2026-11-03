namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            {
                try
                {
                    double etanol = Convert.ToDouble(txt_etanol.Text);
                    double gasolina = Convert.ToDouble(txt_gasolina.Text);

                    string marca = txt_Marca.Text;

                    string modelo = txt_Modelo.Text;

                    string msg = "";
                    if (etanol <= (gasolina * 0.7))
                    {
                        msg = ($"Neste caso, o veículo {marca}, modelo {modelo} compensa o abastecimento com etanol");
                    }
                    else
                    {
                        msg = ($"Neste caso, o veículo {marca}, modelo {modelo} compensa o abastecimento com gasolina");
                    }

                    DisplayAlert("Olá", msg, "OK");

                }
                catch (Exception ex)
                {
                    DisplayAlert("Ops", ex.Message, "Fechar");
                }
            } // Fecha método
        } //Fecha Class
    } // Fecha namespace
}
