namespace vRaid
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRaidLevel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUsableSpace = new System.Windows.Forms.Label();
            this.labelArraySize = new System.Windows.Forms.Label();
            this.textBoxSizeOfDisks = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfDisks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAID Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRaidLevel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelUsableSpace);
            this.groupBox1.Controls.Add(this.labelArraySize);
            this.groupBox1.Controls.Add(this.textBoxSizeOfDisks);
            this.groupBox1.Controls.Add(this.textBoxNumberOfDisks);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxRaidLevel
            // 
            this.comboBoxRaidLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaidLevel.FormattingEnabled = true;
            this.comboBoxRaidLevel.Location = new System.Drawing.Point(179, 128);
            this.comboBoxRaidLevel.Name = "comboBoxRaidLevel";
            this.comboBoxRaidLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRaidLevel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUsableSpace
            // 
            this.labelUsableSpace.AutoSize = true;
            this.labelUsableSpace.Location = new System.Drawing.Point(176, 226);
            this.labelUsableSpace.Name = "labelUsableSpace";
            this.labelUsableSpace.Size = new System.Drawing.Size(13, 13);
            this.labelUsableSpace.TabIndex = 10;
            this.labelUsableSpace.Text = "0";
            this.labelUsableSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelArraySize
            // 
            this.labelArraySize.AutoSize = true;
            this.labelArraySize.Location = new System.Drawing.Point(176, 197);
            this.labelArraySize.Name = "labelArraySize";
            this.labelArraySize.Size = new System.Drawing.Size(13, 13);
            this.labelArraySize.TabIndex = 9;
            this.labelArraySize.Text = "0";
            this.labelArraySize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSizeOfDisks
            // 
            this.textBoxSizeOfDisks.Location = new System.Drawing.Point(179, 102);
            this.textBoxSizeOfDisks.Name = "textBoxSizeOfDisks";
            this.textBoxSizeOfDisks.Size = new System.Drawing.Size(121, 20);
            this.textBoxSizeOfDisks.TabIndex = 7;
            this.textBoxSizeOfDisks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumberOfDisks
            // 
            this.textBoxNumberOfDisks.Location = new System.Drawing.Point(179, 74);
            this.textBoxNumberOfDisks.Name = "textBoxNumberOfDisks";
            this.textBoxNumberOfDisks.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumberOfDisks.TabIndex = 6;
            this.textBoxNumberOfDisks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usable space";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Array size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raid level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size of disks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of disks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 260);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vRAID-Calculator - Free to use - (c) V41";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRaidLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUsableSpace;
        private System.Windows.Forms.Label labelArraySize;
        private System.Windows.Forms.TextBox textBoxSizeOfDisks;
        private System.Windows.Forms.TextBox textBoxNumberOfDisks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

