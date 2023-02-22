namespace Example_61
{
    partial class MainForm
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
            this.fetchDataButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.dataSurceTextBox = new System.Windows.Forms.TextBox();
            this.sqlQueryLabel = new System.Windows.Forms.Label();
            this.sqlQueryTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fetchMetaData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // fetchDataButton
            //
            this.fetchDataButton.Location = new System.Drawing.Point(262, 394);
            this.fetchDataButton.Name = "fetchDataButton";
            this.fetchDataButton.Size = new System.Drawing.Size(115, 44);
            this.fetchDataButton.TabIndex = 0;
            this.fetchDataButton.Text = "Fetch Data";
            this.fetchDataButton.UseVisualStyleBackColor = true;
            this.fetchDataButton.Click += new System.EventHandler(this.FetchDataButton_Click);
            //
            // outputRichTextBox
            //
            this.outputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputRichTextBox.Location = new System.Drawing.Point(0, 121);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(1103, 256);
            this.outputRichTextBox.TabIndex = 1;
            this.outputRichTextBox.Text = "";
            //
            // dataSourceLabel
            //
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Location = new System.Drawing.Point(12, 24);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(99, 20);
            this.dataSourceLabel.TabIndex = 2;
            this.dataSourceLabel.Text = "Data Source";
            //
            // dataSurceTextBox
            //
            this.dataSurceTextBox.Location = new System.Drawing.Point(132, 24);
            this.dataSurceTextBox.Name = "dataSurceTextBox";
            this.dataSurceTextBox.Size = new System.Drawing.Size(633, 26);
            this.dataSurceTextBox.TabIndex = 3;
            this.dataSurceTextBox.Text = "D:\\Study\\Windows\\Northwind.mdb";
            //
            // sqlQueryLabel
            //
            this.sqlQueryLabel.AutoSize = true;
            this.sqlQueryLabel.Location = new System.Drawing.Point(12, 73);
            this.sqlQueryLabel.Name = "sqlQueryLabel";
            this.sqlQueryLabel.Size = new System.Drawing.Size(87, 20);
            this.sqlQueryLabel.TabIndex = 4;
            this.sqlQueryLabel.Text = "SQL Query";
            //
            // sqlQueryTextBox
            //
            this.sqlQueryTextBox.Location = new System.Drawing.Point(132, 73);
            this.sqlQueryTextBox.Name = "sqlQueryTextBox";
            this.sqlQueryTextBox.Size = new System.Drawing.Size(633, 26);
            this.sqlQueryTextBox.TabIndex = 5;
            this.sqlQueryTextBox.Text = "SELECT FirstName, LastName  FROM Employees";
            //
            // exitButton
            //
            this.exitButton.Location = new System.Drawing.Point(667, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 44);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            //
            // clearButton
            //
            this.clearButton.Location = new System.Drawing.Point(546, 394);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 44);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clrear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            //
            // fetchMetaData
            //
            this.fetchMetaData.Location = new System.Drawing.Point(383, 394);
            this.fetchMetaData.Name = "fetchMetaData";
            this.fetchMetaData.Size = new System.Drawing.Size(157, 44);
            this.fetchMetaData.TabIndex = 8;
            this.fetchMetaData.Text = "Fetch Meta Data";
            this.fetchMetaData.UseVisualStyleBackColor = true;
            this.fetchMetaData.Click += new System.EventHandler(this.FetchMetaData_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 454);
            this.Controls.Add(this.fetchMetaData);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sqlQueryTextBox);
            this.Controls.Add(this.sqlQueryLabel);
            this.Controls.Add(this.dataSurceTextBox);
            this.Controls.Add(this.dataSourceLabel);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.fetchDataButton);
            this.Name = "MainForm";
            this.Text = "Example 6-1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchDataButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Label dataSourceLabel;
        private System.Windows.Forms.TextBox dataSurceTextBox;
        private System.Windows.Forms.Label sqlQueryLabel;
        private System.Windows.Forms.TextBox sqlQueryTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fetchMetaData;
    }
}