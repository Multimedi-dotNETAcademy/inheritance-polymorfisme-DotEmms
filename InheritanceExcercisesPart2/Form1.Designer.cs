
namespace InheritanceExcercisesPart2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccountPlus = new System.Windows.Forms.Button();
            this.btnAccountMin = new System.Windows.Forms.Button();
            this.btnSavingPlus = new System.Windows.Forms.Button();
            this.btnSavingMin = new System.Windows.Forms.Button();
            this.btnCurrentPlus = new System.Windows.Forms.Button();
            this.btnCurrentMin = new System.Windows.Forms.Button();
            this.btnInterest = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblSavingsAccount = new System.Windows.Forms.Label();
            this.lblCurrentAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(270, 22);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Savings Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Account";
            // 
            // btnAccountPlus
            // 
            this.btnAccountPlus.Location = new System.Drawing.Point(362, 54);
            this.btnAccountPlus.Name = "btnAccountPlus";
            this.btnAccountPlus.Size = new System.Drawing.Size(75, 42);
            this.btnAccountPlus.TabIndex = 6;
            this.btnAccountPlus.Text = "+";
            this.btnAccountPlus.UseVisualStyleBackColor = true;
            this.btnAccountPlus.Click += new System.EventHandler(this.btnAccountPlus_Click);
            // 
            // btnAccountMin
            // 
            this.btnAccountMin.Location = new System.Drawing.Point(464, 54);
            this.btnAccountMin.Name = "btnAccountMin";
            this.btnAccountMin.Size = new System.Drawing.Size(75, 42);
            this.btnAccountMin.TabIndex = 7;
            this.btnAccountMin.Text = "-";
            this.btnAccountMin.UseVisualStyleBackColor = true;
            this.btnAccountMin.Click += new System.EventHandler(this.btnAccountMin_Click);
            // 
            // btnSavingPlus
            // 
            this.btnSavingPlus.Location = new System.Drawing.Point(362, 164);
            this.btnSavingPlus.Name = "btnSavingPlus";
            this.btnSavingPlus.Size = new System.Drawing.Size(75, 42);
            this.btnSavingPlus.TabIndex = 8;
            this.btnSavingPlus.Text = "+";
            this.btnSavingPlus.UseVisualStyleBackColor = true;
            this.btnSavingPlus.Click += new System.EventHandler(this.btnSavingPlus_Click);
            // 
            // btnSavingMin
            // 
            this.btnSavingMin.Location = new System.Drawing.Point(464, 164);
            this.btnSavingMin.Name = "btnSavingMin";
            this.btnSavingMin.Size = new System.Drawing.Size(75, 42);
            this.btnSavingMin.TabIndex = 9;
            this.btnSavingMin.Text = "-";
            this.btnSavingMin.UseVisualStyleBackColor = true;
            this.btnSavingMin.Click += new System.EventHandler(this.btnSavingMin_Click);
            // 
            // btnCurrentPlus
            // 
            this.btnCurrentPlus.Location = new System.Drawing.Point(362, 270);
            this.btnCurrentPlus.Name = "btnCurrentPlus";
            this.btnCurrentPlus.Size = new System.Drawing.Size(75, 42);
            this.btnCurrentPlus.TabIndex = 10;
            this.btnCurrentPlus.Text = "+";
            this.btnCurrentPlus.UseVisualStyleBackColor = true;
            this.btnCurrentPlus.Click += new System.EventHandler(this.btnCurrentPlus_Click);
            // 
            // btnCurrentMin
            // 
            this.btnCurrentMin.Location = new System.Drawing.Point(464, 270);
            this.btnCurrentMin.Name = "btnCurrentMin";
            this.btnCurrentMin.Size = new System.Drawing.Size(75, 42);
            this.btnCurrentMin.TabIndex = 11;
            this.btnCurrentMin.Text = "-";
            this.btnCurrentMin.UseVisualStyleBackColor = true;
            this.btnCurrentMin.Click += new System.EventHandler(this.btnCurrentMin_Click);
            // 
            // btnInterest
            // 
            this.btnInterest.Location = new System.Drawing.Point(566, 164);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(75, 42);
            this.btnInterest.TabIndex = 12;
            this.btnInterest.Text = "Interest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(47, 98);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(46, 17);
            this.lblAccount.TabIndex = 13;
            this.lblAccount.Text = "label4";
            // 
            // lblSavingsAccount
            // 
            this.lblSavingsAccount.AutoSize = true;
            this.lblSavingsAccount.Location = new System.Drawing.Point(47, 209);
            this.lblSavingsAccount.Name = "lblSavingsAccount";
            this.lblSavingsAccount.Size = new System.Drawing.Size(46, 17);
            this.lblSavingsAccount.TabIndex = 14;
            this.lblSavingsAccount.Text = "label5";
            // 
            // lblCurrentAccount
            // 
            this.lblCurrentAccount.AutoSize = true;
            this.lblCurrentAccount.Location = new System.Drawing.Point(47, 314);
            this.lblCurrentAccount.Name = "lblCurrentAccount";
            this.lblCurrentAccount.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentAccount.TabIndex = 15;
            this.lblCurrentAccount.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCurrentAccount);
            this.Controls.Add(this.lblSavingsAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnInterest);
            this.Controls.Add(this.btnCurrentMin);
            this.Controls.Add(this.btnCurrentPlus);
            this.Controls.Add(this.btnSavingMin);
            this.Controls.Add(this.btnSavingPlus);
            this.Controls.Add(this.btnAccountMin);
            this.Controls.Add(this.btnAccountPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAccountPlus;
        private System.Windows.Forms.Button btnAccountMin;
        private System.Windows.Forms.Button btnSavingPlus;
        private System.Windows.Forms.Button btnSavingMin;
        private System.Windows.Forms.Button btnCurrentPlus;
        private System.Windows.Forms.Button btnCurrentMin;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblSavingsAccount;
        private System.Windows.Forms.Label lblCurrentAccount;
    }
}

