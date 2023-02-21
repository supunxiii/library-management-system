namespace SyscoTechLMS
{
    partial class BurrowBooksLevelC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurrowBooksLevelC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.memberCMB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookCMB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.burrowDatePicker = new System.Windows.Forms.DateTimePicker();
            this.issueDGV = new System.Windows.Forms.DataGridView();
            this.burrowNumTxt = new System.Windows.Forms.TextBox();
            this.membershipTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.memberTxt = new System.Windows.Forms.TextBox();
            this.btnBurrow = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issueDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "~Burrow No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "~Membership";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "~Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "~Member ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "~Phone";
            // 
            // memberCMB
            // 
            this.memberCMB.FormattingEnabled = true;
            this.memberCMB.Location = new System.Drawing.Point(461, 220);
            this.memberCMB.Name = "memberCMB";
            this.memberCMB.Size = new System.Drawing.Size(363, 56);
            this.memberCMB.TabIndex = 6;
            this.memberCMB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.memberCMB.SelectionChangeCommitted += new System.EventHandler(this.memberCMB_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 697);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 55);
            this.label6.TabIndex = 10;
            this.label6.Text = "~Book";
            // 
            // bookCMB
            // 
            this.bookCMB.FormattingEnabled = true;
            this.bookCMB.Location = new System.Drawing.Point(461, 682);
            this.bookCMB.Name = "bookCMB";
            this.bookCMB.Size = new System.Drawing.Size(363, 56);
            this.bookCMB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(77, 809);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 55);
            this.label7.TabIndex = 12;
            this.label7.Text = "~Date";
            // 
            // burrowDatePicker
            // 
            this.burrowDatePicker.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.burrowDatePicker.Location = new System.Drawing.Point(461, 809);
            this.burrowDatePicker.Name = "burrowDatePicker";
            this.burrowDatePicker.Size = new System.Drawing.Size(600, 55);
            this.burrowDatePicker.TabIndex = 13;
            this.burrowDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // issueDGV
            // 
            this.issueDGV.BackgroundColor = System.Drawing.Color.White;
            this.issueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueDGV.Location = new System.Drawing.Point(1096, 879);
            this.issueDGV.Name = "issueDGV";
            this.issueDGV.RowHeadersWidth = 123;
            this.issueDGV.RowTemplate.Height = 57;
            this.issueDGV.Size = new System.Drawing.Size(1506, 832);
            this.issueDGV.TabIndex = 14;
            // 
            // burrowNumTxt
            // 
            this.burrowNumTxt.Location = new System.Drawing.Point(461, 103);
            this.burrowNumTxt.Name = "burrowNumTxt";
            this.burrowNumTxt.Size = new System.Drawing.Size(476, 55);
            this.burrowNumTxt.TabIndex = 15;
            // 
            // membershipTxt
            // 
            this.membershipTxt.Location = new System.Drawing.Point(461, 454);
            this.membershipTxt.Name = "membershipTxt";
            this.membershipTxt.Size = new System.Drawing.Size(476, 55);
            this.membershipTxt.TabIndex = 16;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(461, 583);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(476, 55);
            this.phoneTxt.TabIndex = 17;
            // 
            // memberTxt
            // 
            this.memberTxt.Location = new System.Drawing.Point(461, 348);
            this.memberTxt.Name = "memberTxt";
            this.memberTxt.Size = new System.Drawing.Size(476, 55);
            this.memberTxt.TabIndex = 18;
            // 
            // btnBurrow
            // 
            this.btnBurrow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBurrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurrow.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBurrow.ForeColor = System.Drawing.Color.Black;
            this.btnBurrow.Location = new System.Drawing.Point(461, 936);
            this.btnBurrow.Name = "btnBurrow";
            this.btnBurrow.Size = new System.Drawing.Size(319, 109);
            this.btnBurrow.TabIndex = 19;
            this.btnBurrow.Text = "BURROW";
            this.btnBurrow.UseVisualStyleBackColor = false;
            this.btnBurrow.Click += new System.EventHandler(this.btnBurrow_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Location = new System.Drawing.Point(77, 1602);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(477, 109);
            this.btnMainMenu.TabIndex = 20;
            this.btnMainMenu.Text = "<< MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // BurrowBooksLevelC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SyscoTechLMS.Properties.Resources.burrowbooks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2697, 1804);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnBurrow);
            this.Controls.Add(this.memberTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.membershipTxt);
            this.Controls.Add(this.burrowNumTxt);
            this.Controls.Add(this.issueDGV);
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
            this.Name = "BurrowBooksLevelC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BurrowBooksLevelC";
            this.Load += new System.EventHandler(this.BurrowBooksLevelC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issueDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox memberCMB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bookCMB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker burrowDatePicker;
        private System.Windows.Forms.DataGridView issueDGV;
        private System.Windows.Forms.TextBox burrowNumTxt;
        private System.Windows.Forms.TextBox membershipTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox memberTxt;
        private System.Windows.Forms.Button btnBurrow;
        private System.Windows.Forms.Button btnMainMenu;
    }
}