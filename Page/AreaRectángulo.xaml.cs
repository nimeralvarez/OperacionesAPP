namespace OperacionesApp.Page;

public partial class AreaRectángulo : ContentPage
{
    public double Resultado { get; set; }

    public AreaRectángulo()
	{
		InitializeComponent();
	}

    private void btnAreaRectangulo_Clicked(object sender, EventArgs e)
    {
        if (baseRectangulo.Text == null || baseRectangulo.Text == "")
        {
            Alerta("Ingrese un valor numérico en la base");

        }
        else if (alturaRectangulo.Text == null || alturaRectangulo.Text == "")
        {
            Alerta("Ingrese un valor numérico altura");
        }
        else
        {
            Resultado = Math.Round(Double.Parse(baseRectangulo.Text)* Double.Parse(alturaRectangulo.Text),2);
            MostrarResultado();
        }

    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        baseRectangulo.Text = "";
        alturaRectangulo.Text = "";

    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("Advertencia", mensaje, "Aceptar");
    }

    private void MostrarResultado()
    {
        DisplayAlert("Advertencia", $"El area del rectangulo es: {Resultado} cm", "Aceptar");
    }

}