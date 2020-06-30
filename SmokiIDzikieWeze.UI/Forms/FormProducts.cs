using System;
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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            var repo = new ProductRepository().Retrieve();
            listBoxListOfProducts.DataSource = repo;
            //HideSingleCustomerData();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxListOfProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = (Product)listBoxListOfProducts.SelectedItem;
            richTextBoxInfo.Text = product.Info();
        }
    }
}
