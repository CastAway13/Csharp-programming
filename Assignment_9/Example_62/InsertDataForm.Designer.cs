namespace Example_62
{
    partial class InsertDataForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // firstNameLabel
            //
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(137, 91);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            //
            // lastNameLabel
            //
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(137, 139);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(137, 186);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            //
            // firstNameTextBox
            //
            this.firstNameTextBox.Location = new System.Drawing.Point(269, 91);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(330, 26);
            this.firstNameTextBox.TabIndex = 3;
            //
            // lastNameTextBox
            //
            this.lastNameTextBox.Location = new System.Drawing.Point(269, 139);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(330, 26);
            this.lastNameTextBox.TabIndex = 4;
            //
            // titleTextBox
            //
            this.titleTextBox.Location = new System.Drawing.Point(269, 186);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(330, 26);
            this.titleTextBox.TabIndex = 5;
            //
            // insertButton
            //
            this.insertButton.Location = new System.Drawing.Point(269, 303);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(142, 37);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Insert Data";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            //
            // backButton
            //
            this.backButton.Location = new System.Drawing.Point(457, 303);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(142, 37);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            //
            // employeeIDTextBox
            //
            this.employeeIDTextBox.Location = new System.Drawing.Point(269, 51);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(330, 26);
            this.employeeIDTextBox.TabIndex = 9;
            //
            // IdLabel
            //
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(137, 51);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(100, 20);
            this.IdLabel.TabIndex = 8;
            this.IdLabel.Text = "Employee ID";
            //
            // InsertDataForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "InsertDataForm";
            this.Text = "Insert Data Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.Label IdLabel;
    }
}