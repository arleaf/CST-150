namespace PhoneStore
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void brandBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creating new Phone object based on phone ordered
            Phone orderedPhone = new Phone();
            orderedPhone.Brand = brandBox.Text;
            orderedPhone.Carrier = carrierBox.Text;
            orderedPhone.Storage = storageBox.Text;
            orderedPhone.Color = colorBox.Text;

            //calling Phone methods
            //will display the phone details
            orderedPhone.displayPhoneDetails();
            //will display price
            PriceLabel.Text = orderedPhone.calculateTotalPrice().ToString();
        }
      
    }
}