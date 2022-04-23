namespace Milestone4
{
    public partial class MainForm : Form
    {
        //Main Form Class
        //Object composition,
        public InventoryManager im;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Setting comboBox to first value in box
            operationComboBox.SelectedIndex = 0;
            //creating new Inventory Manager
            im = new InventoryManager();

        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            
            //determine which operation user selected
            //Add Operation
            if (operationComboBox.SelectedIndex == 0)
            {
                // Create Add Form object & displaY
                AddForm addForm = new AddForm(im);
                addForm.ShowDialog();
            }
            // Remove Operation
            else if (operationComboBox.SelectedIndex == 1)
            {
                //create remove form object & display
                RemoveForm rm = new RemoveForm(im);
                rm.ShowDialog();
            }
            //Restock Operation
            else if (operationComboBox.SelectedIndex == 2)
            {
                //Create restock form object & display
                RestockForm restock = new RestockForm(im);
                restock.ShowDialog();
            }
            //display Operation
            else if (operationComboBox.SelectedIndex == 3)
            {
                //call Inventory manager display method. 
                im.displayInventoryManager();
            }
            //Search Form
            else if ( operationComboBox.SelectedIndex == 4)
            {
                //Create search form object and display
                SearchForm searchForm = new SearchForm(im);
                searchForm.ShowDialog();
            }
        }
    }
}