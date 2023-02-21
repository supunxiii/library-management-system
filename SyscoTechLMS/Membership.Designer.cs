namespace SyscoTechLMS
{
    partial class Membership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membership));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLevelA = new System.Windows.Forms.Button();
            this.btnLevelB = new System.Windows.Forms.Button();
            this.btnLevelC = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(59, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1231, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your level of membership.";
            // 
            // btnLevelA
            // 
            this.btnLevelA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLevelA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelA.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLevelA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLevelA.Location = new System.Drawing.Point(432, 658);
            this.btnLevelA.Name = "btnLevelA";
            this.btnLevelA.Size = new System.Drawing.Size(394, 135);
            this.btnLevelA.TabIndex = 1;
            this.btnLevelA.Text = "Level A";
            this.btnLevelA.UseVisualStyleBackColor = false;
            this.btnLevelA.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLevelB
            // 
            this.btnLevelB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLevelB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelB.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLevelB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLevelB.Location = new System.Drawing.Point(432, 850);
            this.btnLevelB.Name = "btnLevelB";
            this.btnLevelB.Size = new System.Drawing.Size(394, 135);
            this.btnLevelB.TabIndex = 2;
            this.btnLevelB.Text = "Level B";
            this.btnLevelB.UseVisualStyleBackColor = false;
            this.btnLevelB.Click += new System.EventHandler(this.btnLevelB_Click);
            // 
            // btnLevelC
            // 
            this.btnLevelC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLevelC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelC.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLevelC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLevelC.Location = new System.Drawing.Point(432, 1043);
            this.btnLevelC.Name = "btnLevelC";
            this.btnLevelC.Size = new System.Drawing.Size(394, 135);
            this.btnLevelC.TabIndex = 3;
            this.btnLevelC.Text = "Level C";
            this.btnLevelC.UseVisualStyleBackColor = false;
            this.btnLevelC.Click += new System.EventHandler(this.btnLevelC_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(1007, 1563);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 107);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBack.Location = new System.Drawing.Point(82, 1563);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(454, 107);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<< GO BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SyscoTechLMS.Properties.Resources.membership;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 1778);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLevelC);
            this.Controls.Add(this.btnLevelB);
            this.Controls.Add(this.btnLevelA);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Membership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membership";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLevelA;
        private System.Windows.Forms.Button btnLevelB;
        private System.Windows.Forms.Button btnLevelC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}