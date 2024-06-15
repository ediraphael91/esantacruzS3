namespace esantacruzS3.views;

public partial class Home : ContentPage
{
	public Home(String nombre)
	{
		InitializeComponent();
		lblNombre.Text = "Bienvenido: "+nombre;
	}
}