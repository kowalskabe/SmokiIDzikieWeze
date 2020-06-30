namespace SmokiIDzikieWeze.UI.Forms
{
    partial class FormProducts
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.listBoxListOfProducts = new System.Windows.Forms.ListBox();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelNew = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.radioButtonBook = new System.Windows.Forms.RadioButton();
            this.radioButtonEbook = new System.Windows.Forms.RadioButton();
            this.richTextBoxDecs = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRemove);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxListOfProducts);
            this.splitContainer1.Panel1.Controls.Add(this.panelTitle);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxDecs);
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonEbook);
            this.splitContainer1.Panel2.Controls.Add(this.radioButtonBook);
            this.splitContainer1.Panel2.Controls.Add(this.labelNumber);
            this.splitContainer1.Panel2.Controls.Add(this.labelCurrentPrice);
            this.splitContainer1.Panel2.Controls.Add(this.labelName);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel2.Controls.Add(this.labelDescription);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTitle);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPrice);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNum);
            this.splitContainer1.Panel2.Controls.Add(this.labelNew);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 511);
            this.splitContainer1.SplitterDistance = 644;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(644, 100);
            this.panelTitle.TabIndex = 9;
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle1.ForeColor = System.Drawing.Color.Black;
            this.labelTitle1.Location = new System.Drawing.Point(25, 25);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(159, 21);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "LISTA PRODUKTÓW";
            // 
            // listBoxListOfProducts
            // 
            this.listBoxListOfProducts.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxListOfProducts.FormattingEnabled = true;
            this.listBoxListOfProducts.HorizontalScrollbar = true;
            this.listBoxListOfProducts.ItemHeight = 21;
            this.listBoxListOfProducts.Location = new System.Drawing.Point(12, 106);
            this.listBoxListOfProducts.Name = "listBoxListOfProducts";
            this.listBoxListOfProducts.Size = new System.Drawing.Size(600, 298);
            this.listBoxListOfProducts.TabIndex = 10;
            this.listBoxListOfProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxListOfProducts_SelectedIndexChanged);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(24, 106);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(377, 298);
            this.richTextBoxInfo.TabIndex = 11;
            this.richTextBoxInfo.Text = "";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemove.Location = new System.Drawing.Point(12, 444);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(118, 32);
            this.buttonRemove.TabIndex = 15;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(136, 444);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 32);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNew.Location = new System.Drawing.Point(24, 25);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(63, 21);
            this.labelNew.TabIndex = 12;
            this.labelNew.Text = "DODAJ";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(287, 372);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 32);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(25, 221);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(51, 21);
            this.labelDescription.TabIndex = 34;
            this.labelDescription.Text = "OPIS:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(178, 106);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(223, 22);
            this.textBoxTitle.TabIndex = 33;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(178, 143);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(223, 22);
            this.textBoxPrice.TabIndex = 32;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(178, 183);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(223, 22);
            this.textBoxNum.TabIndex = 30;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(25, 107);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 21);
            this.labelName.TabIndex = 39;
            this.labelName.Text = "TYTUŁ:";
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentPrice.Location = new System.Drawing.Point(25, 144);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(58, 21);
            this.labelCurrentPrice.TabIndex = 40;
            this.labelCurrentPrice.Text = "CENA:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumber.Location = new System.Drawing.Point(25, 182);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(127, 21);
            this.labelNumber.TabIndex = 41;
            this.labelNumber.Text = "LICZBA STRON:";
            // 
            // radioButtonBook
            // 
            this.radioButtonBook.AutoSize = true;
            this.radioButtonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonBook.Location = new System.Drawing.Point(178, 25);
            this.radioButtonBook.Name = "radioButtonBook";
            this.radioButtonBook.Size = new System.Drawing.Size(89, 24);
            this.radioButtonBook.TabIndex = 42;
            this.radioButtonBook.TabStop = true;
            this.radioButtonBook.Text = "Książka";
            this.radioButtonBook.UseVisualStyleBackColor = true;
            // 
            // radioButtonEbook
            // 
            this.radioButtonEbook.AutoSize = true;
            this.radioButtonEbook.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonEbook.Location = new System.Drawing.Point(178, 52);
            this.radioButtonEbook.Name = "radioButtonEbook";
            this.radioButtonEbook.Size = new System.Drawing.Size(77, 25);
            this.radioButtonEbook.TabIndex = 43;
            this.radioButtonEbook.TabStop = true;
            this.radioButtonEbook.Text = "Ebook";
            this.radioButtonEbook.UseVisualStyleBackColor = true;
            this.radioButtonEbook.CheckedChanged += new System.EventHandler(this.radioButtonEbook_CheckedChanged);
            // 
            // richTextBoxDecs
            // 
            this.richTextBoxDecs.Location = new System.Drawing.Point(137, 221);
            this.richTextBoxDecs.Name = "richTextBoxDecs";
            this.richTextBoxDecs.Size = new System.Drawing.Size(264, 130);
            this.richTextBoxDecs.TabIndex = 44;
            this.richTextBoxDecs.Text = "";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormProducts";
            this.Text = "BAZA PRODUKTÓW";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle1;
        protected internal System.Windows.Forms.ListBox listBoxListOfProducts;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        protected internal System.Windows.Forms.Button buttonRemove;
        protected internal System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelNew;
        private System.Windows.Forms.RichTextBox richTextBoxDecs;
        private System.Windows.Forms.RadioButton radioButtonEbook;
        private System.Windows.Forms.RadioButton radioButtonBook;
        protected internal System.Windows.Forms.Label labelNumber;
        protected internal System.Windows.Forms.Label labelCurrentPrice;
        protected internal System.Windows.Forms.Label labelName;
        protected internal System.Windows.Forms.Button buttonSave;
        protected internal System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxNum;
    }
}