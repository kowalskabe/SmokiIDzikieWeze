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
    public partial class ListOfCustomersView : UserControl
    {
        public ListOfCustomersView()
        {
            InitializeComponent();
            var repo = new CustomerRepository().Retrieve();
            listBoxListOfCustomers.DataSource = repo;
        }

        private void listBoxListOfCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
