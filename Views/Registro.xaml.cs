namespace CNarvaezExamen.Views;

public partial class Registro : ContentPage
{
    public Registro(string usuarioConectado)
    {
        InitializeComponent();
        lblUsuarioConectado.Text = $"Usuario Conectado: {usuarioConectado}";
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        
        double montoInicial = 0;
        double total = 300; 

        if (double.TryParse(txtMontoInicial.Text, out montoInicial))
        {
            double saldoRestante = total - montoInicial;
            double cuotaMensual = saldoRestante / 3 * 1.05; 
            txtCuotaMensual.Text = cuotaMensual.ToString("F2"); 
        }
        else
        {
            DisplayAlert("Error", "Ingrese un monto inicial correcto", "OK");
        }
    }

    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        
        DisplayAlert("Resumen", "resumen de los datos ingresados", "OK");
    }
}
