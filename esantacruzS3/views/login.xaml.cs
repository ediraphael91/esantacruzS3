namespace esantacruzS3.views;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    string user;
    string password;

    public login(string usuario, string contrasena)
    {
        InitializeComponent();
        user = usuario;
        password = contrasena;
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && password == txtContrase�a.Text)
        {
            Navigation.PushAsync(new Home(user));
        }
        else {
            DisplayAlert("alerta", "USUARIO O CONTRASE�A INCORRECTOS","OK");
        }
        
    }
   

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Register());
    }


}