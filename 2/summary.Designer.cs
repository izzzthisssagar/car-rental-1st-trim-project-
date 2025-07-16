namespace _2
{
    partial class summary
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
            lblName = new Label();
            lblAddress = new Label();
            lblAge = new Label();
            lblDays = new Label();
            lblCarType = new Label();
            lblFuelType = new Label();
            lblMileage = new Label();
            lblBreakdown = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(130, 97);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(130, 132);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(50, 20);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "label2";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(130, 165);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(50, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "label3";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(130, 200);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(50, 20);
            lblDays.TabIndex = 3;
            lblDays.Text = "label4";
            // 
            // lblCarType
            // 
            lblCarType.AutoSize = true;
            lblCarType.Location = new Point(130, 242);
            lblCarType.Name = "lblCarType";
            lblCarType.Size = new Size(50, 20);
            lblCarType.TabIndex = 4;
            lblCarType.Text = "label5";
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(130, 278);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(50, 20);
            lblFuelType.TabIndex = 5;
            lblFuelType.Text = "label6";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(130, 318);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(50, 20);
            lblMileage.TabIndex = 6;
            lblMileage.Text = "label7";
            // 
            // lblBreakdown
            // 
            lblBreakdown.AutoSize = true;
            lblBreakdown.Location = new Point(130, 352);
            lblBreakdown.Name = "lblBreakdown";
            lblBreakdown.Size = new Size(50, 20);
            lblBreakdown.TabIndex = 7;
            lblBreakdown.Text = "label8";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(130, 387);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label9";
            // 
            // summary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(lblTotal);
            Controls.Add(lblBreakdown);
            Controls.Add(lblMileage);
            Controls.Add(lblFuelType);
            Controls.Add(lblCarType);
            Controls.Add(lblDays);
            Controls.Add(lblAge);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "summary";
            Text = "summary";
          //  Load += summary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private Label lblAge;
        private Label lblDays;
        private Label lblCarType;
        private Label lblFuelType;
        private Label lblMileage;
        private Label lblBreakdown;
        private Label lblTotal;
    }
}