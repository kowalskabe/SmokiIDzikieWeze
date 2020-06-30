using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmokiIDzikieWeze.UI.Forms
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            
            var repo = new CustomerRepository().Retrieve();
            listBoxListOfCustomers.DataSource = repo;
            HideSingleCustomerData();
            
        }

     

        private void buttonDisplay_Click_1(object sender, EventArgs e)
        {
            HideSingleCustomerData();
            Customer customer = (Customer)listBoxListOfCustomers.SelectedItem;
            
           labelTitle2.Show();
            //  labelCustomerFullName.Text = customer.FullName();
            //  labelId.Show();
            //  labelCustomerId.Text = customer.CustomerId.ToString();
            //  labelEmail.Show();
            //  labelCustomerEmail.Text = customer.Email;

            lbl1ToTextBox.Show();
            textBox1.Show();
            textBox1.ReadOnly = true;
            textBox1.Text = customer.FirstName.ToString();

            lbl2ToTextBox.Show();
            textBox2.Show();
            textBox2.ReadOnly = true;
            textBox2.Text = customer.Surname.ToString();

            lbl3ToTextBox.Show();
            textBox3.Show();
            textBox3.ReadOnly = true;
            textBox3.Text = customer.CustomerId.ToString();

            lbl4ToTextBox.Show();
            textBox4.Show();
            textBox4.ReadOnly = true;
            textBox4.Text = customer.Email.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            HideSingleCustomerData();
            Customer customer = (Customer)listBoxListOfCustomers.SelectedItem;
            int i = customer.CustomerId;
            
            var repo = new CustomerRepository().Delete(i);
            listBoxListOfCustomers.DataSource = repo;
            HideSingleCustomerData();
            Console.WriteLine(Customer.lastId);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            HideSingleCustomerData();
            //Customer customer = (Customer)listBoxListOfCustomers.SelectedItem;
            labelTitle4.Show();

            lbl1ToTextBox.Show();
            textBox1.Show();
            textBox1.ReadOnly = false;
            textBox1.Text = String.Empty;

            lbl2ToTextBox.Show();
            textBox2.Show();
            textBox2.ReadOnly = false;
            textBox2.Text = String.Empty;

            lbl3ToTextBox.Show();
            textBox3.Show();
            textBox3.ReadOnly = true;
            textBox3.Text = (Customer.lastId + 1).ToString();

            lbl4ToTextBox.Show();
            textBox4.Show();
            textBox4.ReadOnly = false;
            textBox4.Text = String.Empty;

            buttonSave.Show();
            //   Customer temp = new Customer(Customer.lastId + 1, "Grzegorz", "Brzęczyszczykiewicz", "brzeczyszczykiewiczg@gmail.com");
            //   var repo = new CustomerRepository().Add(temp);
            //   listBoxListOfCustomers.DataSource = repo;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            HideSingleCustomerData();
            Customer customer = (Customer)listBoxListOfCustomers.SelectedItem;
            labelTitle3.Show();

            lbl1ToTextBox.Show();
            textBox1.Show();
            textBox1.ReadOnly = false;
            textBox1.Text = customer.FirstName.ToString();
            
            lbl2ToTextBox.Show();
            textBox2.Show();
            textBox2.ReadOnly = false;
            textBox2.Text = customer.Surname.ToString();

            lbl3ToTextBox.Show();
            textBox3.Show();
            textBox3.ReadOnly = true;
            textBox3.Text = customer.CustomerId.ToString();
            
            lbl4ToTextBox.Show();
            textBox4.Show();
            textBox4.ReadOnly = false;
            textBox4.Text = customer.Email.ToString();

            buttonSave.Show();
        }

        private void HideSingleCustomerData()
        {
            labelCustomerFullName.Text = "";
            labelId.Hide();
            labelCustomerId.Text = "";
            labelEmail.Hide();
            labelCustomerEmail.Text = "";
            labelTitle2.Hide();
            labelTitle3.Hide();
            labelTitle4.Hide();

            lbl1ToTextBox.Hide();
            lbl2ToTextBox.Hide();
            lbl3ToTextBox.Hide();
            lbl4ToTextBox.Hide();

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();

            buttonSave.Hide();

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            int id = Int32.Parse(textBox3.Text);
            
            if (id <= Customer.lastId)
            {
                Customer temp = new Customer(id, textBox1.Text, textBox2.Text, textBox4.Text);
                Customer customer = (Customer)listBoxListOfCustomers.SelectedItem;
                var repo = new CustomerRepository().Update(temp);
                listBoxListOfCustomers.DataSource = repo;
            }
            else
            {
                Customer temp = new Customer(id, textBox1.Text, textBox2.Text, textBox4.Text);
                var repo = new CustomerRepository().Add(temp);
                listBoxListOfCustomers.DataSource = repo;
            }
            
            HideSingleCustomerData();
        }





        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }
        private void buttonDisplay_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
