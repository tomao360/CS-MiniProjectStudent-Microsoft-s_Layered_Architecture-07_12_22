namespace ProjectStudents.UI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.dataInitBtn = new System.Windows.Forms.Button();
            this.enterToDbBtn = new System.Windows.Forms.Button();
            this.getSudentDataBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Data\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.IDTextBox.Location = new System.Drawing.Point(179, 135);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(185, 22);
            this.IDTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.NameTextBox.Location = new System.Drawing.Point(179, 177);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(185, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.AgeTextBox.Location = new System.Drawing.Point(179, 223);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(185, 22);
            this.AgeTextBox.TabIndex = 7;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.AddressTextBox.Location = new System.Drawing.Point(179, 266);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(185, 22);
            this.AddressTextBox.TabIndex = 8;
            // 
            // dataInitBtn
            // 
            this.dataInitBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataInitBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInitBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.dataInitBtn.Location = new System.Drawing.Point(466, 127);
            this.dataInitBtn.Name = "dataInitBtn";
            this.dataInitBtn.Size = new System.Drawing.Size(126, 34);
            this.dataInitBtn.TabIndex = 9;
            this.dataInitBtn.Text = "Data Init";
            this.dataInitBtn.UseVisualStyleBackColor = false;
            this.dataInitBtn.Click += new System.EventHandler(this.dataInitBtn_Click);
            // 
            // enterToDbBtn
            // 
            this.enterToDbBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enterToDbBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterToDbBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.enterToDbBtn.Location = new System.Drawing.Point(466, 167);
            this.enterToDbBtn.Name = "enterToDbBtn";
            this.enterToDbBtn.Size = new System.Drawing.Size(126, 67);
            this.enterToDbBtn.TabIndex = 10;
            this.enterToDbBtn.Text = "Enter To DB";
            this.enterToDbBtn.UseVisualStyleBackColor = false;
            this.enterToDbBtn.Click += new System.EventHandler(this.enterToDbBtn_Click);
            // 
            // getSudentDataBtn
            // 
            this.getSudentDataBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.getSudentDataBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSudentDataBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.getSudentDataBtn.Location = new System.Drawing.Point(466, 240);
            this.getSudentDataBtn.Name = "getSudentDataBtn";
            this.getSudentDataBtn.Size = new System.Drawing.Size(126, 58);
            this.getSudentDataBtn.TabIndex = 11;
            this.getSudentDataBtn.Text = "Get Sudent Data By ID";
            this.getSudentDataBtn.UseVisualStyleBackColor = false;
            this.getSudentDataBtn.Click += new System.EventHandler(this.getSudentDataBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resetBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.resetBtn.Location = new System.Drawing.Point(310, 322);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(126, 36);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.getSudentDataBtn);
            this.Controls.Add(this.enterToDbBtn);
            this.Controls.Add(this.dataInitBtn);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button dataInitBtn;
        private System.Windows.Forms.Button enterToDbBtn;
        private System.Windows.Forms.Button getSudentDataBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

