using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmokiIDzikieWeze.UI.Forms
{
    public partial class ListOfProductsView : UserControl
    {
        public ListOfProductsView()
        {
            InitializeComponent();
            var repo = new ProductRepository().Retrieve();
            listBoxListOfProducts.DataSource = repo;
        }

        private void listBoxListOfProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
