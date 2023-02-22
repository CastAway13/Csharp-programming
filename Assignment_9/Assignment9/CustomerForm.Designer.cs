
namespace Assignment9
{
    partial class CustomerForm
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
            this.customerId = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.customerFlightId = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerFlightIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerId
            // 
            this.customerId.AutoSize = true;
            this.customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerId.Location = new System.Drawing.Point(225, 86);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(38, 20);
            this.customerId.TabIndex = 0;
            this.customerId.Text = "ID:  ";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(225, 133);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(59, 20);
            this.customerName.TabIndex = 1;
            this.customerName.Text = "Name: ";
            // 
            // customerFlightId
            // 
            this.customerFlightId.AutoSize = true;
            this.customerFlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFlightId.Location = new System.Drawing.Point(225, 177);
            this.customerFlightId.Name = "customerFlightId";
            this.customerFlightId.Size = new System.Drawing.Size(77, 20);
            this.customerFlightId.TabIndex = 2;
            this.customerFlightId.Text = "Flight ID: ";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(325, 86);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(152, 20);
            this.customerIdTextBox.TabIndex = 3;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(325, 133);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // CustomerFlightIdTextBox
            // 
            this.CustomerFlightIdTextBox.Location = new System.Drawing.Point(325, 177);
            this.CustomerFlightIdTextBox.Name = "CustomerFlightIdTextBox";
            this.CustomerFlightIdTextBox.Size = new System.Drawing.Size(152, 20);
            this.CustomerFlightIdTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(302, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerFlightIdTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.customerFlightId);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.customerId);
            this.Name = "CustomerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerId;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label customerFlightId;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox CustomerFlightIdTextBox;
        private System.Windows.Forms.Button button1;
    }
}