namespace Task3_IPA
{
    public partial class Form1 : Form
    {
        private const string valueUnitStr = "ml";
        public Form1()
        {
            InitializeComponent();

            unitLabel.Text = valueUnitStr;
        }

        private void send_button1_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Double.Parse(size_TB.Text);
                double percentage = Double.Parse(percentage_TB.Text);
                int count = Int32.Parse(quantity_TB.Text);

                double totalValue = AlcoholCalculationService.CalculateTotalValue(value, count);
                double totalAlcoCount = AlcoholCalculationService.CalculateAlcoCount(value, count, percentage);

                drink_result.Text = totalValue.ToString() + " " + valueUnitStr;
                spirit_result.Text = Math.Round(totalAlcoCount, 2).ToString() + " " + valueUnitStr;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Input all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Incorrect error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}