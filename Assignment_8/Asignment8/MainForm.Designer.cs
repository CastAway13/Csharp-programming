
namespace Asignment8
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
            this.flightId = new System.Windows.Forms.Label();
            this.origin = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.FlightIdTextBox = new System.Windows.Forms.TextBox();
            this.OriginTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flightId
            // 
            this.flightId.AutoSize = true;
            this.flightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightId.Location = new System.Drawing.Point(122, 78);
            this.flightId.Name = "flightId";
            this.flightId.Size = new System.Drawing.Size(86, 25);
            this.flightId.TabIndex = 0;
            this.flightId.Text = "Flight Id:";
            // 
            // origin
            // 
            this.origin.AutoSize = true;
            this.origin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.origin.Location = new System.Drawing.Point(122, 119);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(70, 25);
            this.origin.TabIndex = 1;
            this.origin.Text = "Origin:";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(122, 158);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(115, 25);
            this.destination.TabIndex = 2;
            this.destination.Text = "Destination:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(122, 198);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(59, 25);
            this.date.TabIndex = 3;
            this.date.Text = "Date:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(122, 235);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(62, 25);
            this.time.TabIndex = 4;
            this.time.Text = "Time:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(357, 300);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(79, 30);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DateBox
            // 
            this.DateBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.Location = new System.Drawing.Point(304, 203);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(205, 20);
            this.DateBox.TabIndex = 6;
            // 
            // FlightIdTextBox
            // 
            this.FlightIdTextBox.Location = new System.Drawing.Point(304, 83);
            this.FlightIdTextBox.Name = "FlightIdTextBox";
            this.FlightIdTextBox.Size = new System.Drawing.Size(205, 20);
            this.FlightIdTextBox.TabIndex = 7;
            // 
            // OriginTextBox
            // 
            this.OriginTextBox.Location = new System.Drawing.Point(304, 124);
            this.OriginTextBox.Name = "OriginTextBox";
            this.OriginTextBox.Size = new System.Drawing.Size(205, 20);
            this.OriginTextBox.TabIndex = 8;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(304, 163);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(205, 20);
            this.DestinationTextBox.TabIndex = 9;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(304, 240);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(205, 20);
            this.TimeTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.OriginTextBox);
            this.Controls.Add(this.FlightIdTextBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.origin);
            this.Controls.Add(this.flightId);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flightId;
        private System.Windows.Forms.Label origin;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.TextBox FlightIdTextBox;
        private System.Windows.Forms.TextBox OriginTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
    }
}

