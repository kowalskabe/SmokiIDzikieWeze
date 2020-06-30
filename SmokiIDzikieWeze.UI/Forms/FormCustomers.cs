﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Customer customer = (Customer)listBoxListOfCustomers.SelectedItem;
            labelTitle2.Show();
            labelCustomerFullName.Text = customer.FullName();
            labelId.Show();
            labelCustomerId.Text = customer.CustomerId.ToString();
            labelEmail.Show();
            labelCustomerEmail.Text = customer.Email;
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
            Customer temp = new Customer(Customer.lastId + 1, "Grzegorz", "Brzęczyszczykiewicz", "brzeczyszczykiewiczg@gmail.com");
            var repo = new CustomerRepository().Add(temp);
            listBoxListOfCustomers.DataSource = repo;
        }
        
        private void HideSingleCustomerData()
        {
            labelCustomerFullName.Text = "";
            labelId.Hide();
            labelCustomerId.Text = "";
            labelEmail.Hide();
            labelCustomerEmail.Text = "";
            labelTitle2.Hide();
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

        
    }
}
