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
                dataGridView1.DataSource = null;

            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource(addressBook.Values, null);
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (addressBook.ContainsKey(txtBoxUpdateFName.Text + txtBoxUpdateLName.Text))
            {
                lblUpdateMessage.Text = "Error: Duplicate Person";
            }
            else
            {

                addressBook.Add(txtBoxUpdateFName.Text + txtBoxUpdateLName.Text, new Person()
                {
                    FirstName = txtBoxUpdateFName.Text,
                    LastName = txtBoxUpdateLName.Text,
                    MobileNumber = txtBoxUpdateMobile.Text,
                    WorkNumber = txtBoxUpdateWork.Text,
                    Address = txtBoxUpdateAddress.Text
                });

                dataGridView1.DataSource = new BindingSource(addressBook.Values, null);
                lblUpdateMessage.Text = "Address Book Updated";
            }

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            string queryName = txtBoxFirstName.Text + txtBoxLastName.Text;
            if (addressBook.ContainsKey(queryName))
            {
                lblSearchResult.Text = "Record Found and Deleted";
                addressBook.Remove(queryName);
                
            }
            else
            {
                lblSearchResult.Text = "Record Not Found";
                dataGridView1.DataSource = null;

            }
        }
    }
}
