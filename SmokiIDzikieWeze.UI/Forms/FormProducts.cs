using System;
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
            HideSingleProductData();
            richTextBoxInfo.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxListOfProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = (Product)listBoxListOfProducts.SelectedItem;
            richTextBoxInfo.Text = product.Info();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            HideSingleProductData();
            ShowNewProductForm();
            radioButtonBook.Checked = true;
        }

        private void HideSingleProductData()
        {
            richTextBoxInfo.Hide();
            labelNew.Hide();
            labelName.Hide();
            labelNumber.Hide();
            labelCurrentPrice.Hide();
            labelDescription.Hide();
            textBoxTitle.Hide();
            textBoxPrice.Hide();
            textBoxNum.Hide();
            richTextBoxDecs.Hide();
            radioButtonBook.Hide();
            radioButtonEbook.Hide();
            buttonSave.Hide();
        }
        private void ShowNewProductForm()
        {
            labelNew.Show();
            labelName.Show();
            labelNumber.Show();
            labelCurrentPrice.Show();
            labelDescription.Show();
            textBoxTitle.Show();
            textBoxPrice.Show();
            textBoxNum.Show();
            richTextBoxDecs.Show();
            radioButtonBook.Show();
            radioButtonEbook.Show();
            buttonSave.Show();
        }

        private void radioButtonEbook_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonEbook.Checked)
                labelNumber.Text = "LICZBA STRON:";
            else { labelNumber.Text = "CZAS TRWANIA:"; }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int id = Product.NumberOfProducts + 1;
            

            if(radioButtonBook.Checked)
            {
                Product temp = new Book(id, textBoxTitle.Text, double.Parse(textBoxPrice.Text), richTextBoxDecs.Text, int.Parse(textBoxNum.Text));
                var repo = new ProductRepository().Add(temp, 0);
                listBoxListOfProducts.DataSource = repo;
            }
            if (radioButtonEbook.Checked)
            {
                Product temp = new Ebook(id, textBoxTitle.Text, double.Parse(textBoxPrice.Text), richTextBoxDecs.Text, int.Parse(textBoxNum.Text));     
                var repo = new ProductRepository().Add(temp, 1);
                listBoxListOfProducts.DataSource = repo;
            }

            ClearAllTextBoxes();
            HideSingleProductData();
            richTextBoxInfo.Show();
        }

        private void ClearAllTextBoxes()
        {
            textBoxTitle.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxNum.Text = string.Empty;
            richTextBoxDecs.Text = string.Empty;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            HideSingleProductData();
            Product product = (Product)listBoxListOfProducts.SelectedItem;
            int i = product.ProductId;

            var repo = new ProductRepository().Delete(i);
            listBoxListOfProducts.DataSource = repo;
            HideSingleProductData();
            richTextBoxInfo.Show();
        }
    }
}
