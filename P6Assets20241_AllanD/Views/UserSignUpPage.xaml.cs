using P6Assets20241_AllanD.ViewModels;
using P6Assets20241_AllanD.Models;

namespace P6Assets20241_AllanD.Views;

public partial class UserSignUpPage : ContentPage
{
    //para poder comunicarnos con la base de datos debemos pasar las operaciones
    //por medio del ViewModel, que se encarga de intermediar dichas operaciones

    UserViewModel? vm;

	public UserSignUpPage()
	{
		InitializeComponent();

        BindingContext = vm = new UserViewModel();

        //Y ahora llamamos a la función que se encarga de llenar el picker
        //con los datos de los roles de usuario 

        LoadUserRoles();
	}

    private async void LoadUserRoles()
    {
        CboxUserRole.ItemsSource = await vm.GetAllUserRolesAsync();
    }


    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}