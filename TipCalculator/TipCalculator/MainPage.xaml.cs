namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button15Percent_Clicked(object sender, EventArgs e)

        {
            PercentagemSlider.Value = 15;
        }
        private void Button30percent_Clicked(object sender, EventArgs e)
        {

        }
        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
            double tip = CalculateTip();
            tip = Math.Ceiling(tip);
            TipLabel.Text = Convert.ToString(tip);
            double valorRefeicao = tip + Convert.ToDouble(ValueEntry.Text);
            TotaLabel.Text = valorRefeicao.ToString("C2");
        }
        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
         
        }

        private double CalculateTip()
        {
            double valRefeicao = Convert.ToDouble(ValueEntry.Text);
            double valporcentagem = PercentagemSlider.Value;
            double valorGorjeta = valRefeicao * (valporcentagem / 100);
            return (valorGorjeta);

        }

        private void PercentagemSlider_ValueChanged(object sender, EventArgs e) {

            PorcentagemLabel.Text = $"{PercentagemSlider.Value.ToString()}%";

            

            }
    }
}
