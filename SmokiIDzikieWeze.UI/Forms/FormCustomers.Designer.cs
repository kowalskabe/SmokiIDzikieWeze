using System.Windows.Forms;

namespace SmokiIDzikieWeze.UI.Forms
{
    partial class FormCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxListOfCustomers = new System.Windows.Forms.ListBox();
            this.customerRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCustomerFullName = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelTitle);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxListOfCustomers);
            this.splitContainer1.Panel1.Controls.Add(this.panelButtons);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelTitle2);
            this.splitContainer1.Panel2.Controls.Add(this.labelCustomerEmail);
            this.splitContainer1.Panel2.Controls.Add(this.labelCustomerId);
            this.splitContainer1.Panel2.Controls.Add(this.labelEmail);
            this.splitContainer1.Panel2.Controls.Add(this.labelId);
            this.splitContainer1.Panel2.Controls.Add(this.labelCustomerFullName);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 529);
            this.splitContainer1.SplitterDistance = 610;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxListOfCustomers
            // 
            this.listBoxListOfCustomers.DataSource = this.customerRepositoryBindingSource;
            this.listBoxListOfCustomers.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxListOfCustomers.FormattingEnabled = true;
            this.listBoxListOfCustomers.HorizontalScrollbar = true;
            this.listBoxListOfCustomers.ItemHeight = 21;
            this.listBoxListOfCustomers.Location = new System.Drawing.Point(25, 106);
            this.listBoxListOfCustomers.Name = "listBoxListOfCustomers";
            this.listBoxListOfCustomers.Size = new System.Drawing.Size(600, 298);
            this.listBoxListOfCustomers.TabIndex = 7;
            // 
            // customerRepositoryBindingSource
            // 
            this.customerRepositoryBindingSource.DataSource = typeof(SmokiIDzikieWeze.CustomerRepository);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, -188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "LISTA KLIENTÓW";
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCustomerEmail.Location = new System.Drawing.Point(101, 184);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(304, 65);
            this.labelCustomerEmail.TabIndex = 14;
            this.labelCustomerEmail.Text = "{{ IN CODE }}";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCustomerId.Location = new System.Drawing.Point(101, 145);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(304, 65);
            this.labelCustomerId.TabIndex = 13;
            this.labelCustomerId.Text = "{{ IN CODE }}";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmail.Location = new System.Drawing.Point(30, 184);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 21);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "EMAIL:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(30, 145);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 21);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "ID:";
            // 
            // labelCustomerFullName
            // 
            this.labelCustomerFullName.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCustomerFullName.Location = new System.Drawing.Point(29, 106);
            this.labelCustomerFullName.Name = "labelCustomerFullName";
            this.labelCustomerFullName.Size = new System.Drawing.Size(375, 27);
            this.labelCustomerFullName.TabIndex = 10;
            this.labelCustomerFullName.Text = "{{ IN CODE }}";
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonRemove);
            this.panelButtons.Controls.Add(this.buttonDisplay);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 396);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(610, 133);
            this.panelButtons.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(436, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 32);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.Location = new System.Drawing.Point(294, 20);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(123, 32);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Edytuj";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDisplay.FlatAppearance.BorderSize = 0;
            this.buttonDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplay.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDisplay.Location = new System.Drawing.Point(5, 20);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(120, 32);
            this.buttonDisplay.TabIndex = 12;
            this.buttonDisplay.Text = "Wyświetl";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click_1);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemove.Location = new System.Drawing.Point(149, 20);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(118, 32);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(610, 100);
            this.panelTitle.TabIndex = 8;
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle1.ForeColor = System.Drawing.Color.Black;
            this.labelTitle1.Location = new System.Drawing.Point(25, 25);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(141, 21);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "LISTA KLIENTÓW";
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle2.ForeColor = System.Drawing.Color.Black;
            this.labelTitle2.Location = new System.Drawing.Point(28, 25);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(54, 21);
            this.labelTitle2.TabIndex = 1;
            this.labelTitle2.Text = "DANE";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormCustomers";
            this.Text = "BAZA KLIENTÓW";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
        protected internal Label labelCustomerEmail;
        protected internal Label labelCustomerId;
        protected internal Label labelEmail;
        protected internal Label labelId;
        protected internal Label labelCustomerFullName;
        protected internal ListBox listBoxListOfCustomers;
        protected internal Label label1;
        private BindingSource customerRepositoryBindingSource;
        private Panel panelTitle;
        private Panel panelButtons;
        protected internal Button buttonAdd;
        protected internal Button buttonUpdate;
        protected internal Button buttonRemove;
        protected internal Button buttonDisplay;
        private Label labelTitle1;
        private Label labelTitle2;
    }
}