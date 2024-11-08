namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Btn_retornar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new NewPage1());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}