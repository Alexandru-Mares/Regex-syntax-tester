namespace regex_test
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
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_email_exclusion = new System.Windows.Forms.Button();
            this.btn_phone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(317, 40);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(221, 20);
            this.txtPattern.TabIndex = 0;
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(362, 104);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(75, 23);
            this.btn_Test.TabIndex = 1;
            this.btn_Test.Text = "button1";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(317, 67);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(221, 20);
            this.txtText.TabIndex = 2;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(270, 40);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 3;
            this.lblPattern.Text = "Pattern";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(273, 73);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(362, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(13, 29);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(75, 41);
            this.btn_email.TabIndex = 6;
            this.btn_email.Text = "Email";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // btn_email_exclusion
            // 
            this.btn_email_exclusion.Location = new System.Drawing.Point(112, 28);
            this.btn_email_exclusion.Name = "btn_email_exclusion";
            this.btn_email_exclusion.Size = new System.Drawing.Size(75, 42);
            this.btn_email_exclusion.TabIndex = 7;
            this.btn_email_exclusion.Text = "Email Exclusion";
            this.btn_email_exclusion.UseVisualStyleBackColor = true;
            this.btn_email_exclusion.Click += new System.EventHandler(this.btn_email_exclusion_Click);
            // 
            // btn_phone
            // 
            this.btn_phone.Location = new System.Drawing.Point(13, 86);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(75, 41);
            this.btn_phone.TabIndex = 8;
            this.btn_phone.Text = "Phone Number";
            this.btn_phone.UseVisualStyleBackColor = true;
            this.btn_phone.Click += new System.EventHandler(this.btn_phone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.btn_phone);
            this.Controls.Add(this.btn_email_exclusion);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.txtPattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btn_email_exclusion;
        private System.Windows.Forms.Button btn_phone;
    }
}

