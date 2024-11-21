namespace OperacionesApp.Page;

public partial class AreaCirculo : ContentPage
{
    public double Resultado { get; set; }
    public AreaCirculo()
	{
		InitializeComponent();
	}

    private void btnAreaCirculo_Clicked(object sender, EventArgs e)
    {
        if (radio.Text == null || radio.Text == "")
        {
            Alerta("Ingrese un valor numérico");
        }
        else
        {
            Resultado =Math.Round(Math.PI * (Math.Pow(Double.Parse(radio.Text), 2)),2);
            MostrarResultado();
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        radio.Text = "";
    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("Advertencia", mensaje, "Aceptar");
    }

    private void MostrarResultado()
    {
        DisplayAlert("Advertencia", $"El area del círculo es: {Resultado} cm", "Aceptar");
    }
}