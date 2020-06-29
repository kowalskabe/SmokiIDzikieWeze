namespace SmokiIDzikieWeze.UI.Forms
{
    partial class SingleCustomerView
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
            this.SuspendLayout();
            // 
            // labelCustomerEmail
            // 
            this.labelCustomerEmail.Location = new System.Drawing.Point(97, 143);
            this.labelCustomerEmail.Name = "labelCustomerEmail";
            this.labelCustomerEmail.Size = new System.Drawing.Size(304, 17);
            this.labelCustomerEmail.TabIndex = 9;
            this.labelCustomerEmail.Text = "{{ IN CODE }}";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.Location = new System.Drawing.Point(97, 104);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(304, 17);
            this.labelCustomerId.TabIndex = 8;
            this.labelCustomerId.Text = "{{ IN CODE }}";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(26, 143);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 17);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "EMAIL:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(26, 104);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 17);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "ID:";
            // 
            // labelCustomerFullName
            // 
            this.labelCustomerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCustomerFullName.Location = new System.Drawing.Point(25, 65);
            this.labelCustomerFullName.Name = "labelCustomerFullName";
            this.labelCustomerFullName.Size = new System.Drawing.Size(375, 23);
            this.labelCustomerFullName.TabIndex = 5;
            this.labelCustomerFullName.Text = "{{ IN CODE }}";
            // 
            // SingleCustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCustomerEmail);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelCustomerFullName);
            this.Name = "SingleCustomerView";
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
    }
}
