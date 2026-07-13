namespace vanderWaltPrac7
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtNoYW = new System.Windows.Forms.TextBox();
            this.txtPrevDebt = new System.Windows.Forms.TextBox();
            this.lstLoyalty = new System.Windows.Forms.ListBox();
            this.lstDebt = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of years worked: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Previous debt:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(186, 55);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 22);
            this.txtEmpName.TabIndex = 3;
            // 
            // txtNoYW
            // 
            this.txtNoYW.Location = new System.Drawing.Point(186, 96);
            this.txtNoYW.Name = "txtNoYW";
            this.txtNoYW.Size = new System.Drawing.Size(100, 22);
            this.txtNoYW.TabIndex = 4;
            // 
            // txtPrevDebt
            // 
            this.txtPrevDebt.Location = new System.Drawing.Point(186, 129);
            this.txtPrevDebt.Name = "txtPrevDebt";
            this.txtPrevDebt.Size = new System.Drawing.Size(100, 22);
            this.txtPrevDebt.TabIndex = 5;
            // 
            // lstLoyalty
            // 
            this.lstLoyalty.FormattingEnabled = true;
            this.lstLoyalty.ItemHeight = 16;
            this.lstLoyalty.Location = new System.Drawing.Point(54, 196);
            this.lstLoyalty.Name = "lstLoyalty";
            this.lstLoyalty.Size = new System.Drawing.Size(420, 228);
            this.lstLoyalty.TabIndex = 6;
            // 
            // lstDebt
            // 
            this.lstDebt.FormattingEnabled = true;
            this.lstDebt.ItemHeight = 16;
            this.lstDebt.Location = new System.Drawing.Point(492, 196);
            this.lstDebt.Name = "lstDebt";
            this.lstDebt.Size = new System.Drawing.Size(480, 228);
            this.lstDebt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Take Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 68);
            this.button2.TabIndex = 9;
            this.button2.Text = "New Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 68);
            this.button3.TabIndex = 10;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 546);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDebt);
            this.Controls.Add(this.lstLoyalty);
            this.Controls.Add(this.txtPrevDebt);
            this.Controls.Add(this.txtNoYW);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TimTam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtNoYW;
        private System.Windows.Forms.TextBox txtPrevDebt;
        private System.Windows.Forms.ListBox lstLoyalty;
        private System.Windows.Forms.ListBox lstDebt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

