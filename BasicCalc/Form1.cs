namespace BasicCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {

                decimal number1 = decimal.Parse(txtNumber1.Text);
                decimal number2 = decimal.Parse(txtNumber2.Text);
                decimal result = number1 + number2;
                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz!", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtNumber1.Focus();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {

                decimal number1 = decimal.Parse(txtNumber1.Text);
                decimal number2 = decimal.Parse(txtNumber2.Text);
                decimal result = number1 - number2;
                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz!", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtNumber1.Focus();
        }
        private void btnCross_Click(object sender, EventArgs e)
        {
            try
            {
                decimal number1 = decimal.Parse(txtNumber1.Text);
                decimal number2 = decimal.Parse(txtNumber2.Text);
                decimal result = number1 * number2;
                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz!", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtNumber1.Focus();

        }
        private void btnDivide_Click(object sender, EventArgs e)
        {

            try
            {
                decimal number1 = decimal.Parse(txtNumber1.Text);
                decimal number2 = decimal.Parse(txtNumber2.Text);
                if (number2 == 0)
                {
                    MessageBox.Show("Bir sayý 0'a bölünemez.");
                    return;
                }
                decimal result = number1 / number2;
                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz!", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ýþlem sýrasýnda bir hata oluþtu. Tekrar deneyin.");
            }
            txtNumber1.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtResult.Clear();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();

        }
    }
}
