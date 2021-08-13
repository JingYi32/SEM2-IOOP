namespace Week_10_20201014_LAB___EXE_5
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
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowMake = new System.Windows.Forms.Label();
            this.lblShowYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(256, 343);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(149, 52);
            this.btnAcc.TabIndex = 0;
            this.btnAcc.Text = "Accelerate";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(550, 343);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(149, 52);
            this.btnBrake.TabIndex = 1;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(209, 281);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(240, 28);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "Current Speed of the Car:";
            // 
            // lblMake
            // 
            this.lblMake.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(152, 43);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(123, 32);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(152, 95);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(123, 32);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(281, 40);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(342, 45);
            this.txtMake.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(281, 92);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(342, 45);
            this.txtYear.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate the Speed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "";
            // 
            // lblShowMake
            // 
            this.lblShowMake.AutoSize = true;
            this.lblShowMake.Location = new System.Drawing.Point(209, 213);
            this.lblShowMake.Name = "lblShowMake";
            this.lblShowMake.Size = new System.Drawing.Size(66, 28);
            this.lblShowMake.TabIndex = 9;
            this.lblShowMake.Text = "Make:";
            // 
            // lblShowYear
            // 
            this.lblShowYear.AutoSize = true;
            this.lblShowYear.Location = new System.Drawing.Point(209, 247);
            this.lblShowYear.Name = "lblShowYear";
            this.lblShowYear.Size = new System.Drawing.Size(60, 28);
            this.lblShowYear.TabIndex = 10;
            this.lblShowYear.Text = "Year:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 516);
            this.Controls.Add(this.lblShowYear);
            this.Controls.Add(this.lblShowMake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAcc);
            this.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowMake;
        private System.Windows.Forms.Label lblShowYear;
    }
}

