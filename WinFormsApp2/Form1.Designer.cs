
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recognizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodOfIssuing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassportNo = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxGivenName = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNationality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdentificationNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDateOfIssue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDateOfExpiry = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAuthority = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMRZ1 = new System.Windows.Forms.TextBox();
            this.textBoxMRZ2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1394, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.recognizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // recognizeToolStripMenuItem
            // 
            this.recognizeToolStripMenuItem.Name = "recognizeToolStripMenuItem";
            this.recognizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recognizeToolStripMenuItem.Text = "Распознать";
            this.recognizeToolStripMenuItem.Click += new System.EventHandler(this.RecognizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(751, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxType.Location = new System.Drawing.Point(810, 46);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(114, 34);
            this.textBoxType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(751, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code of issuing";
            // 
            // textBoxCodOfIssuing
            // 
            this.textBoxCodOfIssuing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodOfIssuing.Location = new System.Drawing.Point(903, 88);
            this.textBoxCodOfIssuing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCodOfIssuing.Name = "textBoxCodOfIssuing";
            this.textBoxCodOfIssuing.Size = new System.Drawing.Size(114, 34);
            this.textBoxCodOfIssuing.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(751, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Passport No.";
            // 
            // textBoxPassportNo
            // 
            this.textBoxPassportNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassportNo.Location = new System.Drawing.Point(879, 129);
            this.textBoxPassportNo.Name = "textBoxPassportNo";
            this.textBoxPassportNo.Size = new System.Drawing.Size(125, 34);
            this.textBoxPassportNo.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(846, 171);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(125, 34);
            this.textBoxSurname.TabIndex = 11;
            // 
            // textBoxGivenName
            // 
            this.textBoxGivenName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGivenName.Location = new System.Drawing.Point(872, 211);
            this.textBoxGivenName.Name = "textBoxGivenName";
            this.textBoxGivenName.Size = new System.Drawing.Size(125, 34);
            this.textBoxGivenName.TabIndex = 12;
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(880, 291);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(125, 34);
            this.textBoxDateOfBirth.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(751, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(751, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Given name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(751, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date of birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(751, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nationality";
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNationality.Location = new System.Drawing.Point(866, 251);
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(218, 34);
            this.textBoxNationality.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(751, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Identification No.";
            // 
            // textBoxIdentificationNo
            // 
            this.textBoxIdentificationNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdentificationNo.Location = new System.Drawing.Point(920, 331);
            this.textBoxIdentificationNo.Name = "textBoxIdentificationNo";
            this.textBoxIdentificationNo.Size = new System.Drawing.Size(222, 34);
            this.textBoxIdentificationNo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(751, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sex";
            // 
            // textBoxSex
            // 
            this.textBoxSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSex.Location = new System.Drawing.Point(799, 371);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.Size = new System.Drawing.Size(125, 34);
            this.textBoxSex.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(751, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Place of birth";
            // 
            // textBoxPlaceOfBirth
            // 
            this.textBoxPlaceOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPlaceOfBirth.Location = new System.Drawing.Point(884, 411);
            this.textBoxPlaceOfBirth.Name = "textBoxPlaceOfBirth";
            this.textBoxPlaceOfBirth.Size = new System.Drawing.Size(233, 34);
            this.textBoxPlaceOfBirth.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(751, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "Date of issue";
            // 
            // textBoxDateOfIssue
            // 
            this.textBoxDateOfIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDateOfIssue.Location = new System.Drawing.Point(880, 451);
            this.textBoxDateOfIssue.Name = "textBoxDateOfIssue";
            this.textBoxDateOfIssue.Size = new System.Drawing.Size(137, 34);
            this.textBoxDateOfIssue.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(751, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 28);
            this.label12.TabIndex = 27;
            this.label12.Text = "Date of expiry";
            // 
            // textBoxDateOfExpiry
            // 
            this.textBoxDateOfExpiry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDateOfExpiry.Location = new System.Drawing.Point(891, 491);
            this.textBoxDateOfExpiry.Name = "textBoxDateOfExpiry";
            this.textBoxDateOfExpiry.Size = new System.Drawing.Size(125, 34);
            this.textBoxDateOfExpiry.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(751, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 28);
            this.label13.TabIndex = 29;
            this.label13.Text = "Authority";
            // 
            // textBoxAuthority
            // 
            this.textBoxAuthority.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAuthority.Location = new System.Drawing.Point(846, 531);
            this.textBoxAuthority.Name = "textBoxAuthority";
            this.textBoxAuthority.Size = new System.Drawing.Size(361, 34);
            this.textBoxAuthority.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(751, 574);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 28);
            this.label14.TabIndex = 31;
            this.label14.Text = "MRZ";
            // 
            // textBoxMRZ1
            // 
            this.textBoxMRZ1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMRZ1.Location = new System.Drawing.Point(810, 571);
            this.textBoxMRZ1.Name = "textBoxMRZ1";
            this.textBoxMRZ1.Size = new System.Drawing.Size(572, 34);
            this.textBoxMRZ1.TabIndex = 32;
            // 
            // textBoxMRZ2
            // 
            this.textBoxMRZ2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMRZ2.Location = new System.Drawing.Point(810, 612);
            this.textBoxMRZ2.Name = "textBoxMRZ2";
            this.textBoxMRZ2.Size = new System.Drawing.Size(572, 34);
            this.textBoxMRZ2.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 875);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(732, 875);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 921);
            this.Controls.Add(this.textBoxMRZ2);
            this.Controls.Add(this.textBoxMRZ1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxAuthority);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxDateOfExpiry);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxDateOfIssue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxPlaceOfBirth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxIdentificationNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNationality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.textBoxGivenName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxPassportNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodOfIssuing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Passportreader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodOfIssuing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassportNo;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxGivenName;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNationality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIdentificationNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPlaceOfBirth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDateOfIssue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDateOfExpiry;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAuthority;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMRZ1;
        private System.Windows.Forms.TextBox textBoxMRZ2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recognizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

