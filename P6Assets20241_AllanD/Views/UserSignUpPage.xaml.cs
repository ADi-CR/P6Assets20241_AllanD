namespace P6Assets20241_AllanD.Views;

public partial class UserSignUpPage : ContentPage
{
	public UserSignUpPage()
	{
		InitializeComponent();
	}

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}