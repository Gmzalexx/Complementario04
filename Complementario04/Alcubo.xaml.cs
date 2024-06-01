namespace Complementario04;

public partial class Alcubo : ContentPage
{
	public Alcubo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Configuramos y verificamos si se ha ingresado un número válido con el tryparse y numeroentry
        if (int.TryParse(numeroEntry.Text, out int numero) && numero >= 0)
        {
            // Luego calculamos el cuadrado y el cubo con un valor entero haciendo multiplicacion de numero por numero
            //y luego hacemos los mismo pero con cubo solo que esta vez 3 veces
            int cuadrado = numero * numero;
            int cubo = numero * numero * numero;

            //  Mostramos los resultados en un label este aparecera en la pantalla dando los resultados que hemos pedido
            resultadoLabel.Text = $"El cuadrado de {numero} es: {cuadrado}\nEl cubo de {numero} es: {cubo}";
        }
        else
        {
            //Y este hara la funcion de otorgar un error si esta mal o esta mal codificado
            resultadoLabel.Text = "Por favor, ingrese un número entero positivo válido.";
        }


    }
}