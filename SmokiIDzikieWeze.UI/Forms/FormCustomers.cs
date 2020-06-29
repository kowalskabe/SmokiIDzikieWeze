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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            var panel1 = new Forms.ListOfCustomersView();
            var panel2 = new Forms.SingleCustomerView();
            this.splitContainer1.Panel1.Controls.Add(panel1);
            this.splitContainer1.Panel2.Controls.Add(panel2);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            var panel1 = new Forms.ListOfCustomersView();
            var panel2 = new Forms.SingleCustomerView();
            this.splitContainer1.Panel1.Controls.Add(panel1);
            this.splitContainer1.Panel2.Controls.Add(panel2);

        }
    }
}
