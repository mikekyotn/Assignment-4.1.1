namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Person> addressBook = CreateDataSource.CreateSampleDictionary();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryName = txtBoxFirstName.Text + txtBoxLastName.Text;
            if (addressBook.ContainsKey(queryName))
            {
                lblSearchResult.Text = "Record Found";
                dataGridView1.DataSource = new BindingSource(addressBook[queryName], null);
                
            }
            else
            {
                lblSearchResult.Text = "Record Not Found";
                
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource(addressBook.Values, null);
        }
    }
}
