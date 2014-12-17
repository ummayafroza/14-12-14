namespace CitizenInfoApp
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idInputTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.findIdTextBox = new System.Windows.Forms.TextBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(338, 97);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details";
            // 
            // idInputTextBox
            // 
            this.idInputTextBox.Location = new System.Drawing.Point(122, 21);
            this.idInputTextBox.Name = "idInputTextBox";
            this.idInputTextBox.Size = new System.Drawing.Size(192, 20);
            this.idInputTextBox.TabIndex = 3;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(122, 58);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(192, 62);
            this.detailsTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(338, 167);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Serach";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 167);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(16, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Id";
            // 
            // findIdTextBox
            // 
            this.findIdTextBox.Location = new System.Drawing.Point(122, 167);
            this.findIdTextBox.Name = "findIdTextBox";
            this.findIdTextBox.Size = new System.Drawing.Size(192, 20);
            this.findIdTextBox.TabIndex = 8;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(122, 223);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(170, 69);
            this.showAllButton.TabIndex = 9;
            this.showAllButton.Text = "Show All Citizen";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 313);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.findIdTextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.idInputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "Form1";
            this.Text = "CitizenInfoApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idInputTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox findIdTextBox;
        private System.Windows.Forms.Button showAllButton;
    }
}

