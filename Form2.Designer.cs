namespace Budget
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxOthers = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBiz = new System.Windows.Forms.TextBox();
            this.textBoxInv = new System.Windows.Forms.TextBox();
            this.textBoxOthersAmt = new System.Windows.Forms.TextBox();
            this.textBoxOthersLbl = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getting Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(634, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check the following source/s of income/s: if it applies. Put the amount in the bo" +
    "x provided.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(171, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Business sales";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(171, 275);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Investment yields";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxOthers
            // 
            this.checkBoxOthers.AutoSize = true;
            this.checkBoxOthers.Location = new System.Drawing.Point(171, 322);
            this.checkBoxOthers.Name = "checkBoxOthers";
            this.checkBoxOthers.Size = new System.Drawing.Size(134, 17);
            this.checkBoxOthers.TabIndex = 5;
            this.checkBoxOthers.Text = "Others (Please specify)";
            this.checkBoxOthers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(337, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type of income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount (in php)";
            // 
            // textBoxBiz
            // 
            this.textBoxBiz.Location = new System.Drawing.Point(451, 222);
            this.textBoxBiz.Name = "textBoxBiz";
            this.textBoxBiz.Size = new System.Drawing.Size(100, 20);
            this.textBoxBiz.TabIndex = 11;
            // 
            // textBoxInv
            // 
            this.textBoxInv.Location = new System.Drawing.Point(451, 275);
            this.textBoxInv.Name = "textBoxInv";
            this.textBoxInv.Size = new System.Drawing.Size(100, 20);
            this.textBoxInv.TabIndex = 12;
            // 
            // textBoxOthersAmt
            // 
            this.textBoxOthersAmt.Location = new System.Drawing.Point(451, 322);
            this.textBoxOthersAmt.Name = "textBoxOthersAmt";
            this.textBoxOthersAmt.Size = new System.Drawing.Size(100, 20);
            this.textBoxOthersAmt.TabIndex = 13;
            // 
            // textBoxOthersLbl
            // 
            this.textBoxOthersLbl.Location = new System.Drawing.Point(299, 322);
            this.textBoxOthersLbl.Name = "textBoxOthersLbl";
            this.textBoxOthersLbl.Size = new System.Drawing.Size(100, 20);
            this.textBoxOthersLbl.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(171, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Salary";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(451, 176);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOthersLbl);
            this.Controls.Add(this.textBoxOthersAmt);
            this.Controls.Add(this.textBoxInv);
            this.Controls.Add(this.textBoxBiz);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxOthers);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxOthers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBiz;
        private System.Windows.Forms.TextBox textBoxInv;
        private System.Windows.Forms.TextBox textBoxOthersAmt;
        private System.Windows.Forms.TextBox textBoxOthersLbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxSalary;
    }
}