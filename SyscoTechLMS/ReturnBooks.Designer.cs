namespace SyscoTechLMS
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            this.memberTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.membershipTxt = new System.Windows.Forms.TextBox();
            this.returnNumTxt = new System.Windows.Forms.TextBox();
            this.burrowDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.bookCMB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.memberCMB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.issueDGV = new System.Windows.Forms.DataGridView();
            this.returnDGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issueDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // memberTxt
            // 
            this.memberTxt.Location = new System.Drawing.Point(545, 358);
            this.memberTxt.Name = "memberTxt";
            this.memberTxt.Size = new System.Drawing.Size(476, 55);
            this.memberTxt.TabIndex = 32;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(545, 582);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(476, 55);
            this.phoneTxt.TabIndex = 31;
            // 
            // membershipTxt
            // 
            this.membershipTxt.Location = new System.Drawing.Point(545, 470);
            this.membershipTxt.Name = "membershipTxt";
            this.membershipTxt.Size = new System.Drawing.Size(476, 55);
            this.membershipTxt.TabIndex = 30;
            // 
            // returnNumTxt
            // 
            this.returnNumTxt.Location = new System.Drawing.Point(545, 119);
            this.returnNumTxt.Name = "returnNumTxt";
            this.returnNumTxt.Size = new System.Drawing.Size(476, 55);
            this.returnNumTxt.TabIndex = 29;
            this.returnNumTxt.TextChanged += new System.EventHandler(this.returnNumTxt_TextChanged);
            // 
            // burrowDatePicker
            // 
            this.burrowDatePicker.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.burrowDatePicker.Location = new System.Drawing.Point(545, 801);
            this.burrowDatePicker.Name = "burrowDatePicker";
            this.burrowDatePicker.Size = new System.Drawing.Size(522, 55);
            this.burrowDatePicker.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(118, 801);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 55);
            this.label7.TabIndex = 27;
            this.label7.Text = "~Burrow Date";
            // 
            // bookCMB
            // 
            this.bookCMB.FormattingEnabled = true;
            this.bookCMB.Location = new System.Drawing.Point(545, 679);
            this.bookCMB.Name = "bookCMB";
            this.bookCMB.Size = new System.Drawing.Size(363, 56);
            this.bookCMB.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(129, 694);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 55);
            this.label6.TabIndex = 25;
            this.label6.Text = "~Book";
            // 
            // memberCMB
            // 
            this.memberCMB.FormattingEnabled = true;
            this.memberCMB.Location = new System.Drawing.Point(545, 241);
            this.memberCMB.Name = "memberCMB";
            this.memberCMB.Size = new System.Drawing.Size(363, 56);
            this.memberCMB.TabIndex = 24;
            this.memberCMB.SelectionChangeCommitted += new System.EventHandler(this.memberCMB_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(118, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 55);
            this.label5.TabIndex = 23;
            this.label5.Text = "~Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 55);
            this.label4.TabIndex = 22;
            this.label4.Text = "~Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 55);
            this.label3.TabIndex = 21;
            this.label3.Text = "~Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 55);
            this.label2.TabIndex = 20;
            this.label2.Text = "~Membership";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "~Burrow No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(129, 930);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 55);
            this.label8.TabIndex = 33;
            this.label8.Text = "~Return Date";
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.returnDatePicker.Location = new System.Drawing.Point(545, 930);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(522, 55);
            this.returnDatePicker.TabIndex = 34;
            // 
            // issueDGV
            // 
            this.issueDGV.BackgroundColor = System.Drawing.Color.White;
            this.issueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueDGV.Location = new System.Drawing.Point(1157, 119);
            this.issueDGV.Name = "issueDGV";
            this.issueDGV.RowHeadersWidth = 123;
            this.issueDGV.RowTemplate.Height = 57;
            this.issueDGV.Size = new System.Drawing.Size(1506, 770);
            this.issueDGV.TabIndex = 35;
            this.issueDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueDGV_CellContentClick);
            // 
            // returnDGV
            // 
            this.returnDGV.BackgroundColor = System.Drawing.Color.White;
            this.returnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnDGV.Location = new System.Drawing.Point(1166, 1035);
            this.returnDGV.Name = "returnDGV";
            this.returnDGV.RowHeadersWidth = 123;
            this.returnDGV.RowTemplate.Height = 57;
            this.returnDGV.Size = new System.Drawing.Size(1506, 770);
            this.returnDGV.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1653, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(461, 66);
            this.label9.TabIndex = 37;
            this.label9.Text = "Burrowed Books";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1665, 946);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(449, 66);
            this.label10.TabIndex = 38;
            this.label10.Text = "Returned Books";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(545, 1089);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(439, 109);
            this.btnReturn.TabIndex = 39;
            this.btnReturn.Text = "RETURN BOOK";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(88, 1666);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(477, 109);
            this.btnMainMenu.TabIndex = 40;
            this.btnMainMenu.Text = "<< MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SyscoTechLMS.Properties.Resources.returnbooks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2719, 1834);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.returnDGV);
            this.Controls.Add(this.issueDGV);
            this.Controls.Add(this.returnDatePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.memberTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.membershipTxt);
            this.Controls.Add(this.returnNumTxt);
            this.Controls.Add(this.burrowDatePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bookCMB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.memberCMB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBooks";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memberTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox membershipTxt;
        private System.Windows.Forms.TextBox returnNumTxt;
        private System.Windows.Forms.DateTimePicker burrowDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bookCMB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox memberCMB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker returnDatePicker;
        private System.Windows.Forms.DataGridView issueDGV;
        private System.Windows.Forms.DataGridView returnDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMainMenu;
    }
}