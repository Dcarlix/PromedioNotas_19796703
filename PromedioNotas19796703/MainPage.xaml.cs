namespace PromedioNotas19796703
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// En este ejercicio le pedimos al usuario que ingrese 5 notas de un alumno para promediarlas y mostrar el promedio en la aplicacion
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
            if (double.TryParse(n1.Text, out double nota1) && double.TryParse(n2.Text, out double nota2) && double.TryParse(n3.Text, out double nota3) && double.TryParse(n4.Text, out double nota4) && double.TryParse(n5.Text, out double nota5))
            {
                double notafinal = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
                promedio.Text = notafinal.ToString();
            }
            else
            {
                DisplayAlert("Error", "No se pueden letras o dejar en blanco", "Ok");
            }
        }
    }

}
