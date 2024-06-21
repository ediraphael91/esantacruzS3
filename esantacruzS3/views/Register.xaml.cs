namespace esantacruzS3.views;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    
    private void btnGuardar2_Clicked(System.Object sender, System.EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;
        DisplayAlert("Alerta", "Usuario Guardado", "ok");
        Navigation.PushAsync(new login(usuario, contrasena));
    }

    private void btnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new login());
    }
}