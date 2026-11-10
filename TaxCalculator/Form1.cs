namespace TaxCalculator
{
    public partial class IncomeTaxCalculator : Form
    {
        public IncomeTaxCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(IncomeTxt.Text);
            decimal threshold = 0;
            decimal percent = 0;
            decimal baseTax = 0;


            if (income < 11000)
            {
                threshold = 0;
                percent = 0.1m;
                baseTax = 0;
            }

            if (income >= 11000 && income < 44725)
            {
                threshold = 11000;
                percent = 0.12m;
                baseTax = 1100;
            }

            if (income >= 44725 && income < 95357)
            {
                threshold = 44725;
                percent = 0.22m;
                baseTax = 5147;
            }

            if (income >= 95357 && income < 182100)
            {
                threshold = 95357;
                percent = 0.24m;
                baseTax = 16290;
            }

            if (income >= 182100 && income < 231250)
            {
                threshold = 182100;
                percent = 0.32m;
                baseTax = 37104;
            }

            if (income >= 231250 && income < 578125)
            {
                threshold = 231250;
                percent = 0.35m;
                baseTax = 52832;
            }

            if (income >= 578125)
            {
                threshold = 578125;
                percent = 0.37m;
                baseTax = 174238.25m;
            }

            decimal percentage = income - threshold;
            decimal tax = percentage * percent;
            decimal awnser = tax + baseTax;

            awnser = Math.Round(awnser, 2);
            OwedTxt.Text = awnser.ToString();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OwedTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
