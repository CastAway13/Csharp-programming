namespace Example_62
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
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.dataSurceTextBox = new System.Windows.Forms.TextBox();
            this.sqlQueryLabel = new System.Windows.Forms.Label();
            this.sqlQueryTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.fetchMetaData = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.InsertDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.dataSurceTextBox.Text = "C:\\Temp\\DB\\Northwind.mdb";
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
            this.sqlQueryTextBox.Text = "SELECT EmployeeID, LastName, FirstName, Title  FROM Employees";
            //
            // exitButton
            //
            this.exitButton.Location = new System.Drawing.Point(458, 543);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 44);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            //
            // clearButton
            //
            this.clearButton.Location = new System.Drawing.Point(326, 543);
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
            // dataGridView
            //
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 119);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1074, 256);
            this.dataGridView.TabIndex = 9;
            //
            // InsertDataButton
            //
            this.InsertDataButton.Location = new System.Drawing.Point(570, 394);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(115, 44);
            this.InsertDataButton.TabIndex = 10;
            this.InsertDataButton.Text = "Insert Data";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 622);
            this.Controls.Add(this.InsertDataButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.fetchMetaData);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sqlQueryTextBox);
            this.Controls.Add(this.sqlQueryLabel);
            this.Controls.Add(this.dataSurceTextBox);
            this.Controls.Add(this.dataSourceLabel);
            this.Controls.Add(this.fetchDataButton);
            this.Name = "MainForm";
            this.Text = "Example 6-2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fetchDataButton;
        private System.Windows.Forms.Label dataSourceLabel;
        private System.Windows.Forms.TextBox dataSurceTextBox;
        private System.Windows.Forms.Label sqlQueryLabel;
        private System.Windows.Forms.TextBox sqlQueryTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fetchMetaData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button InsertDataButton;
    }
}