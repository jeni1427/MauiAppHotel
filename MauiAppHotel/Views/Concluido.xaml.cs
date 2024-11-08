namespace MauiAppHotel.Views;

public partial class Concluido : ContentPage
{
	public Concluido()
	{
		InitializeComponent();
	}

    private void Btn_voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage1());
    }
}
