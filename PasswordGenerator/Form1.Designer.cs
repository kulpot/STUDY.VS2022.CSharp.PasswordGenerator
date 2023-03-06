namespace PasswordGenerator
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.passwordLengthSlider = new System.Windows.Forms.TrackBar();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(115, 52);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(585, 72);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "loading...";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLengthLabel.Location = new System.Drawing.Point(196, 216);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(418, 72);
            this.PasswordLengthLabel.TabIndex = 1;
            this.PasswordLengthLabel.Text = "Password Length: 5";
            this.PasswordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Location = new System.Drawing.Point(196, 300);
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.Size = new System.Drawing.Size(418, 45);
            this.passwordLengthSlider.TabIndex = 2;
            this.passwordLengthSlider.Scroll += new System.EventHandler(this.passwordLengthSlider_Scroll);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.BackColor = System.Drawing.Color.White;
            this.CopyPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPasswordButton.Location = new System.Drawing.Point(203, 351);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(411, 50);
            this.CopyPasswordButton.TabIndex = 3;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = false;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.passwordLengthSlider);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label PasswordLengthLabel;
        private System.Windows.Forms.TrackBar passwordLengthSlider;
        private System.Windows.Forms.Button CopyPasswordButton;
    }
}

