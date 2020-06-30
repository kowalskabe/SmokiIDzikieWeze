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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.listBoxListOfCustomers = new System.Windows.Forms.ListBox();
            this.customerRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle3 = new System.Windows.Forms.Label();
            this.lbl1ToTextBox = new System.Windows.Forms.Label();
            this.lbl2ToTextBox = new System.Windows.Forms.Label();
            this.lbl3ToTextBox = new System.Windows.Forms.Label();
            this.lbl4ToTextBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCustomerFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).BeginInit();
            this.panelButtons.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.labelTitle4);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.labelTitle3);
            this.splitContainer1.Panel2.Controls.Add(this.lbl1ToTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.lbl2ToTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.lbl3ToTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.lbl4ToTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
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
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // labelTitle4
            // 
            this.labelTitle4.AutoSize = true;
            this.labelTitle4.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle4.ForeColor = System.Drawing.Color.Black;
            this.labelTitle4.Location = new System.Drawing.Point(35, 25);
            this.labelTitle4.Name = "labelTitle4";
            this.labelTitle4.Size = new System.Drawing.Size(56, 21);
            this.labelTitle4.TabIndex = 25;
            this.labelTitle4.Text = "NOWY";
            this.labelTitle4.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(266, 268);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 32);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTitle3
            // 
            this.labelTitle3.AutoSize = true;
            this.labelTitle3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle3.ForeColor = System.Drawing.Color.Black;
            this.labelTitle3.Location = new System.Drawing.Point(30, 25);
            this.labelTitle3.Name = "labelTitle3";
            this.labelTitle3.Size = new System.Drawing.Size(69, 21);
            this.labelTitle3.TabIndex = 23;
            this.labelTitle3.Text = "EDYTUJ";
            // 
            // lbl1ToTextBox
            // 
            this.lbl1ToTextBox.AutoSize = true;
            this.lbl1ToTextBox.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1ToTextBox.Location = new System.Drawing.Point(28, 107);
            this.lbl1ToTextBox.Name = "lbl1ToTextBox";
            this.lbl1ToTextBox.Size = new System.Drawing.Size(47, 21);
            this.lbl1ToTextBox.TabIndex = 22;
            this.lbl1ToTextBox.Text = "IMIĘ:";
            // 
            // lbl2ToTextBox
            // 
            this.lbl2ToTextBox.AutoSize = true;
            this.lbl2ToTextBox.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2ToTextBox.Location = new System.Drawing.Point(28, 145);
            this.lbl2ToTextBox.Name = "lbl2ToTextBox";
            this.lbl2ToTextBox.Size = new System.Drawing.Size(93, 21);
            this.lbl2ToTextBox.TabIndex = 21;
            this.lbl2ToTextBox.Text = "NAZWISKO";
            // 
            // lbl3ToTextBox
            // 
            this.lbl3ToTextBox.AutoSize = true;
            this.lbl3ToTextBox.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3ToTextBox.Location = new System.Drawing.Point(30, 186);
            this.lbl3ToTextBox.Name = "lbl3ToTextBox";
            this.lbl3ToTextBox.Size = new System.Drawing.Size(30, 21);
            this.lbl3ToTextBox.TabIndex = 20;
            this.lbl3ToTextBox.Text = "ID:";
            // 
            // lbl4ToTextBox
            // 
            this.lbl4ToTextBox.AutoSize = true;
            this.lbl4ToTextBox.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl4ToTextBox.Location = new System.Drawing.Point(28, 221);
            this.lbl4ToTextBox.Name = "lbl4ToTextBox";
            this.lbl4ToTextBox.Size = new System.Drawing.Size(63, 21);
            this.lbl4ToTextBox.TabIndex = 19;
            this.lbl4ToTextBox.Text = "EMAIL:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 220);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 22);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(240, 22);
            this.textBox3.TabIndex = 15;
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
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).EndInit();
            this.panelButtons.ResumeLayout(false);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        protected internal Label lbl1ToTextBox;
        protected internal Label lbl2ToTextBox;
        protected internal Label lbl3ToTextBox;
        protected internal Label lbl4ToTextBox;
        private Label labelTitle3;
        protected internal Button buttonSave;
        private Label labelTitle4;
    }
}