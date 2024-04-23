namespace P6Assets20241_AllanD.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void SwVerPassword_Toggled(object sender, ToggledEventArgs e)
    {
        if (SwVerPassword.IsToggled)
        {
            TxtPassword.IsPassword = false;
        }
        else
        {
            TxtPassword.IsPassword = true;
        }
    }

    private async void BtnSignUp_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserSignUpPage());
    }

    private async void BtnIngresar_Clicked(object sender, EventArgs e)
    {
        //TODO: agregar llamada al API para consultar el usuario por 
        //el correo y contraseña 

        //si la respuesta es correcta entonces mostramos la página de 
        //selección de opciones 

        await Navigation.PushAsync(new OptionsPage());

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
}