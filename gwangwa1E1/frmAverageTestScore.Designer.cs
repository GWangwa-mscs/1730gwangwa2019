namespace gwangwa1E1
{
    partial class txtgwangwa_ex1E
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
            this.txtTest1Score = new System.Windows.Forms.TextBox();
            this.txtTest2Score = new System.Windows.Forms.TextBox();
            this.txtTest3Score = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test 3";
            // 
            // txtTest1Score
            // 
            this.txtTest1Score.Location = new System.Drawing.Point(82, 28);
            this.txtTest1Score.Name = "txtTest1Score";
            this.txtTest1Score.Size = new System.Drawing.Size(57, 20);
            this.txtTest1Score.TabIndex = 3;
            this.txtTest1Score.Text = "0";
            this.txtTest1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest2Score
            // 
            this.txtTest2Score.Location = new System.Drawing.Point(82, 54);
            this.txtTest2Score.Name = "txtTest2Score";
            this.txtTest2Score.Size = new System.Drawing.Size(57, 20);
            this.txtTest2Score.TabIndex = 4;
            this.txtTest2Score.Text = "0";
            this.txtTest2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTest3Score
            // 
            this.txtTest3Score.Location = new System.Drawing.Point(82, 80);
            this.txtTest3Score.Name = "txtTest3Score";
            this.txtTest3Score.Size = new System.Drawing.Size(57, 20);
            this.txtTest3Score.TabIndex = 5;
            this.txtTest3Score.Text = "0";
            this.txtTest3Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTest3Score.TextChanged += new System.EventHandler(this.TxtTest3Score_TextChanged);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(82, 127);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(57, 20);
            this.txtAverage.TabIndex = 6;
            this.txtAverage.TabStop = false;
            this.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(177, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 54);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.TxtClear_Click);
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(177, 83);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(75, 23);
            this.txtExit.TabIndex = 9;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.TxtExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average";
            // 
            // txtgwangwa_ex1E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 169);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtTest3Score);
            this.Controls.Add(this.txtTest2Score);
            this.Controls.Add(this.txtTest1Score);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txtgwangwa_ex1E";
            this.Text = "Average Test Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTest1Score;
        private System.Windows.Forms.TextBox txtTest2Score;
        private System.Windows.Forms.TextBox txtTest3Score;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Label label4;
    }
}

