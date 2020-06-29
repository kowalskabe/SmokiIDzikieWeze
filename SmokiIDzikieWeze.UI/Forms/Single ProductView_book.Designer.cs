namespace SmokiIDzikieWeze.UI.Forms
{
    partial class Single_ProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCustomerEmail = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCustomerFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.Location = new System.Drawing.Point(96, 131);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(304, 17);
            this.labelCustomerEmail.TabIndex = 14;
            this.labelCustomerEmail.Text = "{{ IN CODE }}";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.Location = new System.Drawing.Point(96, 101);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(304, 17);
            this.labelCustomerId.TabIndex = 13;
            this.labelCustomerId.Text = "{{ IN CODE }}";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(26, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 17);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "AUTOR:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(26, 101);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 17);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "ID:";
            // 
            // labelCustomerFullName
            // 
            this.labelCustomerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCustomerFullName.Location = new System.Drawing.Point(25, 65);
            this.labelCustomerFullName.Name = "labelCustomerFullName";
            this.labelCustomerFullName.Size = new System.Drawing.Size(375, 23);
            this.labelCustomerFullName.TabIndex = 10;
            this.labelCustomerFullName.Text = "{{ IN CODE }}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "OPIS:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(93, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(306, 27);
            this.textBox1.TabIndex = 16;
            // 
            // Single_ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCustomerEmail);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelCustomerFullName);
            this.Name = "Single_ProductView";
            this.Size = new System.Drawing.Size(469, 673);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label labelCustomerEmail;
        protected internal System.Windows.Forms.Label labelCustomerId;
        protected internal System.Windows.Forms.Label labelEmail;
        protected internal System.Windows.Forms.Label labelId;
        protected internal System.Windows.Forms.Label labelCustomerFullName;
        protected internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
