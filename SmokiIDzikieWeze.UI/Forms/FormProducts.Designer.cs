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
            this.splitContainer1.Panel1.Controls.Add(this.listBoxListOfProducts);
            this.splitContainer1.Panel1.Controls.Add(this.panelTitle);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
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
    }
}