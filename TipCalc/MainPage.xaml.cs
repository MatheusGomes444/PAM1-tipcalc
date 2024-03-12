namespace TipCalc
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
      
        }
        private void SliderTipePercent_ValueChanged(object sender, ValueChangeEventArgs eventArgs e)
        {
            LabelPercentageValue.Text = Math.Round(SliderTipePercent.Value).ToString();
        }

        private void BTN1_Clicked(object sender, EventArgs e)
        {
            SliderTipePercent.Value = 15;
        }

        private void BTN2_Clicked(object sender, EventArgs e)
        {
            SliderTipePercent.Value = 20;
        }

        private void BTN3_Clicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundeResult = Math.Floor(result);
            double amount = Convert.ToDouble(roundeResult);
            double totalValue = roundeResult + amount;
            LabelTipValue.Text = roundeResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();

        }

        private void BTN4_Clicked(object sender, EventArgs e)
        {
            double result = CalculateTip();
            double roundeResult = Math.Ceiling(result);
            double amount = Convert.ToDouble(roundeResult);
            double totalValue = roundeResult + amount;
            LabelTipValue.Text = roundeResult.ToString();
            LabelTotalValue.Text = totalValue.ToString();

        }
        private double CalculateTip()
        {
            double amount = Convert.ToDouble (ValueEntry.Text.ToString());
            double percent = SliderTipePercent.Value;

            //
            double result = amount * (percent / 100);
            return result;
        }
        private void SliderTipePercent_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelPercentageValue.Text =Math.Round(SliderTipePercent.Value)String();
        }
    }

}
