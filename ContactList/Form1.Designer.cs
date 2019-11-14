namespace ContactList
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.pNumber = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(275, 52);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(101, 20);
            this.fName.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(275, 93);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(101, 20);
            this.lName.TabIndex = 4;
            // 
            // pNumber
            // 
            this.pNumber.Location = new System.Drawing.Point(275, 138);
            this.pNumber.Name = "pNumber";
            this.pNumber.Size = new System.Drawing.Size(101, 20);
            this.pNumber.TabIndex = 5;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(275, 214);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(101, 23);
            this.btnAddContact.TabIndex = 6;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(396, 52);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(247, 186);
            this.ContactsListBox.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(568, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.pNumber);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox pNumber;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Button btnDelete;
    }
}

