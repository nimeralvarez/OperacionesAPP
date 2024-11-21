namespace OperacionesApp.Page;

public partial class AreaCuadrado : ContentPage
{
    public double Resultado {  get; set; }
	public AreaCuadrado()
	{
		InitializeComponent();
	}

    private void btnAreaCuadrado_Clicked(object sender, EventArgs e)
    {
        if (lado.Text==null || lado.Text == "")
        {
            Alerta("Ingrese un valor numérico");
        }
        else
        {
            Resultado = Math.Round(Math.Pow(Double.Parse(lado.Text), 2),2);
            MostrarResultado();
        }

    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        lado.Text = "";
    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("Advertencia", mensaje, "Aceptar");
    }

    private void MostrarResultado()
    {
        DisplayAlert("Advertencia", $"El area del cuadrado es: {Resultado} cm", "Aceptar");
    }

}